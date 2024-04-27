using ejercicioMultilistas.entities;
using ejercicioMultilistas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioMultilistas.services
{
    class AlumnoService
    {
        private AlumnoRepository alumnoRepository = new AlumnoRepository();

        public bool Registrar(Alumno alumno)
        {
            if (alumnoRepository.Existe(alumno.Codigo))
            {
                return false;
            }
            else
            {
                alumnoRepository.Registrar(alumno);
                return true;
            }
        }

        public List<Alumno> ListarTodo()
        {
            return AlumnoRepository.ListarTodo();
        }

        public void Eliminar(String codigo)
        {
            alumnoRepository.Eliminar(codigo);
        }

        public void EliminarTodo()
        {
            alumnoRepository.EliminarTodo();
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            return alumnoRepository.BuscarPorNombre(nombre);
        }

        public List<Alumno> ListarAlumnoConMenosCursos()
        {
            return alumnoRepository.ListarAlumnoConMenosCursos();
        }

        public List<Alumno> ListarAlumnosConNotasMasAltasPorCurso()
        {
            return alumnoRepository.ListarAlumnosConNotasMasAltasPorCurso();
        }
    }
}
