using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using QuetzalExpress.Models;

namespace QuetzalExpress.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {

            ServicioWebCliente.WebServiceSoapClient ws = new ServicioWebCliente.WebServiceSoapClient();
            ws.Insert_Usuario(txtUsuario.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtDpi.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text);

 
        }
    }
}