﻿namespace CineFront.Presentacion.Formularios
{
    partial class FrmConsultarPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarPeliculas));
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            grpFiltros = new GroupBox();
            label3 = new Label();
            cboIdioma = new ComboBox();
            cboPublico = new ComboBox();
            label2 = new Label();
            cboGenero = new ComboBox();
            label1 = new Label();
            btnConsultar = new Button();
            dgvPeliculasFiltradas = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNomPelicula = new DataGridViewTextBoxColumn();
            ColTipoPelicula = new DataGridViewTextBoxColumn();
            ColDialecto = new DataGridViewTextBoxColumn();
            ColTipoPublico = new DataGridViewTextBoxColumn();
            ColSubtitulo = new DataGridViewTextBoxColumn();
            ColDirector = new DataGridViewTextBoxColumn();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculasFiltradas).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(60, 482);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(136, 35);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(227, 482);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 35);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(674, 482);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 35);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // grpFiltros
            // 
            grpFiltros.BackColor = Color.Transparent;
            grpFiltros.Controls.Add(label3);
            grpFiltros.Controls.Add(cboIdioma);
            grpFiltros.Controls.Add(cboPublico);
            grpFiltros.Controls.Add(label2);
            grpFiltros.Controls.Add(cboGenero);
            grpFiltros.Controls.Add(label1);
            grpFiltros.Controls.Add(btnConsultar);
            grpFiltros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpFiltros.ForeColor = Color.White;
            grpFiltros.Location = new Point(60, 40);
            grpFiltros.Margin = new Padding(4, 3, 4, 3);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Padding = new Padding(4, 3, 4, 3);
            grpFiltros.Size = new Size(750, 122);
            grpFiltros.TabIndex = 12;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 30);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 21;
            label3.Text = "Idioma: ";
            // 
            // cboIdioma
            // 
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(473, 27);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(121, 29);
            cboIdioma.TabIndex = 3;
            // 
            // cboPublico
            // 
            cboPublico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPublico.FormattingEnabled = true;
            cboPublico.Location = new Point(276, 27);
            cboPublico.Name = "cboPublico";
            cboPublico.Size = new Size(121, 29);
            cboPublico.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 17;
            label2.Text = "Publico: ";
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(81, 27);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 29);
            cboGenero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 17;
            label1.Text = "Genero: ";
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.ActiveCaptionText;
            btnConsultar.Location = new Point(607, 72);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 35);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvPeliculasFiltradas
            // 
            dgvPeliculasFiltradas.AllowUserToAddRows = false;
            dgvPeliculasFiltradas.AllowUserToDeleteRows = false;
            dgvPeliculasFiltradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeliculasFiltradas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPeliculasFiltradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculasFiltradas.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNomPelicula, ColTipoPelicula, ColDialecto, ColTipoPublico, ColSubtitulo, ColDirector });
            dgvPeliculasFiltradas.Location = new Point(60, 182);
            dgvPeliculasFiltradas.Name = "dgvPeliculasFiltradas";
            dgvPeliculasFiltradas.ReadOnly = true;
            dgvPeliculasFiltradas.RowTemplate.Height = 25;
            dgvPeliculasFiltradas.Size = new Size(750, 275);
            dgvPeliculasFiltradas.TabIndex = 4;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id Pelicula";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColNomPelicula
            // 
            ColNomPelicula.HeaderText = "Pelicula";
            ColNomPelicula.Name = "ColNomPelicula";
            ColNomPelicula.ReadOnly = true;
            // 
            // ColTipoPelicula
            // 
            ColTipoPelicula.HeaderText = "Genero";
            ColTipoPelicula.Name = "ColTipoPelicula";
            ColTipoPelicula.ReadOnly = true;
            // 
            // ColDialecto
            // 
            ColDialecto.HeaderText = "Idioma";
            ColDialecto.Name = "ColDialecto";
            ColDialecto.ReadOnly = true;
            // 
            // ColTipoPublico
            // 
            ColTipoPublico.HeaderText = "TipoPublico";
            ColTipoPublico.Name = "ColTipoPublico";
            ColTipoPublico.ReadOnly = true;
            // 
            // ColSubtitulo
            // 
            ColSubtitulo.HeaderText = "Subtitulada";
            ColSubtitulo.Name = "ColSubtitulo";
            ColSubtitulo.ReadOnly = true;
            // 
            // ColDirector
            // 
            ColDirector.HeaderText = "Director";
            ColDirector.Name = "ColDirector";
            ColDirector.ReadOnly = true;
            // 
            // FrmConsultarPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 565);
            Controls.Add(dgvPeliculasFiltradas);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(grpFiltros);
            MaximumSize = new Size(887, 604);
            MinimumSize = new Size(887, 604);
            Name = "FrmConsultarPeliculas";
            Text = "Consulta de Peliculas";
            Load += FrmConsultarPeliculas_Load;
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculasFiltradas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private GroupBox grpFiltros;
        private Button btnConsultar;
        private DataGridView dgvPeliculasFiltradas;
        private Label label3;
        private ComboBox cboIdioma;
        private ComboBox cboPublico;
        private Label label2;
        private ComboBox cboGenero;
        private Label label1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNomPelicula;
        private DataGridViewTextBoxColumn ColTipoPelicula;
        private DataGridViewTextBoxColumn ColDialecto;
        private DataGridViewTextBoxColumn ColTipoPublico;
        private DataGridViewTextBoxColumn ColSubtitulo;
        private DataGridViewTextBoxColumn ColDirector;
    }
}