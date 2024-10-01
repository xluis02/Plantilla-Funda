using LabDominos.entities;
using LabDominos.util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabDominos.repositories
{
    internal class ReporteRepository
    {
        public List<Pedido> ListarPedidosEnRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Sede> sedes = SedeRepository.ListarTodo();
            List<Pedido> pedidos = sedes.SelectMany(s => s.Pedidos).ToList();
            return pedidos.Where(p => p.Fecha >= fechaInicio && p.Fecha <= fechaFin).ToList();
        }

        public List<ReporteMonto> ListarMontoPorDistrito()
        {
            List<Sede> sedes = SedeRepository.ListarTodo();
            List<Pedido> pedidos = sedes.SelectMany(s => s.Pedidos).ToList();

            return sedes.GroupBy(s => s.Distrito)
                .Select(r => new ReporteMonto()
                {
                    Distrito = r.Key,
                    Monto = r.Sum(s => s.Pedidos.Sum(p => p.Monto))
                }).ToList();
        }

        public Decimal ObtenerMontoPedidosPorCodigoSedeYFechaLimite(String codigoSede, DateTime fechaLimite)
        {
            List<Sede> sedes = SedeRepository.ListarTodo().Where(s => s.CodigoSede.Equals(codigoSede)).ToList();
            List<Pedido> pedidos = sedes.SelectMany(s => s.Pedidos)
                .Where(p => p.Fecha <= fechaLimite).ToList();
            return pedidos.Sum(p => p.Monto);
        }

        public int ObtenerCantidadPedidosPorDNIClienteYMontoMaximo(String dniCliente, Decimal montoMaximo)
        {
            List<Sede> sedes = SedeRepository.ListarTodo();
            List<Pedido> pedidos = sedes.SelectMany(s => s.Pedidos)
                .Where(p => p.DNICliente.Equals(dniCliente) && p.Monto <= montoMaximo).ToList();
            return pedidos.Count;
        }
    }
}
