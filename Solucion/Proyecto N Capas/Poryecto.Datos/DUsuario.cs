using Poryecto.Datos;
using Proyecto.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Datos
{
    class DUsuario
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

                SqlCommand Comando = new SqlCommand("usuario_buscarr", SqlCon);
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
    }
}
