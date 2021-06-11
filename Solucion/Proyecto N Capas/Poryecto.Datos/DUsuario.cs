using Poryecto.Datos;
using Proyecto.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Datos
{
    public class DUsuario
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("usuario_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); 
            }
        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("usuario_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public Usuario BuscarPorEmail(string Valor)
        {
            SqlDataReader Resultado;

            //DataTable Tabla = new DataTable();
            Usuario NUsuario = new Usuario();

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("usuario_buscarEmail", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.Read())
                {
                    NUsuario.IdUsuario = Resultado.GetFieldValue<int>(Resultado.GetOrdinal("IdUsuario"));
                    NUsuario.Nombre = Resultado.GetFieldValue<string>(Resultado.GetOrdinal("Nombre"));
                    NUsuario.Email = Resultado.GetFieldValue<string>(Resultado.GetOrdinal("Email"));
                    NUsuario.Contrasena = Resultado.GetFieldValue<string>(Resultado.GetOrdinal("Contrasena"));
                    NUsuario.Rol = Resultado.GetFieldValue<string>(Resultado.GetOrdinal("Rol"));

                    return NUsuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
