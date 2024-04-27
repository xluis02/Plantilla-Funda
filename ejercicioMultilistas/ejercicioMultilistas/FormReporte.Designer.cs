
namespace ejercicioMultilistas
{
    partial class FormReporte
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
            this.dgAlumnos = new System.Windows.Forms.DataGridView();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.btnAlumnosConMenosCursos = new System.Windows.Forms.Button();
            this.btnAlumnoConNotasAltas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscarCursoPorAlumno = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Location = new System.Drawing.Point(433, 12);
            this.dgAlumnos.Name = "dgAlumnos";
            this.dgAlumnos.RowHeadersWidth = 51;
            this.dgAlumnos.RowTemplate.Height = 24;
            this.dgAlumnos.Size = new System.Drawing.Size(518, 232);
            this.dgAlumnos.TabIndex = 7;
            // 
            // dgCursos
            // 
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(433, 259);
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.RowHeadersWidth = 51;
            this.dgCursos.RowTemplate.Height = 24;
            this.dgCursos.Size = new System.Drawing.Size(518, 224);
            this.dgCursos.TabIndex = 14;
            // 
            // btnAlumnosConMenosCursos
            // 
            this.btnAlumnosConMenosCursos.Location = new System.Drawing.Point(93, 36);
            this.btnAlumnosConMenosCursos.Name = "btnAlumnosConMenosCursos";
            this.btnAlumnosConMenosCursos.Size = new System.Drawing.Size(210, 43);
            this.btnAlumnosConMenosCursos.TabIndex = 15;
            this.btnAlumnosConMenosCursos.Text = "Mostrar alumnos con menos cursos";
            this.btnAlumnosConMenosCursos.UseVisualStyleBackColor = true;
            this.btnAlumnosConMenosCursos.Click += new System.EventHandler(this.btnAlumnosConMenosCursos_Click);
            // 
            // btnAlumnoConNotasAltas
            // 
            this.btnAlumnoConNotasAltas.Location = new System.Drawing.Point(93, 95);
            this.btnAlumnoConNotasAltas.Name = "btnAlumnoConNotasAltas";
            this.btnAlumnoConNotasAltas.Size = new System.Drawing.Size(210, 46);
            this.btnAlumnoConNotasAltas.TabIndex = 16;
            this.btnAlumnoConNotasAltas.Text = "Mostrar alumnos con notas mas altas";
            this.btnAlumnoConNotasAltas.UseVisualStyleBackColor = true;
            this.btnAlumnoConNotasAltas.Click += new System.EventHandler(this.btnAlumnoConNotasAltas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar Cursos por alumno:";
            // 
            // tbAlumno
            // 
            this.tbAlumno.Location = new System.Drawing.Point(43, 328);
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.Size = new System.Drawing.Size(234, 22);
            this.tbAlumno.TabIndex = 18;
            // 
            // btnBuscarCursoPorAlumno
            // 
            this.btnBuscarCursoPorAlumno.Location = new System.Drawing.Point(283, 326);
            this.btnBuscarCursoPorAlumno.Name = "btnBuscarCursoPorAlumno";
            this.btnBuscarCursoPorAlumno.Size = new System.Drawing.Size(85, 27);
            this.btnBuscarCursoPorAlumno.TabIndex = 19;
            this.btnBuscarCursoPorAlumno.Text = "Buscar";
            this.btnBuscarCursoPorAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarCursoPorAlumno.Click += new System.EventHandler(this.btnBuscarCursoPorAlumno_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(43, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 33);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 505);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarCursoPorAlumno);
            this.Controls.Add(this.tbAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlumnoConNotasAltas);
            this.Controls.Add(this.btnAlumnosConMenosCursos);
            this.Controls.Add(this.dgCursos);
            this.Controls.Add(this.dgAlumnos);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlumnos;
        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.Button btnAlumnosConMenosCursos;
        private System.Windows.Forms.Button btnAlumnoConNotasAltas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.Button btnBuscarCursoPorAlumno;
        private System.Windows.Forms.Button btnSalir;
    }
}