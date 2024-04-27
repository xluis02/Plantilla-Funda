using EjercicioLIstas.entities;
using EjercicioLIstas.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioLIstas
{
    public partial class Form1 : Form
    {
        private AlumnoService alumnoService = new AlumnoService();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumnosEnDataGrid(List<Alumno> alumnos)
        {
            dgAlumnos.DataSource = null;

            if(alumnos.Count == 0)
            {
                return;
            }
            else
            {
                dgAlumnos.DataSource = alumnos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validacion
            if(tbCodigo.Text == "" || tbNombre.Text == "" || tbCurso.Text == "" || tbNota.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creamos el objeto
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Curso = tbCurso.Text,
                Nota = int.Parse(tbNota.Text)
            };

            // Registramos
            bool registrado = alumnoService.Registrar(alumno);

            if (!registrado)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Mostramos
            MostrarAlumnosEnDataGrid(alumnoService.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminamos
            alumnoService.Eliminar(codigo);

            // Mostramos
            MostrarAlumnosEnDataGrid(alumnoService.ListarTodo());
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            // Eliminamos
            alumnoService.EliminarTodo();

            // Mostramos
            MostrarAlumnosEnDataGrid(alumnoService.ListarTodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenamos y mostramos
            MostrarAlumnosEnDataGrid(alumnoService.OrdenarPorPrecio());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Mostramos
            MostrarAlumnosEnDataGrid(alumnoService.ListarTodo());

            tbCodigo.Text = "";
            tbCurso.Text = "";
            tbNombre.Text = "";
            tbNota.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese nombre a buscar");
                return;
            }

            String nombre = tbBuscar.Text;

            //Buscamos y mostramos
            MostrarAlumnosEnDataGrid(alumnoService.BuscarPorNombre(nombre));
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbBuscarCodigo.Text == "")
            {
                MessageBox.Show("Ingrese nombre a buscar");
                return;
            }

            String codigo = tbBuscarCodigo.Text;

            //Buscamos y mostramos
            MostrarAlumnosEnDataGrid(alumnoService.BuscarPorCodigo(codigo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
