using Proyecto.Datos;
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
    }
}
