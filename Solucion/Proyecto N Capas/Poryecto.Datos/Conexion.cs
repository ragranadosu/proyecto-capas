using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poryecto.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "proyecto";
            this.Servidor = "MOPT-PC";
            this.Usuario = "root";
            this.Clave = " ";
            this.Seguridad = true; //Seguridad windows
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                //Cadena.ConnectionString = "Data Source=DESKTOP-I9I44NU\\SQLEXPRESS;Initial Catalog=dbsistema;User ID=sa;Password=trollface12";
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";

                if (this.Seguridad) //Serguridad de Windows
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI;";
                }
                else //Seguridad sql server
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id = " + this.Usuario + "; Password =" + this.Clave + ";";
                }
            }
            catch (Exception e)
            {
                Cadena = null;
                throw e;
            }
            return Cadena;

        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }

            return Con;
        }
    }
}
