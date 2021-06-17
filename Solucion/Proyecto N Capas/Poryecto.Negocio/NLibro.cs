using Proyecto.Datos;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Negocio
{
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Libros = new DLibro();

            return Libros.Listar();
        }

        public static DataTable ListarActivo()
        {
            DLibro Libros = new DLibro();

            return Libros.ListarActivos();
        }

        public static DataTable Buscar(string Valor)
        {
            DLibro Libros = new DLibro();

            return Libros.Buscar(Valor);
        }

        public static string Insertar(string Codigo, string Titulo, bool Prestado, int NumEjemplares, string Isbn, string Autor, string Editorial, string AnioEdicion, int NumEdicion, string Pais, string Idioma, string Materia, int NumPaginas, string Ubicacion, string Descripcion, bool Activo)
        {
            DLibro Datos = new DLibro();

            //string Existe = Datos.Existe(Nombre);
            if (false)
            {
                return "El artículo ya existe";
            }
            else
            {
                Libro Obj = new Libro();
                Obj.Codigo = Codigo;
                Obj.Titulo = Titulo;
                Obj.Prestado = Prestado;
                Obj.NumEjemplares = NumEjemplares;
                Obj.Isbn = Isbn;
                Obj.Autor = Autor;
                Obj.Editorial = Editorial;
                Obj.AnioEdicion = AnioEdicion;
                Obj.NumEdicion = NumEdicion;
                Obj.Pais = Pais;
                Obj.Idioma = Idioma;
                Obj.Materia = Materia;
                Obj.NumPaginas = NumPaginas;
                Obj.Ubicacion = Ubicacion;
                Obj.Descripcion = Descripcion;
                Obj.Activo = Activo;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int IdLibro, string Codigo, string Titulo, int NumEjemplares, string Isbn, string Autor, string Editorial, string AnioEdicion, int NumEdicion, string Pais, string Idioma, string Materia, int NumPaginas, string Ubicacion, string Descripcion, bool Activo)
        {
            DLibro Datos = new DLibro();


            Libro Obj = new Libro();
            Obj.IdLibro = IdLibro;
            Obj.Codigo = Codigo;
            Obj.Titulo = Titulo;
            Obj.NumEjemplares = NumEjemplares;
            Obj.Isbn = Isbn;
            Obj.Autor = Autor;
            Obj.Editorial = Editorial;
            Obj.AnioEdicion = AnioEdicion;
            Obj.NumEdicion = NumEdicion;
            Obj.Pais = Pais;
            Obj.Idioma = Idioma;
            Obj.Materia = Materia;
            Obj.NumPaginas = NumPaginas;
            Obj.Ubicacion = Ubicacion;
            Obj.Descripcion = Descripcion;
            Obj.Activo = Activo;
            return Datos.Actualizar(Obj);

        }
    }
}
