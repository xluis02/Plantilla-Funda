
namespace ejercicioMultilistas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerAlumnos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.Location = new System.Drawing.Point(64, 45);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(100, 36);
            this.btnVerAlumnos.TabIndex = 0;
            this.btnVerAlumnos.Text = "Ver Alumnos";
            this.btnVerAlumnos.UseVisualStyleBackColor = true;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(64, 100);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 189);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerAlumnos);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerAlumnos;
        private System.Windows.Forms.Button btnSalir;
    }
}