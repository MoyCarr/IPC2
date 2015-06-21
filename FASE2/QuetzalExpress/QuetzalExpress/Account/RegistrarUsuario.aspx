<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="QuetzalExpress.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Crear una nueva cuenta</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtUsuario" CssClass="col-md-2 control-label">Usuario</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsuario"
                    CssClass="text-danger" ErrorMessage="El campo de Usuario es obligatorio." />
            </div>
        </div>
         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre"
                    CssClass="text-danger" ErrorMessage="El campo de Nombre es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtApellido" CssClass="col-md-2 control-label">Apellido</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtApellido"
                    CssClass="text-danger" ErrorMessage="El campo de Apellido es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtDpi" CssClass="col-md-2 control-label">DPI</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtDpi" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDpi"
                    CssClass="text-danger" ErrorMessage="El campo de DPI es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtTelefono" CssClass="col-md-2 control-label">Telefono</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTelefono"
                    CssClass="text-danger" ErrorMessage="El campo de Telefono es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtDireccion" CssClass="col-md-2 control-label">Direccion</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDireccion"
                    CssClass="text-danger" ErrorMessage="El campo de Direccion es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-2 control-label">Correo electrónico</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="text-danger" ErrorMessage="El campo de correo electrónico es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-md-2 control-label">Contraseña</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="text-danger" ErrorMessage="El campo de contraseña es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtConfirmPassword" CssClass="col-md-2 control-label">Confirmar contraseña</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="El campo de confirmación de contraseña es obligatorio." />
                <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="La contraseña y la contraseña de confirmación no coinciden." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Registrarse" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
