namespace LabDominos.forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnListarPedidosEnRangoDeFechas = new System.Windows.Forms.Button();
            this.btnListarMontoPorDistrito = new System.Windows.Forms.Button();
            this.dgReportesMonto = new System.Windows.Forms.DataGridView();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoSede = new System.Windows.Forms.TextBox();
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite = new System.Windows.Forms.Button();
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo = new System.Windows.Forms.Button();
            this.tbDNICliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMontoMaximo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportesMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(857, 9);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 46);
            this.panel1.TabIndex = 14;
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
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reportes";
            // 
            // dgPedidos
            // 
            this.dgPedidos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgPedidos.Location = new System.Drawing.Point(18, 195);
            this.dgPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.RowHeadersWidth = 51;
            this.dgPedidos.RowTemplate.Height = 24;
            this.dgPedidos.Size = new System.Drawing.Size(270, 207);
            this.dgPedidos.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(88, 73);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 20;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(88, 99);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 21;
            // 
            // btnListarPedidosEnRangoDeFechas
            // 
            this.btnListarPedidosEnRangoDeFechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarPedidosEnRangoDeFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPedidosEnRangoDeFechas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListarPedidosEnRangoDeFechas.Location = new System.Drawing.Point(18, 136);
            this.btnListarPedidosEnRangoDeFechas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPedidosEnRangoDeFechas.Name = "btnListarPedidosEnRangoDeFechas";
            this.btnListarPedidosEnRangoDeFechas.Size = new System.Drawing.Size(270, 28);
            this.btnListarPedidosEnRangoDeFechas.TabIndex = 22;
            this.btnListarPedidosEnRangoDeFechas.Text = "Listar Pedidos en Rango de Fechas";
            this.btnListarPedidosEnRangoDeFechas.UseVisualStyleBackColor = false;
            this.btnListarPedidosEnRangoDeFechas.Click += new System.EventHandler(this.btnListarPedidosEnRangoDeFechas_Click);
            // 
            // btnListarMontoPorDistrito
            // 
            this.btnListarMontoPorDistrito.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarMontoPorDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMontoPorDistrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListarMontoPorDistrito.Location = new System.Drawing.Point(344, 136);
            this.btnListarMontoPorDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarMontoPorDistrito.Name = "btnListarMontoPorDistrito";
            this.btnListarMontoPorDistrito.Size = new System.Drawing.Size(271, 28);
            this.btnListarMontoPorDistrito.TabIndex = 23;
            this.btnListarMontoPorDistrito.Text = "Listar Monto por Distrito";
            this.btnListarMontoPorDistrito.UseVisualStyleBackColor = false;
            this.btnListarMontoPorDistrito.Click += new System.EventHandler(this.btnListarMontoPorDistrito_Click);
            // 
            // dgReportesMonto
            // 
            this.dgReportesMonto.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgReportesMonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportesMonto.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgReportesMonto.Location = new System.Drawing.Point(345, 195);
            this.dgReportesMonto.Margin = new System.Windows.Forms.Padding(2);
            this.dgReportesMonto.Name = "dgReportesMonto";
            this.dgReportesMonto.RowHeadersWidth = 51;
            this.dgReportesMonto.RowTemplate.Height = 24;
            this.dgReportesMonto.Size = new System.Drawing.Size(270, 207);
            this.dgReportesMonto.TabIndex = 24;
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaLimite.Location = new System.Drawing.Point(734, 94);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(198, 20);
            this.dtpFechaLimite.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha límite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Código sede:";
            // 
            // tbCodigoSede
            // 
            this.tbCodigoSede.Location = new System.Drawing.Point(734, 68);
            this.tbCodigoSede.Name = "tbCodigoSede";
            this.tbCodigoSede.Size = new System.Drawing.Size(198, 20);
            this.tbCodigoSede.TabIndex = 28;
            // 
            // btnObtenerMontoPedidosPorCodigoSedeYFechaLimite
            // 
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Location = new System.Drawing.Point(663, 136);
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Margin = new System.Windows.Forms.Padding(2);
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Name = "btnObtenerMontoPedidosPorCodigoSedeYFechaLimite";
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Size = new System.Drawing.Size(270, 52);
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.TabIndex = 29;
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Text = "Obtener Monto de Pedidos Por Código de Sede y Fecha Límite";
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.UseVisualStyleBackColor = false;
            this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite.Click += new System.EventHandler(this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite_Click);
            // 
            // btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo
            // 
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Location = new System.Drawing.Point(663, 326);
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Margin = new System.Windows.Forms.Padding(2);
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Name = "btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo";
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Size = new System.Drawing.Size(270, 52);
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.TabIndex = 34;
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Text = "Obtener Cantidad de Pedidos por DNI Cliente y Monto Máximo";
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.UseVisualStyleBackColor = false;
            this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo.Click += new System.EventHandler(this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo_Click);
            // 
            // tbDNICliente
            // 
            this.tbDNICliente.Location = new System.Drawing.Point(735, 258);
            this.tbDNICliente.Name = "tbDNICliente";
            this.tbDNICliente.Size = new System.Drawing.Size(198, 20);
            this.tbDNICliente.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "DNI Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Monto máximo:";
            // 
            // tbMontoMaximo
            // 
            this.tbMontoMaximo.Location = new System.Drawing.Point(735, 284);
            this.tbMontoMaximo.Name = "tbMontoMaximo";
            this.tbMontoMaximo.Size = new System.Drawing.Size(198, 20);
            this.tbMontoMaximo.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Monto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(735, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cantidad:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(817, 195);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(16, 17);
            this.lblMonto.TabIndex = 38;
            this.lblMonto.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(818, 385);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(16, 17);
            this.lblCantidad.TabIndex = 39;
            this.lblCantidad.Text = "0";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 418);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMontoMaximo);
            this.Controls.Add(this.btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo);
            this.Controls.Add(this.tbDNICliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnObtenerMontoPedidosPorCodigoSedeYFechaLimite);
            this.Controls.Add(this.tbCodigoSede);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReportesMonto);
            this.Controls.Add(this.btnListarMontoPorDistrito);
            this.Controls.Add(this.btnListarPedidosEnRangoDeFechas);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporte";
            this.Text = "Domino\'s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportesMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnListarPedidosEnRangoDeFechas;
        private System.Windows.Forms.Button btnListarMontoPorDistrito;
        private System.Windows.Forms.DataGridView dgReportesMonto;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoSede;
        private System.Windows.Forms.Button btnObtenerMontoPedidosPorCodigoSedeYFechaLimite;
        private System.Windows.Forms.Button btnObtenerCantidadPedidosPorDNIClienteYMontoMaximo;
        private System.Windows.Forms.TextBox tbDNICliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMontoMaximo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCantidad;
    }
}