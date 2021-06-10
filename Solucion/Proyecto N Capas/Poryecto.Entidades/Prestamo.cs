using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }

        public int Libro { get; set; }

        public int Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaLimite { get; set; }
    }
}
