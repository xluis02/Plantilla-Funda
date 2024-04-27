using ejercicioMultilistas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioMultilistas.repositories
{
    class AlumnoRepository
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        public bool Existe(String codigo)
        {
            return alumnos.Exists(a => a.Codigo.Equals(codigo));
        }

        public void Registrar(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public static List<Alumno> ListarTodo()
        {
            return alumnos;
        }

        public void Eliminar(String codigo)
        {
            alumnos.RemoveAll(a => a.Codigo.Equals(codigo));
        }

        public void EliminarTodo()
        {
            alumnos.Clear();
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            return alumnos.Where(a => a.Nombre.Contains(nombre)).ToList();
        }

        public List<Alumno> ListarAlumnoConMenosCursos()
        {
            List<Alumno> alumnoTemp = new List<Alumno>();
            int menorCantCursosTotal = 9999999;

            foreach(Alumno alumno in alumnos)
            {
                List<Curso> cursos = alumno.Cursos;
                int cantCursosPorAlumno = cursos.Count;

                if(cantCursosPorAlumno < menorCantCursosTotal)
                {
                    menorCantCursosTotal = cantCursosPorAlumno;
                    alumnoTemp.Clear();
                    alumnoTemp.Add(alumno);
                }
                else if (cantCursosPorAlumno == menorCantCursosTotal)
                {
                    alumnoTemp.Add(alumno);
                }
            }

            return alumnoTemp;
        }

        public List<Alumno> ListarAlumnosConNotasMasAltasPorCurso()
        {
            List<Alumno> alumnoTemp = new List<Alumno>();
            int notaMasAltaTotal = 0;

            foreach (Alumno alumno in alumnos)
            {
                List<Curso> cursos = alumno.Cursos;

                if(cursos.Count != 0)
                {
                    int NotaMasAlta = cursos.Max(n => n.Nota);

                    if(NotaMasAlta > notaMasAltaTotal)
                    {
                        notaMasAltaTotal = NotaMasAlta;
                        alumnoTemp.Clear();
                        alumnoTemp.Add(alumno);
                    }
                    else if (NotaMasAlta == notaMasAltaTotal)
                    {
                        alumnoTemp.Add(alumno);
                    }
                }
            }
            return alumnoTemp;
        }
    }
}
