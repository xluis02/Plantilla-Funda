using LabRepasoParcial.entities;
using LabRepasoParcial.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepasoParcial.services
{
    class ReporteService
    {
        private ReporteRepository reporteRepository = new ReporteRepository();

        public List<Reporte> ListarGeneroConMasAlbumes()
        {
            return reporteRepository.ListarGeneroConMasAlbumes();
        }
    }
}
