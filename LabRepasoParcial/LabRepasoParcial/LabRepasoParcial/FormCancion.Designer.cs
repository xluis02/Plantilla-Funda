
namespace LabRepasoParcial
{
    partial class FormCancion
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNroPista = new System.Windows.Forms.TextBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.chbEsSencillo = new System.Windows.Forms.CheckBox();
            this.dgCanciones = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. Pista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duración:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(89, 23);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(130, 20);
            this.tbCodigo.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(89, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(130, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbNroPista
            // 
            this.tbNroPista.Location = new System.Drawing.Point(89, 75);
            this.tbNroPista.Name = "tbNroPista";
            this.tbNroPista.Size = new System.Drawing.Size(130, 20);
            this.tbNroPista.TabIndex = 7;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(331, 23);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(130, 20);
            this.tbDuracion.TabIndex = 8;
            // 
            // chbEsSencillo
            // 
            this.chbEsSencillo.AutoSize = true;
            this.chbEsSencillo.Location = new System.Drawing.Point(308, 65);
            this.chbEsSencillo.Name = "chbEsSencillo";
            this.chbEsSencillo.Size = new System.Drawing.Size(78, 17);
            this.chbEsSencillo.TabIndex = 9;
            this.chbEsSencillo.Text = "Es Sencillo";
            this.chbEsSencillo.UseVisualStyleBackColor = true;
            // 
            // dgCanciones
            // 
            this.dgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCanciones.Location = new System.Drawing.Point(39, 181);
            this.dgCanciones.Name = "dgCanciones";
            this.dgCanciones.Size = new System.Drawing.Size(422, 232);
            this.dgCanciones.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(39, 125);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(145, 125);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgCanciones);
            this.Controls.Add(this.chbEsSencillo);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.tbNroPista);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCancion";
            this.Text = "Canciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNroPista;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.CheckBox chbEsSencillo;
        private System.Windows.Forms.DataGridView dgCanciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
    }
}