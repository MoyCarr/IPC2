using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace QuetzalExpress
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://localhost/WebService", Name="WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

      
        [WebMethod]
        public void Insert_Usuario(string login, string pass, string nombre, string apellido, string dpi, string tefelono, string direccion, string email)
        {

            DataSet ds = new DataSet();
            string connStr = "server=MOISES;integrated security=true;database=QuetzalExpress";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "Insert into Usuario values ('"+ login +"', '"+pass+"', '"+nombre+"', '"+apellido+"', '"+dpi+"', '"+tefelono+"', '"+direccion+"', '"+email+"', '')";
                SqlDataAdapter cmd = new SqlDataAdapter();
                cmd.InsertCommand = new SqlCommand(sql, conn);
               
                    try
                    {
                        conn.Open();
                        cmd.InsertCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                    
                    }
                    finally
                    {
                        conn.Close();
                    }
                 }               
        }


        [WebMethod]
        public int rol(string login)
        {

            int resultado;
            string connStr = "server=MOISES;integrated security=true;database=QuetzalExpress";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                
                SqlCommand cmd = new SqlCommand("SELECT rol FROM USUARIO WHERE login = '" + login + "'", conn);


                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    resultado =  Convert.ToInt32(reader["rol"]);

                }
                else
                {
                    resultado = 0;
                }
                conn.Close();
                return resultado;

            }
        }
    }
}
