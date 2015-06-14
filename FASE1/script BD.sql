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