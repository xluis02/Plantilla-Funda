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
    public partial class FormCurso : Form
    {
        private String codigoAlumno;
        private CursoService cursoService = new CursoService();
        public FormCurso(String codigoAlumno)
        {
            InitializeComponent();
            this.codigoAlumno = codigoAlumno;
            // Mostramos
            MostrarCursos(cursoService.ListarTodo(codigoAlumno));
        }

        private void MostrarCursos(List<Curso> cursos)
        {
            dgCursos.DataSource = null;
            if(cursos.Count == 0)
            {
                return;
            }
            else
            {
                dgCursos.DataSource = cursos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validacion
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbCredito.Text == "" || tbNota.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creacion del objeto
            Curso curso = new Curso()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Nota = int.Parse(tbNota.Text),
                Creditos = double.Parse(tbCredito.Text)
            };

            // Registrar
            bool registrado = cursoService.Registrar(codigoAlumno, curso);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }

            // Mostramos
            MostrarCursos(cursoService.ListarTodo(codigoAlumno));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
