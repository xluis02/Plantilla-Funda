using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.entities
{
    class Cancion
    {
        public Cancion() { }

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int NroPista { get; set; }
        public double Duracion { get; set; }
        public bool Sencillo { get; set; }
    }
}
