using LabDominos.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LabDominos.repositories
{
    internal class PedidoRepository
    {
        public bool Existe(String codigoPedido)
        {
            List<Sede> sedes = SedeRepository.ListarTodo();
            List<Pedido> pedidos = sedes.SelectMany(s => s.Pedidos).ToList();
            return pedidos.Exists(p => p.CodigoPedido.Equals(codigoPedido));;
        }

        public void Registrar(String codigoSede, Pedido pedido)
        {
            List<Sede> sedes = SedeRepository.ListarTodo();
            Sede sede = sedes.FirstOrDefault(s => s.CodigoSede.Equals(codigoSede));
            sede.Pedidos.Add(pedido);
        }

        public static List<Pedido> ListarTodo(String codigoSede)
        {
            List<Sede> sedes = SedeRepository.ListarTodo();
            Sede sede = sedes.FirstOrDefault(s => s.CodigoSede.Equals(codigoSede));
            return sede.Pedidos;
        }
    }
}
