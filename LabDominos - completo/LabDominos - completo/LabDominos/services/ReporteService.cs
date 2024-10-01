using LabDominos.entities;
using LabDominos.repositories;
using LabDominos.util;
using System;
using System.Collections.Generic;

namespace LabDominos.services
{
    internal class ReporteService
    {
        private ReporteRepository reporteRepository = new ReporteRepository();

        public List<Pedido> ListarPedidosEnRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return reporteRepository.ListarPedidosEnRangoDeFechas(fechaInicio, fechaFin);
        }

        public List<ReporteMonto> ListarMontoPorDistrito()
        {
            return reporteRepository.ListarMontoPorDistrito();
        }

        public Decimal ObtenerMontoPedidosPorCodigoSedeYFechaLimite(String codigoSede, DateTime fechaLimite)
        {
            return reporteRepository.ObtenerMontoPedidosPorCodigoSedeYFechaLimite(codigoSede, fechaLimite);
        }

        public int ObtenerCantidadPedidosPorDNIClienteYMontoMaximo(String dniCliente, Decimal montoMaximo)
        {
            return reporteRepository.ObtenerCantidadPedidosPorDNIClienteYMontoMaximo(dniCliente, montoMaximo);
        }
    }
}
