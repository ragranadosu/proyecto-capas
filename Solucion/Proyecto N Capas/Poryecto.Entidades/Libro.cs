using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }

        public string Codigo { get; set; }

        public string Titulo { get; set; }

        public bool Prestado { get; set; }

        public int NumEjemplares { get; set; }

        public string Isbn { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public string AnioEdicion { get; set; }

        public int NumEdicion { get; set; }

        public string Pais { get; set; }

        public string Idioma { get; set; }

        public string Materia { get; set; }

        public int NumPaginas { get; set; }

        public string Ubicacion { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
