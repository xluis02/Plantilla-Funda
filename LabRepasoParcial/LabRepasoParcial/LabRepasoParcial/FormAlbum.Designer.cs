
namespace LabRepasoParcial
{
    partial class FormAlbum
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbInterprete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerCanciones = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.cbValoracion = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(84, 15);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(130, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(84, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(130, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(84, 67);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(130, 20);
            this.tbAño.TabIndex = 4;
            // 
            // tbInterprete
            // 
            this.tbInterprete.Location = new System.Drawing.Point(321, 15);
            this.tbInterprete.Name = "tbInterprete";
            this.tbInterprete.Size = new System.Drawing.Size(130, 20);
            this.tbInterprete.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Intérprete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valoración:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Género:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(34, 121);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(99, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerCanciones
            // 
            this.btnVerCanciones.Location = new System.Drawing.Point(139, 121);
            this.btnVerCanciones.Name = "btnVerCanciones";
            this.btnVerCanciones.Size = new System.Drawing.Size(99, 23);
            this.btnVerCanciones.TabIndex = 13;
            this.btnVerCanciones.Text = "Ver Canciones";
            this.btnVerCanciones.UseVisualStyleBackColor = true;
            this.btnVerCanciones.Click += new System.EventHandler(this.btnVerCanciones_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(244, 121);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(99, 23);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 121);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(34, 166);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.Size = new System.Drawing.Size(417, 212);
            this.dgAlbumes.TabIndex = 16;
            // 
            // cbValoracion
            // 
            this.cbValoracion.FormattingEnabled = true;
            this.cbValoracion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbValoracion.Location = new System.Drawing.Point(321, 45);
            this.cbValoracion.Name = "cbValoracion";
            this.cbValoracion.Size = new System.Drawing.Size(130, 21);
            this.cbValoracion.TabIndex = 17;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Urbano",
            "Balada",
            "Trap",
            "Salsa"});
            this.cbGenero.Location = new System.Drawing.Point(321, 75);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(130, 21);
            this.cbGenero.TabIndex = 18;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 401);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbValoracion);
            this.Controls.Add(this.dgAlbumes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnVerCanciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInterprete);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.Name = "FormAlbum";
            this.Text = "Álbumes";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbInterprete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerCanciones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.ComboBox cbValoracion;
        private System.Windows.Forms.ComboBox cbGenero;
    }
}