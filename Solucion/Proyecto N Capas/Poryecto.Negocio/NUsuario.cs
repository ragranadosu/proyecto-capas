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
    public class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();

            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DUsuario Datos = new DUsuario();

            return Datos.Buscar(Valor);
        }

        public static Usuario BuscarPorEmail(string Valor)
        {
            DUsuario Datos = new DUsuario();

            return Datos.BuscarPorEmail(Valor);
        }
    }
}
