using System;

namespace LabDominos.entities
{
    internal class Pedido
    {
        public String CodigoPedido { get; set; }
        public String DNICliente { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Monto { get; set; }
        public String Detalle { get; set; }
    }
}
