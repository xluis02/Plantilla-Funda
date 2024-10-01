using LabDominos.entities;
using LabDominos.services;
using LabDominos.util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabDominos.forms
{
    public partial class FormReporte : Form
    {
        private ReporteService reporteService = new ReporteService();

        public FormReporte()
        {
            InitializeComponent();
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

        private void MostrarReportesMonto(List<ReporteMonto> reportesMonto)
        {
            dgReportesMonto.DataSource = null;
            if (reportesMonto.Count == 0)
            {
                return;
            }
            else
            {
                dgReportesMonto.DataSource = reportesMonto;
            }
        }

        private void btnListarPedidosEnRangoDeFechas_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Text == "" || dtpFechaFin.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            MostrarPedidos(reporteService.ListarPedidosEnRangoDeFechas(fechaInicio, fechaFin));
        }

        private void btnListarMontoPorDistrito_Click(object sender, EventArgs e)
        {
            MostrarReportesMonto(reporteService.ListarMontoPorDistrito());
        }

        private void btnObtenerMontoPedidosPorCodigoSedeYFechaLimite_Click(object sender, EventArgs e)
        {
            if (tbCodigoSede.Text == "" || dtpFechaLimite.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            String codigoSede = tbCodigoSede.Text;
            DateTime fechaLimite = dtpFechaLimite.Value;

            Decimal monto = reporteService.ObtenerMontoPedidosPorCodigoSedeYFechaLimite(codigoSede, fechaLimite);
            lblMonto.Text = monto.ToString();
        }

        private void btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo_Click(object sender, EventArgs e)
        {
            if (tbDNICliente.Text == "" || tbMontoMaximo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Decimal montoMaximo = 0;
            try
            {
                montoMaximo = Decimal.Parse(tbMontoMaximo.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ingrese el monto correctamente");
                return;
            }

            String dniCliente = tbDNICliente.Text;

            int cantidad = reporteService.ObtenerCantidadPedidosPorDNIClienteYMontoMaximo(dniCliente, montoMaximo);
            lblCantidad.Text = cantidad.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
