using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{
    class Libro
    {
        public int IdLibro { get; set; }

        public int Num_Ejemplares { get; set; }

        public string Isbn { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public string Anio_Edicion { get; set; }

        public int Num_Edicion { get; set; }

        public string Pais { get; set; }

        public string Idioma { get; set; }

        public string Materia { get; set; }

        public string Num_Paginas { get; set; }

        public string Ubicacion { get; set; }

        public string Descripcion { get; set; }
    }
}
