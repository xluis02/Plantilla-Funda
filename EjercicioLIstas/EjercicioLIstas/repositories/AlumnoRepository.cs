using EjercicioLIstas.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLIstas.repositories
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

        public List<Alumno> OrdenarPorNota()
        {
            // Ordena de menor a mayor
            return alumnos.OrderBy(a => a.Nota).ToList();

            // Ordena de mayor a menor
            //return alumnos.OrderByDescending(a => a.Nota).ToList();
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            return alumnos.Where(a => a.Nombre.Contains(nombre)).ToList();
        }

        public List<Alumno> BuscarPorCodigo(String codigo)
        {
            return alumnos.Where(a => a.Codigo.Contains(codigo)).ToList();
        }
    }
}
