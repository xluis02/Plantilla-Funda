using ejercicioMultilistas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioMultilistas.repositories
{
    class CursoRepository
    {
        public bool Existe(String codigoCurso)
        {
            List<Alumno> alumnos = AlumnoRepository.ListarTodo();
            return alumnos.Exists(a => a.Codigo.Equals(codigoCurso));
        }

        public void Registrar(String codigoAlumno, Curso curso)
        {
            List<Alumno> alumnos = AlumnoRepository.ListarTodo();
            Alumno alumno = alumnos.Find(a => a.Codigo.Equals(codigoAlumno));

            alumno.Cursos.Add(curso);
        }

        public List<Curso> ListarTodo(String codigoAlumno)
        {
            List<Alumno> alumnos = AlumnoRepository.ListarTodo();
            Alumno alumno = alumnos.Find(a => a.Codigo.Equals(codigoAlumno));
            return alumno.Cursos;
        }

        public List<Curso> ListarCursosPorAlumno(String nombreAlumno)
        {
            List<Alumno> alumnos = AlumnoRepository.ListarTodo();
            alumnos = alumnos.Where(a => a.Nombre.Equals(nombreAlumno)).ToList();

            List<Curso> cursoTemp = new List<Curso>();

            foreach (Alumno alumno in alumnos)
            {
                cursoTemp.AddRange(alumno.Cursos);
            }
            return cursoTemp;
        }
    }
}
