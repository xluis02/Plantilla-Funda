using System;
using System.Collections.Generic;

namespace LabDominos.entities
{
    internal class Sede
    {
        public String CodigoSede { get; set; }
        public String Nombre { get; set; }
        public String Distrito { get; set; }
        public String Direccion { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
