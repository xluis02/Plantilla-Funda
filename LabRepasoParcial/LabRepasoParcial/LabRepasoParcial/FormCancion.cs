using LabRepasoParcial.entities;
using LabRepasoParcial.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepasoParcial
{
    public partial class FormCancion : Form
    {
        private CancionService cancionService = new CancionService();
        private String codigoAlbum;

        public FormCancion(String codigoAlbum)
        {
            InitializeComponent();
            this.codigoAlbum = codigoAlbum;
            MostrarCanciones(cancionService.ListarTodo(this.codigoAlbum));
        }

        private void MostrarCanciones(List<Cancion> canciones)
        {
            dgCanciones.DataSource = null;
            if(canciones.Count==0)
            {
                return;
            }
            else
            {
                dgCanciones.DataSource = canciones;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbNroPista.Text == "" || tbDuracion.Text == "" )
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Cancion cancion = new Cancion()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                NroPista = int.Parse(tbNroPista.Text),
                Duracion = double.Parse(tbDuracion.Text),
                Sencillo = chbEsSencillo.Checked
            };

            bool registrado = cancionService.Registrar(codigoAlbum, cancion);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }

            MostrarCanciones(cancionService.ListarTodo(codigoAlbum));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
