using ejercicioMultilistas.entities;
using ejercicioMultilistas.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioMultilistas
{
    public partial class FormAlumno : Form
    {
        private AlumnoService alumnoService = new AlumnoService();
        public FormAlumno()
        {
            InitializeComponent();
            // Mostrar
            MostrarAlumnos(alumnoService.ListarTodo());
        }

        private void MostrarAlumnos(List<Alumno> alumnos)
        {
            dgAlumnos.DataSource = null;
            if (alumnos.Count == 0)
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
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbCorreo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creacion del objeto
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Correo = tbCorreo.Text,
                //Importante
                Cursos = new List<Curso>()
            };

            // Registramos
            bool registrado = alumnoService.Registrar(alumno);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }

            // Mostrar
            MostrarAlumnos(alumnoService.ListarTodo());
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
            MostrarAlumnos(alumnoService.ListarTodo());
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            // Eliminamos
            alumnoService.EliminarTodo();

            // Mostramos
            MostrarAlumnos(alumnoService.ListarTodo());
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            String codigoAlumno = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            FormCurso form = new FormCurso(codigoAlumno);
            form.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbBuscarNombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre a buscar");
                return;
            }

            String nombre = tbBuscarNombre.Text;

            //Buscamos y mostramos
            MostrarAlumnos(alumnoService.BuscarPorNombre(nombre));
        }
        private void btnVerRepórte_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }   
}
