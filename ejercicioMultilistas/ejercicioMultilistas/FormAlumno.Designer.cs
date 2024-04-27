
namespace ejercicioMultilistas
{
    partial class FormAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.dgAlumnos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.btnVerRepórte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(82, 29);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(159, 22);
            this.tbCodigo.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(82, 71);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(159, 22);
            this.tbNombre.TabIndex = 4;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(82, 108);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(159, 22);
            this.tbCorreo.TabIndex = 5;
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Location = new System.Drawing.Point(270, 86);
            this.dgAlumnos.Name = "dgAlumnos";
            this.dgAlumnos.RowHeadersWidth = 51;
            this.dgAlumnos.RowTemplate.Height = 24;
            this.dgAlumnos.Size = new System.Drawing.Size(518, 280);
            this.dgAlumnos.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(25, 152);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 26);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(135, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 26);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(82, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 26);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(65, 184);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(112, 26);
            this.btnEliminarTodo.TabIndex = 10;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Buscar por nombre:";
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(292, 39);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(226, 22);
            this.tbBuscarNombre.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(533, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.Location = new System.Drawing.Point(65, 216);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(112, 26);
            this.btnVerCursos.TabIndex = 15;
            this.btnVerCursos.Text = "Ver Cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnVerRepórte
            // 
            this.btnVerRepórte.Location = new System.Drawing.Point(65, 248);
            this.btnVerRepórte.Name = "btnVerRepórte";
            this.btnVerRepórte.Size = new System.Drawing.Size(112, 26);
            this.btnVerRepórte.TabIndex = 16;
            this.btnVerRepórte.Text = "Ver Reporte";
            this.btnVerRepórte.UseVisualStyleBackColor = true;
            this.btnVerRepórte.Click += new System.EventHandler(this.btnVerRepórte_Click);
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.btnVerRepórte);
            this.Controls.Add(this.btnVerCursos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscarNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgAlumnos);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlumno";
            this.Text = "FormAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.DataGridView dgAlumnos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnVerRepórte;
    }
}