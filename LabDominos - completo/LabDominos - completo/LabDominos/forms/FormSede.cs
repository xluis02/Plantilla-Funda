using LabDominos.entities;
using LabDominos.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabDominos.forms
{
    public partial class FormSede : Form
    {
        private SedeService sedeService = new SedeService();

        public FormSede()
        {
            InitializeComponent();
            MostrarSedes(sedeService.ListarTodo());

        }

        private void MostrarSedes(List<Sede> sedes)
        {
            dgSedes.DataSource = null;
            if (sedes.Count == 0)
            {
                return;
            }
            else
            {
                dgSedes.DataSource = sedes;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigoSede.Text == "" || tbNombre.Text == "" || cbDistrito.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Sede sede = new Sede()
            {
                CodigoSede = tbCodigoSede.Text,
                Nombre = tbNombre.Text,
                Distrito = cbDistrito.Text,
                Direccion = tbDireccion.Text,
                // ¡Importante!
                Pedidos = new List<Pedido>()
            };

            // Registro
            bool registrado = sedeService.Registrar(sede);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en DataGrid
            MostrarSedes(sedeService.ListarTodo());
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {

            if (dgSedes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione sede");
                return;
            }

            String codigoSede = dgSedes.SelectedRows[0].Cells["CodigoSede"].Value.ToString();
            String nombreSede = dgSedes.SelectedRows[0].Cells["Nombre"].Value.ToString();

            FormPedido form = new FormPedido(codigoSede, nombreSede);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
