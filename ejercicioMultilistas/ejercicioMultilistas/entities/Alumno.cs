using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioMultilistas.entities
{
    class Alumno
    {
        public Alumno() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
