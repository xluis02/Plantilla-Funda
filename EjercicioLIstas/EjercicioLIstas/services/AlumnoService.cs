using EjercicioLIstas.entities;
using EjercicioLIstas.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLIstas.services
{
    class AlumnoService
    {
        private AlumnoRepository alumnoRepository = new AlumnoRepository();

        public bool Registrar(Alumno alumno)
        {
            if(alumnoRepository.Existe(alumno.Codigo))
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

        public List<Alumno> OrdenarPorPrecio()
        {
            return alumnoRepository.OrdenarPorNota();
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            return alumnoRepository.BuscarPorNombre(nombre);
        }

        public List<Alumno> BuscarPorCodigo(String codigo)
        {
            return alumnoRepository.BuscarPorCodigo(codigo);
        }
    }
}
