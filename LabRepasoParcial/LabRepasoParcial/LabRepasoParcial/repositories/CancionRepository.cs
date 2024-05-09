using LabRepasoParcial.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.repositories
{
    class CancionRepository
    {
        public bool Existe(String codigoCancion)
        {
            List<Album> albums = AlbumRepository.ListarTodo();
            return albums.Exists(a => a.Canciones.Exists(c => c.Codigo.Equals(codigoCancion)));
        }

        public void Registrar(String codigoAlbum, Cancion cancion)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));
            album.Canciones.Add(cancion);
        }

        public List<Cancion> ListarTodo(String codigoAlbum)
        {
            List<Album> albums = AlbumRepository.ListarTodo();
            Album album = albums.Find(a => a.Codigo.Equals(codigoAlbum));
            return album.Canciones;
        }

        public List<Cancion> ListarCancionesPorInterpreteDelAlbum(String interprete)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            albumes = albumes.Where(a => a.Interprete.Equals(interprete)).ToList();
            List<Cancion> cancionesTemp = new List<Cancion>();

            foreach (Album album in albumes)
            {
                cancionesTemp.AddRange(album.Canciones);
            }
            return cancionesTemp;
        }

        public List<Cancion> ListarCancionesMasLargas()
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            double duracionCancionMasLargaTotal = double.MinValue;
            List<Cancion> cancionesTemp = new List<Cancion>();

            foreach (Album album in albumes)
            {
                List<Cancion> canciones = album.Canciones;
                if (canciones.Count != 0)
                {
                    double duracionCancionMasLargaEnAlbum = canciones.Max(c => c.Duracion);
                    if (duracionCancionMasLargaEnAlbum > duracionCancionMasLargaTotal)
                    {
                        duracionCancionMasLargaTotal = duracionCancionMasLargaEnAlbum;
                        cancionesTemp.Clear();
                        cancionesTemp.AddRange(canciones.Where(c => c.Duracion.Equals(duracionCancionMasLargaTotal)));

                    }
                    else if (duracionCancionMasLargaEnAlbum == duracionCancionMasLargaTotal)
                    {
                        cancionesTemp.AddRange(canciones.Where(c => c.Duracion.Equals(duracionCancionMasLargaTotal)));
                    }
                }
            }
            return cancionesTemp;
        }
    }
}
