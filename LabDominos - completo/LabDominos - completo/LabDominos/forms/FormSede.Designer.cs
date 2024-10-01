namespace LabDominos.forms
{
    partial class FormSede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSede));
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgSedes = new System.Windows.Forms.DataGridView();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.tbCodigoSede = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(392, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 46);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sedes";
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerPedidos.Location = new System.Drawing.Point(385, 129);
            this.btnVerPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(84, 28);
            this.btnVerPedidos.TabIndex = 3;
            this.btnVerPedidos.Text = "Pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = false;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(385, 97);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 28);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgSedes
            // 
            this.dgSedes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSedes.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgSedes.Location = new System.Drawing.Point(11, 180);
            this.dgSedes.Margin = new System.Windows.Forms.Padding(2);
            this.dgSedes.Name = "dgSedes";
            this.dgSedes.RowHeadersWidth = 51;
            this.dgSedes.RowTemplate.Height = 24;
            this.dgSedes.Size = new System.Drawing.Size(458, 264);
            this.dgSedes.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(71, 86);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(177, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Distrito:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(71, 137);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(177, 20);
            this.tbDireccion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección:";
            // 
            // cbDistrito
            // 
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Items.AddRange(new object[] {
            "Barranco",
            "Cercado de Lima",
            "Chorrillos",
            "Miraflores",
            "Pueblo Libre",
            "San Isidro",
            "San Miguel",
            "Santiago de Surco"});
            this.cbDistrito.Location = new System.Drawing.Point(71, 111);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(177, 21);
            this.cbDistrito.TabIndex = 9;
            // 
            // tbCodigoSede
            // 
            this.tbCodigoSede.Location = new System.Drawing.Point(71, 62);
            this.tbCodigoSede.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoSede.Name = "tbCodigoSede";
            this.tbCodigoSede.Size = new System.Drawing.Size(177, 20);
            this.tbCodigoSede.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código:";
            // 
            // FormSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCodigoSede);
            this.Controls.Add(this.btnVerPedidos);
            this.Controls.Add(this.cbDistrito);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.dgSedes);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSede";
            this.Text = "Domino\'s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.DataGridView dgSedes;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.TextBox tbCodigoSede;
        private System.Windows.Forms.Label label5;
    }
}