namespace CineFront.Presentacion.Formularios
{
    partial class FrmAltaComprobante
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
            txtProximoComprobante = new Label();
            btnAceptar = new Button();
            cboEmpleado = new ComboBox();
            cboFormasP = new ComboBox();
            label2 = new Label();
            cboClientes = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            label7 = new Label();
            dgvTickets = new DataGridView();
            ColFila = new DataGridViewTextBoxColumn();
            ColColumna = new DataGridViewTextBoxColumn();
            ColPreUnitario = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColFechaHora = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            label6 = new Label();
            txtPreUnitario = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtFila = new TextBox();
            txtColumna = new TextBox();
            label10 = new Label();
            cboPeliculas = new ComboBox();
            label11 = new Label();
            btnAgregar = new Button();
            cboFechaHora = new ComboBox();
            cantEntradas = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantEntradas).BeginInit();
            SuspendLayout();
            // 
            // txtProximoComprobante
            // 
            txtProximoComprobante.AutoSize = true;
            txtProximoComprobante.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtProximoComprobante.ForeColor = SystemColors.ControlText;
            txtProximoComprobante.Location = new Point(12, 28);
            txtProximoComprobante.Name = "txtProximoComprobante";
            txtProximoComprobante.Size = new Size(264, 30);
            txtProximoComprobante.TabIndex = 29;
            txtProximoComprobante.Text = "Nuevo Comprobante N°: ";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LightSalmon;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(11, 492);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 26);
            btnAceptar.TabIndex = 25;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(537, 99);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(121, 23);
            cboEmpleado.TabIndex = 19;
            // 
            // cboFormasP
            // 
            cboFormasP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormasP.FormattingEnabled = true;
            cboFormasP.Location = new Point(320, 99);
            cboFormasP.Name = "cboFormasP";
            cboFormasP.Size = new Size(121, 23);
            cboFormasP.TabIndex = 17;
            cboFormasP.SelectedIndexChanged += cboFormasP_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 30;
            label2.Text = "Cliente:";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(68, 98);
            cboClientes.Margin = new Padding(3, 2, 3, 2);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(121, 23);
            cboClientes.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 101);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 32;
            label3.Text = "Forma de pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 102);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 33;
            label4.Text = "Empleado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(676, 102);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 34;
            label5.Text = "Cantidad de entradas:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSalmon;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(150, 492);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 26);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(12, 153);
            label7.Name = "label7";
            label7.Size = new Size(82, 30);
            label7.TabIndex = 38;
            label7.Text = "Tickets";
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { ColFila, ColColumna, ColPreUnitario, ColPelicula, ColFechaHora, ColQuitar });
            dgvTickets.Location = new Point(11, 327);
            dgvTickets.Margin = new Padding(3, 2, 3, 2);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.RowTemplate.Height = 29;
            dgvTickets.Size = new Size(842, 141);
            dgvTickets.TabIndex = 39;
            dgvTickets.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColFila
            // 
            ColFila.HeaderText = "Fila";
            ColFila.MinimumWidth = 6;
            ColFila.Name = "ColFila";
            ColFila.ReadOnly = true;
            // 
            // ColColumna
            // 
            ColColumna.HeaderText = "Columna";
            ColColumna.MinimumWidth = 6;
            ColColumna.Name = "ColColumna";
            ColColumna.ReadOnly = true;
            // 
            // ColPreUnitario
            // 
            ColPreUnitario.HeaderText = "Precio";
            ColPreUnitario.MinimumWidth = 6;
            ColPreUnitario.Name = "ColPreUnitario";
            ColPreUnitario.ReadOnly = true;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Película";
            ColPelicula.MinimumWidth = 6;
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            // 
            // ColFechaHora
            // 
            ColFechaHora.HeaderText = "Horario";
            ColFechaHora.MinimumWidth = 6;
            ColFechaHora.Name = "ColFechaHora";
            ColFechaHora.ReadOnly = true;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "Acciones";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 204);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 40;
            label6.Text = "Precio Unitario:";
            // 
            // txtPreUnitario
            // 
            txtPreUnitario.Location = new Point(154, 201);
            txtPreUnitario.Margin = new Padding(3, 2, 3, 2);
            txtPreUnitario.Name = "txtPreUnitario";
            txtPreUnitario.Size = new Size(76, 23);
            txtPreUnitario.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(245, 204);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 42;
            label8.Text = "Fila:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(340, 204);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 43;
            label9.Text = "Columna:";
            // 
            // txtFila
            // 
            txtFila.Location = new Point(281, 201);
            txtFila.Margin = new Padding(3, 2, 3, 2);
            txtFila.Name = "txtFila";
            txtFila.Size = new Size(34, 23);
            txtFila.TabIndex = 44;
            // 
            // txtColumna
            // 
            txtColumna.Location = new Point(407, 201);
            txtColumna.Margin = new Padding(3, 2, 3, 2);
            txtColumna.Name = "txtColumna";
            txtColumna.Size = new Size(34, 23);
            txtColumna.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(461, 203);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 47;
            label10.Text = "Pelicula:";
            // 
            // cboPeliculas
            // 
            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeliculas.FormattingEnabled = true;
            cboPeliculas.Location = new Point(520, 201);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(121, 23);
            cboPeliculas.TabIndex = 46;
            cboPeliculas.SelectedIndexChanged += cboPeliculas_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(659, 204);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 48;
            label11.Text = "Funcion:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightSalmon;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(743, 276);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 28);
            btnAgregar.TabIndex = 52;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboFechaHora
            // 
            cboFechaHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFechaHora.FormattingEnabled = true;
            cboFechaHora.Location = new Point(716, 200);
            cboFechaHora.Name = "cboFechaHora";
            cboFechaHora.Size = new Size(121, 23);
            cboFechaHora.TabIndex = 53;
            // 
            // cantEntradas
            // 
            cantEntradas.Location = new Point(804, 100);
            cantEntradas.Name = "cantEntradas";
            cantEntradas.Size = new Size(50, 23);
            cantEntradas.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(716, 180);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 56;
            label13.Text = "Fecha";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(783, 180);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 57;
            label14.Text = "Hora";
            // 
            // FrmAltaComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 565);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(cantEntradas);
            Controls.Add(cboFechaHora);
            Controls.Add(btnAgregar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboPeliculas);
            Controls.Add(txtColumna);
            Controls.Add(txtFila);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPreUnitario);
            Controls.Add(label6);
            Controls.Add(dgvTickets);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboClientes);
            Controls.Add(label2);
            Controls.Add(txtProximoComprobante);
            Controls.Add(btnAceptar);
            Controls.Add(cboEmpleado);
            Controls.Add(cboFormasP);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(887, 604);
            MinimumSize = new Size(887, 604);
            Name = "FrmAltaComprobante";
            Text = "Alta Comprobante";
            Load += FrmAltaComprobante_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantEntradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtProximoComprobante;
        private Button btnAceptar;
        private ComboBox cboEmpleado;
        private ComboBox cboFormasP;
        private Label label2;
        private ComboBox cboClientes;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCancelar;
        private Label label7;
        private DataGridView dgvTickets;
        private Label label6;
        private TextBox txtPreUnitario;
        private Label label8;
        private Label label9;
        private TextBox txtFila;
        private TextBox txtColumna;
        private Label label10;
        private ComboBox cboPeliculas;
        private Label label11;
        private Button btnAgregar;
        private ComboBox cboFechaHora;
        private NumericUpDown cantEntradas;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn ColFila;
        private DataGridViewTextBoxColumn ColColumna;
        private DataGridViewTextBoxColumn ColPreUnitario;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColFechaHora;
        private DataGridViewButtonColumn ColQuitar;
    }
}