using Proyecto.Datos;
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
    }
}
