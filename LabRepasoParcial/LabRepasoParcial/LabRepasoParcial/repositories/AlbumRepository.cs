using LabRepasoParcial.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.repositories
{
    class AlbumRepository
    {
        private static List<Album> albumes = new List<Album>();

        public bool Existe(String codigoAlbum)
        {
            return albumes.Exists(a => a.Codigo.Equals(codigoAlbum));
        }

        public void Registrar(Album album)
        {
            albumes.Add(album);
        }

        public static List<Album> ListarTodo()
        {
            return albumes;
        }

        public List<Album> ListarAlbumesConCancionesConMenorDuracion()
        {
            List<Album> albumesTemp = new List<Album>();
            double menorDuracionTotal = double.MaxValue;

            foreach(Album album in albumes)
            {
                List<Cancion> canciones = album.Canciones;
                if (canciones.Count != 0)
                {
                    double menorDuracionEnAlbum = canciones.Min(c => c.Duracion);
                    if (menorDuracionEnAlbum < menorDuracionTotal)
                    {
                        menorDuracionTotal = menorDuracionEnAlbum;
                        albumesTemp.Clear();
                        albumesTemp.Add(album);
                    }
                    else if (menorDuracionEnAlbum == menorDuracionTotal)
                    {
                        albumesTemp.Add(album);
                    }
                }
            }
            return albumesTemp;
        }

        public List<Album> ListarAlbumesConMasCanciones()
        {
            List<Album> albumesTemp = new List<Album>();
            int mayorCantidadCancionesTotal = int.MinValue;

            foreach (Album album in albumes)
            {
                List<Cancion> canciones = album.Canciones;
                int cantidadCancionesEnAlbum = canciones.Count;
                if(cantidadCancionesEnAlbum > mayorCantidadCancionesTotal)
                {
                    mayorCantidadCancionesTotal = cantidadCancionesEnAlbum;
                    albumesTemp.Clear();
                    albumesTemp.Add(album);
                }
                else if (cantidadCancionesEnAlbum == mayorCantidadCancionesTotal)
                {
                    albumesTemp.Add(album);
                }
            }
            return albumesTemp;
        }

        public List<Album> ListarAlbumesPorCantidadSencillos(int cantSencillos)
        {
            List<Album> albumesTemp = new List<Album>();
            foreach (Album album in albumes)
            {
                List<Cancion> canciones = album.Canciones;
                int cantSencillosEnAlbum = canciones.Count(c => c.Sencillo == true);
                
                if(cantSencillosEnAlbum == cantSencillos)
                {
                    albumesTemp.Add(album);
                }
            }
            return albumesTemp;
        }
    }
}
