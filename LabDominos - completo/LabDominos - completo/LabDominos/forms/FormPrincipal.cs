using System;
using System.Windows.Forms;

namespace LabDominos.forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerSedes_Click(object sender, EventArgs e)
        {
            FormSede form = new FormSede();
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
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