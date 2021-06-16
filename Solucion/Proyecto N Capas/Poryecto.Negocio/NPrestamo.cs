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
    public class NPrestamo
    {
        public static DataTable Listar()
        {
            DPrestamo Datos = new DPrestamo();

            return Datos.Listar();
        }

        public static DataTable BuscarPorProfesor(int Valor)
        {
            DPrestamo Datos = new DPrestamo();

            return Datos.BuscarPorProfesor(Valor);
        }

        public static string Insertar(int Libro, int Usuario, DateTime Fecha, DateTime FechaLimite)
        {
            DPrestamo Datos = new DPrestamo();

            Prestamo Obj = new Prestamo();
            Obj.Libro = Libro;
            Obj.Usuario = Usuario;
            Obj.Fecha = Fecha;
            Obj.FechaLimite = FechaLimite;

            return Datos.Insertar(Obj);

        }

        public static string Devolver(int IdPrestamo, int IdLibro)
        {
            DPrestamo Datos = new DPrestamo();

            return Datos.Devolver(IdPrestamo, IdLibro);
        }

    }
}
