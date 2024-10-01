using LabDominos.entities;
using LabDominos.repositories;
using System;
using System.Collections.Generic;

namespace LabDominos.services
{
    internal class PedidoService
    {
        private PedidoRepository pedidoRepository = new PedidoRepository();

        public bool Registrar(String codigoSede, Pedido pedido)
        {
            if (pedidoRepository.Existe(pedido.CodigoPedido))
            {
                return false;
            }
            else
            {
                pedidoRepository.Registrar(codigoSede, pedido);
                return true;
            }
        }

        public List<Pedido> ListarTodo(String codigoSede)
        {
            return PedidoRepository.ListarTodo(codigoSede);
        }
    }
}
