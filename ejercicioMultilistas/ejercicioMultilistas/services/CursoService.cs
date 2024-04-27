using ejercicioMultilistas.entities;
using ejercicioMultilistas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioMultilistas.services
{
    class CursoService
    {
        private CursoRepository cursoRepository = new CursoRepository();

        public bool Registrar(String codigoAlumno, Curso curso)
        {
            if(cursoRepository.Existe(curso.Codigo))
            {
                return false;
            }
            else
            {
                cursoRepository.Registrar(codigoAlumno, curso);
                return true;
            }
        }

        public List<Curso> ListarTodo(String codigoAlumno)
        {
            return cursoRepository.ListarTodo(codigoAlumno);
        }

        public List<Curso> ListarCursosPorAlumno(String nombreAlumno)
        {
            return cursoRepository.ListarCursosPorAlumno(nombreAlumno);
        }
    }
}
