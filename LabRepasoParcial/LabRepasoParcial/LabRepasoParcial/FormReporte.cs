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
    public partial class Reporte : Form
    {
        private CancionService cancionService = new CancionService();
        private AlbumService albumService = new AlbumService();
        private ReporteService reporteService = new ReporteService();

        public string Genero { get; internal set; }
        public int Cantidad { get; internal set; }

        public Reporte()
        {
            InitializeComponent();
        }

        private void MostrarAlbumes(List<Album> albums)
        {
            dgAlbumes.DataSource = null;
            if (albums.Count == 0)
            {
                return;
            }
            else
            {
                dgAlbumes.DataSource = albums;
            }
        }

        private void MostrarCanciones(List<Cancion> canciones)
        {
            dgCanciones.DataSource = null;
            if (canciones.Count == 0)
            {
                return;
            }
            else
            {
                dgCanciones.DataSource = canciones;
            }
        }

        private void MostrarReportes(List<Reporte> reportes)
        {
            dgReportes.DataSource = null;
            if (reportes.Count == 0)
            {
                return;
            }
            else
            {
                dgReportes.DataSource = reportes;
            }
        }

        private void btnAlbumesConCancionesConMenorDuracion_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumService.ListarAlbumesConCancionesConMenorDuracion());
        }

        private void btnListarAlbumesConMasCanciones_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumService.ListarAlbumesConMasCanciones());
        }

        private void btnListarAlbumesPorCantidadDeSencillos_Click(object sender, EventArgs e)
        {
            if (tbCantidadSencillos.Text == "")
            {
                MessageBox.Show("Ingrese cantidad de sencillos");
                return;
            }

            int cantidadSencillos = int.Parse(tbCantidadSencillos.Text);
            MostrarAlbumes(albumService.ListarAlbumesPorCantidadSencillos(cantidadSencillos));
        }

        private void btnListarCancionesPorInterpreteAlbum_Click(object sender, EventArgs e)
        {
            if (tbInterprete.Text == "")
            {
                MessageBox.Show("Ingrese interprete: ");
                return;
            }

            String interprete = tbInterprete.Text;
            MostrarCanciones(cancionService.ListarCancionesPorInterpreteDelAlbum(interprete));
        }

        private void btnListarCancionesMasLargas_Click(object sender, EventArgs e)
        {
            MostrarCanciones(cancionService.ListarCancionesMasLargas());
        }

        private void btnListarGeneroConMasAlbumes_Click(object sender, EventArgs e)
        {
            MostrarReportes(reporteService.ListarGeneroConMasAlbumes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
