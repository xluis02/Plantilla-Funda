using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.entities
{
    class Album
    {
        public Album() { }

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Año { get; set; }
        public String Interprete { get; set; }
        public int Valoracion { get; set; }
        public String Genero { get; set; }
        public List<Cancion> Canciones { get; set; }
    }
}
