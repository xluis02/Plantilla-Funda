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
    public partial class FormReporte : Form
    {
        private AlumnoService alumnoService = new AlumnoService();
        private CursoService cursoService = new CursoService();
        public FormReporte()
        {
            InitializeComponent();
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

        private void MostrarCursos(List<Curso> cursos)
        {
            dgCursos.DataSource = null;
            if (cursos.Count == 0)
            {
                return;
            }
            else
            {
                dgCursos.DataSource = cursos;
            }
        }
        private void btnAlumnosConMenosCursos_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoService.ListarAlumnoConMenosCursos());
        }

        private void btnAlumnoConNotasAltas_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoService.ListarAlumnosConNotasMasAltasPorCurso());
        }

        private void btnBuscarCursoPorAlumno_Click(object sender, EventArgs e)
        {
            // Validacion
            if(tbAlumno.Text == "")
            {
                MessageBox.Show("Ingrese alumno: ");
                return;
            }

            String alumno = tbAlumno.Text;
            MostrarCursos(cursoService.ListarCursosPorAlumno(alumno));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
