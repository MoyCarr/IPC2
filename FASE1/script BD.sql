CREATE DATABASE QuetzalExpress

USE QuetzalExpress

CREATE TABLE SEDE(
cod_Sede varchar(10) NOT NULL,
pais varchar(45) NOT NULL,
direccion varchar (45) NOT NULL,
tefefono int NOT NULL
CONSTRAINT PK_SEDE_cod_Sede PRIMARY KEY(cod_Sede)
)


CREATE TABLE SUCURSAL(
cod_Sucursal varchar(10) NOT NULL,
pais varchar(45) NOT NULL,
direccion varchar(45) NOT NULL,
telefono int NOT NULL,
capacidad int NOT NULL,
cod_Sede varchar (10) NOT NULL
CONSTRAINT PK_SUCURSAL_cod_Sucursal PRIMARY KEY(cod_Sucursal)
CONSTRAINT FK_SUCURSAL_cod_Sede FOREIGN KEY(cod_Sede) REFERENCES SEDE(cod_Sede)
)


CREATE TABLE DEPARTAMENTO(
cod_Departamento varchar (10) NOT NULL,
nombre varchar(45) NOT NULL,
director varchar(45) NOT NULL
CONSTRAINT PK_DEPARTAMENTO_cod_Departamento PRIMARY KEY(cod_Departamento)
)


CREATE TABLE ASIG_DEPTO(
cod_Asignacion varchar(10) NOT NULL,
cod_Sucursal varchar(10) NOT NULL,
cod_Depto varchar(10) NOT NULL
CONSTRAINT PK_ASIG_DEPTO_cod_Asignacion PRIMARY KEY(cod_Asignacion)
CONSTRAINT FK_ASIG_DEPTO_cod_Sucursal FOREIGN KEY(cod_Sucursal) REFERENCES SUCURSAL(cod_Sucursal),
CONSTRAINT FK_ASIG_DEPTO_cod_Depto FOREIGN KEY(cod_Depto) REFERENCES DEPARTAMENTO(cod_Departamento)
)


CREATE TABLE USUARIO(
login varchar(45) NOT NULL,
pass varchar(45) NOT NULL,
cod_Usuario varchar(10) NOT NULL,
nombre varchar(45) NOT NULL,
apellido varchar(45) NOT NULL,
dpi varchar(45) NOT NULL,
telefono int NOT NULL,
direccion varchar(45) NOT NULL,
email varchar(45) NOT NULL,
rol int NOT NULL
CONSTRAINT PK_USUARIO_login PRIMARY KEY(login)
)


CREATE TABLE EMPLEADO(
cod_Empleado varchar(10) NOT NULL,
sueldo decimal(10,2) NOT NULL,
login varchar(45) NOT NULL,
cod_Departamento varchar(10) NOT NULL
CONSTRAINT PK_EMPLEADO_cod_Empleado PRIMARY KEY(cod_Empleado)
CONSTRAINT FK_EMPLEADO_login FOREIGN KEY(login) REFERENCES USUARIO(login),
CONSTRAINT FK_EMPLEADO_cod_Departamento FOREIGN KEY(cod_Departamento) REFERENCES DEPARTAMENTO(cod_Departamento)
)


CREATE TABLE CLIENTE(
cod_Cliente varchar(10) NOT NULL,
tarjeta varchar(45) NOT NULL,
tarjeta_2 varchar(45),
tarjeta_3 varchar(45),
casilla varchar(10) NOT NULL,
login varchar(45) NOT NULL
CONSTRAINT PK_CLIENTE_cod_Cliente PRIMARY KEY(cod_Cliente)
CONSTRAINT FK_CLIENTE_login FOREIGN KEY(login) REFERENCES USUARIO(login)
)


CREATE TABLE ADMINISTRADOR(
cod_Administrador varchar(10) NOT NULL,
login varchar(45) NOT NULL
CONSTRAINT PK_ADMINISTRADOR_cod_Administrador PRIMARY KEY(cod_Administrador)
CONSTRAINT FK_ADMINISTRADOR_login FOREIGN KEY(login) REFERENCES USUARIO(login)
)


CREATE TABLE CATEGORIA(
cod_Categoria varchar(10) NOT NULL,
nombre varchar(45) NOT NULL,
porcentaje_comision int NOT NULL,
porcentaje_Aduana int NOT NULL,
costo_Libra int NOT NULL
CONSTRAINT PK_CATEGORIA_cod_Categoria PRIMARY KEY(cod_Categoria)
)


CREATE TABLE PAQUETE(
cod_Paquete varchar(10) NOT NULL,
peso int NOT NULL,
valor int NOT NULL,
estado varchar(45) NOT NULL,
cod_Categoria varchar(10) NOT NULL,
cod_Cliente varchar(10) NOT NULL
CONSTRAINT PK_PAQUETE_cod_Paquete PRIMARY KEY(cod_Paquete)
CONSTRAINT FK_PAQUETE_cod_Categoria FOREIGN KEY(cod_Categoria) REFERENCES CATEGORIA(cod_Categoria),
CONSTRAINT FK_PAQUETE_cod_Cliente FOREIGN KEY(cod_Cliente) REFERENCES CLIENTE(cod_Cliente)
)


CREATE TABLE FACTURA(
cod_Factura varchar(10) NOT NULL,
fecha datetime NOT NULL,
total decimal(10,2) NOT NULL,
cod_Cliente varchar(10) NOT NULL,
cod_Paquete varchar(10) NOT NULL,
cod_Empleado varchar(10) NOT NULL
CONSTRAINT PK_FACTURA_cod_Factura PRIMARY KEY(cod_Factura)
CONSTRAINT FK_FACTURA_cod_Cliente FOREIGN KEY(cod_Cliente) REFERENCES CLIENTE(cod_Cliente),
CONSTRAINT FK_FACTURA_cod_Paquete FOREIGN KEY(cod_Paquete) REFERENCES PAQUETE(cod_Paquete),
CONSTRAINT FK_FACTURA_cod_Empleado FOREIGN KEY(cod_Empleado) REFERENCES EMPLEADO(cod_Empleado)
)