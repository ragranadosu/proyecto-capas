using Poryecto.Datos;
using Proyecto.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Datos
{
    public class DLibro
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("libro_listar", SqlCon);
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

        public DataTable ListarActivos()
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("libro_listarActivos", SqlCon);
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

                SqlCommand Comando = new SqlCommand("libro_buscar", SqlCon);
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

        public string Insertar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Comando.Parameters.Add("@prestado", SqlDbType.Bit).Value = Obj.Prestado;
                Comando.Parameters.Add("@num_ejemplares", SqlDbType.Int).Value = Obj.NumEjemplares;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.Isbn;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.VarChar).Value = Obj.AnioEdicion;
                Comando.Parameters.Add("@num_edicion", SqlDbType.Int).Value = Obj.NumEdicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;
                Comando.Parameters.Add("@num_paginas", SqlDbType.Int).Value = Obj.NumPaginas;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@activo", SqlDbType.Bit).Value = Obj.Activo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = Obj.IdLibro;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Comando.Parameters.Add("@num_ejemplares", SqlDbType.Int).Value = Obj.NumEjemplares;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.Isbn;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.VarChar).Value = Obj.AnioEdicion;
                Comando.Parameters.Add("@num_edicion", SqlDbType.Int).Value = Obj.NumEdicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;
                Comando.Parameters.Add("@num_paginas", SqlDbType.Int).Value = Obj.NumPaginas;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@activo", SqlDbType.Bit).Value = Obj.Activo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
