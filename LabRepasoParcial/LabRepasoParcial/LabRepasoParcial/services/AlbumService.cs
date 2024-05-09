using LabRepasoParcial.entities;
using LabRepasoParcial.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.services
{
    class AlbumService
    {
        private AlbumRepository albumRepository = new AlbumRepository();

        public bool Registrar(Album album)
        {
            if(albumRepository.Existe(album.Codigo))
            {
                return false;
            }
            else
            {
                albumRepository.Registrar(album);
                return true;
            }
        }

        public List<Album> ListarTodo()
        {
            return AlbumRepository.ListarTodo();
        }

        public List<Album> ListarAlbumesConCancionesConMenorDuracion()
        {
            return albumRepository.ListarAlbumesConCancionesConMenorDuracion();
        }

        public List<Album> ListarAlbumesConMasCanciones()
        {
            return albumRepository.ListarAlbumesConMasCanciones();
        }

        public List<Album> ListarAlbumesPorCantidadSencillos(int cantSencillos)
        {
            return albumRepository.ListarAlbumesPorCantidadSencillos(cantSencillos);
        }
    }
}
