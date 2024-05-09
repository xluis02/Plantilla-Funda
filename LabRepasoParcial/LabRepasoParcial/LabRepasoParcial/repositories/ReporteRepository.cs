using LabRepasoParcial.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.repositories
{
    class ReporteRepository
    {
        public List<Reporte> ListarGeneroConMasAlbumes()
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            List<Reporte> reportes = albumes.GroupBy(a => a.Genero)
                .Select(
                    r => new Reporte()
                    {
                        Genero = r.Key,
                        Cantidad = r.Count()
                    }
                ).ToList();

            if (reportes.Count == 0) return new List<Reporte>();

            int cantMaxAlbumesPorGenero = reportes.Max(r => r.Cantidad);
            reportes = reportes.Where(r => r.Cantidad == cantMaxAlbumesPorGenero).ToList();
               
            return reportes;
        }
    }
}
