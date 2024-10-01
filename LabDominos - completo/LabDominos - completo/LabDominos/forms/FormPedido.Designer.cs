namespace LabDominos
{
    partial class FormPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPedido = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDNICliente = new System.Windows.Forms.TextBox();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNombreSede = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 46);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Código:";
            // 
            // tbCodigoPedido
            // 
            this.tbCodigoPedido.Location = new System.Drawing.Point(80, 107);
            this.tbCodigoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoPedido.Name = "tbCodigoPedido";
            this.tbCodigoPedido.Size = new System.Drawing.Size(200, 20);
            this.tbCodigoPedido.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(385, 198);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 28);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha:";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(80, 182);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(2);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(200, 20);
            this.tbMonto.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "DNI Cliente:";
            // 
            // tbDNICliente
            // 
            this.tbDNICliente.Location = new System.Drawing.Point(80, 131);
            this.tbDNICliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbDNICliente.Name = "tbDNICliente";
            this.tbDNICliente.Size = new System.Drawing.Size(200, 20);
            this.tbDNICliente.TabIndex = 16;
            // 
            // dgPedidos
            // 
            this.dgPedidos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgPedidos.Location = new System.Drawing.Point(11, 255);
            this.dgPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.RowHeadersWidth = 51;
            this.dgPedidos.RowTemplate.Height = 24;
            this.dgPedidos.Size = new System.Drawing.Size(458, 264);
            this.dgPedidos.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(80, 157);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 24;
            // 
            // lblNombreSede
            // 
            this.lblNombreSede.AutoSize = true;
            this.lblNombreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSede.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreSede.Location = new System.Drawing.Point(9, 60);
            this.lblNombreSede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreSede.Name = "lblNombreSede";
            this.lblNombreSede.Size = new System.Drawing.Size(217, 26);
            this.lblNombreSede.TabIndex = 4;
            this.lblNombreSede.Text = "Nombre de la Sede";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Detalle:";
            // 
            // tbDetalle
            // 
            this.tbDetalle.Location = new System.Drawing.Point(80, 206);
            this.tbDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(200, 20);
            this.tbDetalle.TabIndex = 25;
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 529);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDetalle);
            this.Controls.Add(this.lblNombreSede);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCodigoPedido);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDNICliente);
            this.Controls.Add(this.dgPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPedido";
            this.Text = "Domino\'s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPedido;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDNICliente;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNombreSede;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDetalle;
    }
}

