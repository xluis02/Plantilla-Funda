
namespace LabRepasoParcial
{
    partial class Reporte
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
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.dgCanciones = new System.Windows.Forms.DataGridView();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            this.btnAlbumesConCancionesConMenorDuracion = new System.Windows.Forms.Button();
            this.btnListarAlbumesConMasCanciones = new System.Windows.Forms.Button();
            this.btnListarAlbumesPorCantidadDeSencillos = new System.Windows.Forms.Button();
            this.tbCantidadSencillos = new System.Windows.Forms.TextBox();
            this.tbInterprete = new System.Windows.Forms.TextBox();
            this.btnListarCancionesPorInterpreteAlbum = new System.Windows.Forms.Button();
            this.btnListarCancionesMasLargas = new System.Windows.Forms.Button();
            this.btnListarGeneroConMasAlbumes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(33, 240);
            this.dgAlbumes.Margin = new System.Windows.Forms.Padding(4);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.RowHeadersWidth = 51;
            this.dgAlbumes.Size = new System.Drawing.Size(441, 267);
            this.dgAlbumes.TabIndex = 11;
            // 
            // dgCanciones
            // 
            this.dgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCanciones.Location = new System.Drawing.Point(501, 240);
            this.dgCanciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgCanciones.Name = "dgCanciones";
            this.dgCanciones.RowHeadersWidth = 51;
            this.dgCanciones.Size = new System.Drawing.Size(441, 267);
            this.dgCanciones.TabIndex = 12;
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(965, 240);
            this.dgReportes.Margin = new System.Windows.Forms.Padding(4);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowHeadersWidth = 51;
            this.dgReportes.Size = new System.Drawing.Size(441, 267);
            this.dgReportes.TabIndex = 13;
            // 
            // btnAlbumesConCancionesConMenorDuracion
            // 
            this.btnAlbumesConCancionesConMenorDuracion.Location = new System.Drawing.Point(74, 29);
            this.btnAlbumesConCancionesConMenorDuracion.Name = "btnAlbumesConCancionesConMenorDuracion";
            this.btnAlbumesConCancionesConMenorDuracion.Size = new System.Drawing.Size(359, 34);
            this.btnAlbumesConCancionesConMenorDuracion.TabIndex = 14;
            this.btnAlbumesConCancionesConMenorDuracion.Text = "Listar Albumes Con Canciones Con Menor Duracion";
            this.btnAlbumesConCancionesConMenorDuracion.UseVisualStyleBackColor = true;
            this.btnAlbumesConCancionesConMenorDuracion.Click += new System.EventHandler(this.btnAlbumesConCancionesConMenorDuracion_Click);
            // 
            // btnListarAlbumesConMasCanciones
            // 
            this.btnListarAlbumesConMasCanciones.Location = new System.Drawing.Point(74, 69);
            this.btnListarAlbumesConMasCanciones.Name = "btnListarAlbumesConMasCanciones";
            this.btnListarAlbumesConMasCanciones.Size = new System.Drawing.Size(359, 30);
            this.btnListarAlbumesConMasCanciones.TabIndex = 15;
            this.btnListarAlbumesConMasCanciones.Text = "Listar Albumes Con Mas Canciones";
            this.btnListarAlbumesConMasCanciones.UseVisualStyleBackColor = true;
            this.btnListarAlbumesConMasCanciones.Click += new System.EventHandler(this.btnListarAlbumesConMasCanciones_Click);
            // 
            // btnListarAlbumesPorCantidadDeSencillos
            // 
            this.btnListarAlbumesPorCantidadDeSencillos.Location = new System.Drawing.Point(74, 151);
            this.btnListarAlbumesPorCantidadDeSencillos.Name = "btnListarAlbumesPorCantidadDeSencillos";
            this.btnListarAlbumesPorCantidadDeSencillos.Size = new System.Drawing.Size(359, 31);
            this.btnListarAlbumesPorCantidadDeSencillos.TabIndex = 16;
            this.btnListarAlbumesPorCantidadDeSencillos.Text = "Listar Albumes Por Cantidad De Sencillos";
            this.btnListarAlbumesPorCantidadDeSencillos.UseVisualStyleBackColor = true;
            this.btnListarAlbumesPorCantidadDeSencillos.Click += new System.EventHandler(this.btnListarAlbumesPorCantidadDeSencillos_Click);
            // 
            // tbCantidadSencillos
            // 
            this.tbCantidadSencillos.Location = new System.Drawing.Point(150, 114);
            this.tbCantidadSencillos.Name = "tbCantidadSencillos";
            this.tbCantidadSencillos.Size = new System.Drawing.Size(199, 22);
            this.tbCantidadSencillos.TabIndex = 17;
            // 
            // tbInterprete
            // 
            this.tbInterprete.Location = new System.Drawing.Point(611, 52);
            this.tbInterprete.Name = "tbInterprete";
            this.tbInterprete.Size = new System.Drawing.Size(206, 22);
            this.tbInterprete.TabIndex = 18;
            // 
            // btnListarCancionesPorInterpreteAlbum
            // 
            this.btnListarCancionesPorInterpreteAlbum.Location = new System.Drawing.Point(542, 95);
            this.btnListarCancionesPorInterpreteAlbum.Name = "btnListarCancionesPorInterpreteAlbum";
            this.btnListarCancionesPorInterpreteAlbum.Size = new System.Drawing.Size(351, 31);
            this.btnListarCancionesPorInterpreteAlbum.TabIndex = 19;
            this.btnListarCancionesPorInterpreteAlbum.Text = "Listar Canciones Por Interprete Del Album";
            this.btnListarCancionesPorInterpreteAlbum.UseVisualStyleBackColor = true;
            this.btnListarCancionesPorInterpreteAlbum.Click += new System.EventHandler(this.btnListarCancionesPorInterpreteAlbum_Click);
            // 
            // btnListarCancionesMasLargas
            // 
            this.btnListarCancionesMasLargas.Location = new System.Drawing.Point(542, 151);
            this.btnListarCancionesMasLargas.Name = "btnListarCancionesMasLargas";
            this.btnListarCancionesMasLargas.Size = new System.Drawing.Size(351, 31);
            this.btnListarCancionesMasLargas.TabIndex = 20;
            this.btnListarCancionesMasLargas.Text = "Listar Canciones Mas Largas";
            this.btnListarCancionesMasLargas.UseVisualStyleBackColor = true;
            this.btnListarCancionesMasLargas.Click += new System.EventHandler(this.btnListarCancionesMasLargas_Click);
            // 
            // btnListarGeneroConMasAlbumes
            // 
            this.btnListarGeneroConMasAlbumes.Location = new System.Drawing.Point(1046, 95);
            this.btnListarGeneroConMasAlbumes.Name = "btnListarGeneroConMasAlbumes";
            this.btnListarGeneroConMasAlbumes.Size = new System.Drawing.Size(294, 31);
            this.btnListarGeneroConMasAlbumes.TabIndex = 21;
            this.btnListarGeneroConMasAlbumes.Text = "Listar Genero Con Mas Albumes";
            this.btnListarGeneroConMasAlbumes.UseVisualStyleBackColor = true;
            this.btnListarGeneroConMasAlbumes.Click += new System.EventHandler(this.btnListarGeneroConMasAlbumes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1146, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 28);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 544);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarGeneroConMasAlbumes);
            this.Controls.Add(this.btnListarCancionesMasLargas);
            this.Controls.Add(this.btnListarCancionesPorInterpreteAlbum);
            this.Controls.Add(this.tbInterprete);
            this.Controls.Add(this.tbCantidadSencillos);
            this.Controls.Add(this.btnListarAlbumesPorCantidadDeSencillos);
            this.Controls.Add(this.btnListarAlbumesConMasCanciones);
            this.Controls.Add(this.btnAlbumesConCancionesConMenorDuracion);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.dgCanciones);
            this.Controls.Add(this.dgAlbumes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.DataGridView dgCanciones;
        private System.Windows.Forms.DataGridView dgReportes;
        private System.Windows.Forms.Button btnAlbumesConCancionesConMenorDuracion;
        private System.Windows.Forms.Button btnListarAlbumesConMasCanciones;
        private System.Windows.Forms.Button btnListarAlbumesPorCantidadDeSencillos;
        private System.Windows.Forms.TextBox tbCantidadSencillos;
        private System.Windows.Forms.TextBox tbInterprete;
        private System.Windows.Forms.Button btnListarCancionesPorInterpreteAlbum;
        private System.Windows.Forms.Button btnListarCancionesMasLargas;
        private System.Windows.Forms.Button btnListarGeneroConMasAlbumes;
        private System.Windows.Forms.Button btnSalir;
    }
}