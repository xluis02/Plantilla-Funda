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
    public partial class FormAlbum : Form
    {
        private AlbumService albumService = new AlbumService();

        public FormAlbum()
        {
            InitializeComponent();
            MostrarAlbumes(albumService.ListarTodo());
        }

        private void MostrarAlbumes(List<Album> albums)
        {
            dgAlbumes.DataSource = null;
            if(albums.Count==0)
            {
                return;
            }
            else
            {
                dgAlbumes.DataSource = albums;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == ""|| tbNombre.Text == "" || tbAño.Text == "" || tbInterprete.Text == "" || cbValoracion.Text == "" || cbGenero.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Album album = new Album()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Año = int.Parse(tbAño.Text),
                Interprete = tbInterprete.Text,
                Valoracion = int.Parse(cbValoracion.Text),
                Genero = cbGenero.Text,
                Canciones = new List<Cancion>()
            };

            bool registrado = albumService.Registrar(album);
            if(!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }

            MostrarAlbumes(albumService.ListarTodo());
        }

        private void btnVerCanciones_Click(object sender, EventArgs e)
        {
            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un album");
                return;
            }

            String codigoAlbum = dgAlbumes.SelectedRows[0].Cells[0].Value.ToString();

            FormCancion form = new FormCancion(codigoAlbum);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reporte form = new Reporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
