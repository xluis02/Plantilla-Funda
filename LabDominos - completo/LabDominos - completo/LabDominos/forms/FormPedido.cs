using LabDominos.entities;
using LabDominos.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabDominos
{
    public partial class FormPedido : Form
    {
        private PedidoService pedidoService = new PedidoService();
        private String codigoSede;

        public FormPedido(String codigoSede, String nombreSede)
        {
            InitializeComponent();
            this.codigoSede = codigoSede;
            lblNombreSede.Text = nombreSede;
            MostrarPedidos(pedidoService.ListarTodo(codigoSede));
        }

        private void MostrarPedidos(List<Pedido> pedidos)
        {
            dgPedidos.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgPedidos.DataSource = pedidos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigoPedido.Text == "" || tbDNICliente.Text == "" || dtpFecha.Text == "" || tbMonto.Text == "" || tbDetalle.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de decimal
            Decimal monto = 0;
            try
            {
                monto = Decimal.Parse(tbMonto.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ingrese el monto correctamente");
                return;
            }

            // Creación del objeto
            Pedido pedido = new Pedido()
            {
                CodigoPedido = tbCodigoPedido.Text,
                DNICliente = tbDNICliente.Text,
                Fecha = dtpFecha.Value,
                Monto = monto,
                Detalle = tbDetalle.Text
            };

            // Registro
            bool registrado = pedidoService.Registrar(codigoSede, pedido);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en DataGrid
            MostrarPedidos(pedidoService.ListarTodo(codigoSede));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
