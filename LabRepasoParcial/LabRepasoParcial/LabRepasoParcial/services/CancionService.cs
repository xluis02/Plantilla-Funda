using LabRepasoParcial.entities;
using LabRepasoParcial.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.services
{
    class CancionService
    {
        private CancionRepository cancionRepository = new CancionRepository();

        public bool Registrar(String codigoAlbum, Cancion cancion)
        {
            if (cancionRepository.Existe(cancion.Codigo))
            {
                return false;
            }
            else
            {
                cancionRepository.Registrar(codigoAlbum, cancion);
                return true;
            }
        }

        public List<Cancion> ListarTodo(String codigoAlbum)
        {
            return cancionRepository.ListarTodo(codigoAlbum);
        }

        public List<Cancion> ListarCancionesPorInterpreteDelAlbum(String interprete)
        {
            return cancionRepository.ListarCancionesPorInterpreteDelAlbum(interprete);
        }

        public List<Cancion> ListarCancionesMasLargas()
        {
            return cancionRepository.ListarCancionesMasLargas();
        }
    }
}
