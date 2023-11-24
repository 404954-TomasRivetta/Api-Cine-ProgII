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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaComprobante));
            label14 = new Label();
            label13 = new Label();
            cantEntradas = new NumericUpDown();
            cboFechaHora = new ComboBox();
            btnAgregar = new Button();
            label11 = new Label();
            label10 = new Label();
            cboPeliculas = new ComboBox();
            txtPreUnitario = new TextBox();
            label6 = new Label();
            dgvTickets = new DataGridView();
            ColIdButaca = new DataGridViewTextBoxColumn();
            ColPreUnitario = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColFechaHora = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            label7 = new Label();
            btnCancelar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboClientes = new ComboBox();
            label2 = new Label();
            txtProximoComprobante = new Label();
            btnAceptar = new Button();
            cboEmpleado = new ComboBox();
            cboFormasP = new ComboBox();
            button44 = new Button();
            button43 = new Button();
            button42 = new Button();
            button39 = new Button();
            button41 = new Button();
            button40 = new Button();
            button38 = new Button();
            button35 = new Button();
            button37 = new Button();
            button36 = new Button();
            button34 = new Button();
            button31 = new Button();
            button33 = new Button();
            button32 = new Button();
            button30 = new Button();
            button29 = new Button();
            button26 = new Button();
            button28 = new Button();
            button27 = new Button();
            button25 = new Button();
            button22 = new Button();
            button24 = new Button();
            button23 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button15 = new Button();
            button17 = new Button();
            button16 = new Button();
            button14 = new Button();
            button11 = new Button();
            button13 = new Button();
            button12 = new Button();
            button10 = new Button();
            button9 = new Button();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            ((System.ComponentModel.ISupportInitialize)cantEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(783, 98);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 138;
            label14.Text = "Hora";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(717, 100);
            label13.Name = "label13";
            label13.Size = new Size(47, 20);
            label13.TabIndex = 137;
            label13.Text = "Fecha";
            // 
            // cantEntradas
            // 
            cantEntradas.BackColor = Color.White;
            cantEntradas.Location = new Point(801, 55);
            cantEntradas.Name = "cantEntradas";
            cantEntradas.Size = new Size(50, 23);
            cantEntradas.TabIndex = 136;
            // 
            // cboFechaHora
            // 
            cboFechaHora.BackColor = Color.DarkGray;
            cboFechaHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFechaHora.FormattingEnabled = true;
            cboFechaHora.Location = new Point(714, 123);
            cboFechaHora.Name = "cboFechaHora";
            cboFechaHora.Size = new Size(121, 23);
            cboFechaHora.TabIndex = 135;
            cboFechaHora.SelectedIndexChanged += cboFechaHora_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(751, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 28);
            btnAgregar.TabIndex = 134;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(645, 126);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 133;
            label11.Text = "Funcion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(373, 126);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 132;
            label10.Text = "Pelicula:";
            // 
            // cboPeliculas
            // 
            cboPeliculas.BackColor = Color.DarkGray;
            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeliculas.FormattingEnabled = true;
            cboPeliculas.Location = new Point(460, 123);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(121, 23);
            cboPeliculas.TabIndex = 131;
            cboPeliculas.SelectedIndexChanged += cboPeliculas_SelectedIndexChanged_1;
            // 
            // txtPreUnitario
            // 
            txtPreUnitario.BackColor = Color.DarkGray;
            txtPreUnitario.Location = new Point(152, 124);
            txtPreUnitario.Margin = new Padding(3, 2, 3, 2);
            txtPreUnitario.Name = "txtPreUnitario";
            txtPreUnitario.Size = new Size(76, 23);
            txtPreUnitario.TabIndex = 130;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 126);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 129;
            label6.Text = "Precio Unitario:";
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.BackgroundColor = Color.DimGray;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { ColIdButaca, ColPreUnitario, ColPelicula, ColFechaHora, ColQuitar });
            dgvTickets.Location = new Point(20, 416);
            dgvTickets.Margin = new Padding(3, 2, 3, 2);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.RowTemplate.Height = 29;
            dgvTickets.Size = new Size(842, 114);
            dgvTickets.TabIndex = 128;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            // 
            // ColIdButaca
            // 
            ColIdButaca.HeaderText = "Column1";
            ColIdButaca.Name = "ColIdButaca";
            ColIdButaca.ReadOnly = true;
            ColIdButaca.Visible = false;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 88);
            label7.Name = "label7";
            label7.Size = new Size(82, 30);
            label7.TabIndex = 127;
            label7.Text = "Tickets";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DimGray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(152, 535);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 26);
            btnCancelar.TabIndex = 126;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(671, 57);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 125;
            label5.Text = "Cant de entradas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(460, 53);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 124;
            label4.Text = "Empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(207, 57);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 123;
            label3.Text = "Forma de pago:";
            // 
            // cboClientes
            // 
            cboClientes.BackColor = Color.DarkGray;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(75, 54);
            cboClientes.Margin = new Padding(3, 2, 3, 2);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(121, 23);
            cboClientes.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 121;
            label2.Text = "Cliente:";
            // 
            // txtProximoComprobante
            // 
            txtProximoComprobante.AutoSize = true;
            txtProximoComprobante.BackColor = SystemColors.ActiveCaptionText;
            txtProximoComprobante.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtProximoComprobante.ForeColor = Color.White;
            txtProximoComprobante.Location = new Point(318, 9);
            txtProximoComprobante.Name = "txtProximoComprobante";
            txtProximoComprobante.Size = new Size(222, 30);
            txtProximoComprobante.TabIndex = 120;
            txtProximoComprobante.Text = "Nuevo Comprobante";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DimGray;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(20, 535);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 25);
            btnAceptar.TabIndex = 119;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // cboEmpleado
            // 
            cboEmpleado.BackColor = Color.DarkGray;
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(544, 55);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(121, 23);
            cboEmpleado.TabIndex = 118;
            // 
            // cboFormasP
            // 
            cboFormasP.BackColor = Color.DarkGray;
            cboFormasP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormasP.FormattingEnabled = true;
            cboFormasP.Location = new Point(327, 55);
            cboFormasP.Name = "cboFormasP";
            cboFormasP.Size = new Size(121, 23);
            cboFormasP.TabIndex = 117;
            // 
            // button44
            // 
            button44.BackColor = Color.Lime;
            button44.Location = new Point(774, 335);
            button44.Name = "button44";
            button44.Size = new Size(28, 23);
            button44.TabIndex = 184;
            button44.UseVisualStyleBackColor = false;
            // 
            // button43
            // 
            button43.BackColor = Color.Lime;
            button43.Location = new Point(717, 335);
            button43.Name = "button43";
            button43.Size = new Size(28, 23);
            button43.TabIndex = 183;
            button43.UseVisualStyleBackColor = false;
            // 
            // button42
            // 
            button42.BackColor = Color.Lime;
            button42.Location = new Point(658, 335);
            button42.Name = "button42";
            button42.Size = new Size(28, 23);
            button42.TabIndex = 182;
            button42.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            button39.BackColor = Color.Lime;
            button39.Location = new Point(495, 335);
            button39.Name = "button39";
            button39.Size = new Size(28, 23);
            button39.TabIndex = 179;
            button39.UseVisualStyleBackColor = false;
            // 
            // button41
            // 
            button41.BackColor = Color.Lime;
            button41.Location = new Point(604, 335);
            button41.Name = "button41";
            button41.Size = new Size(28, 23);
            button41.TabIndex = 181;
            button41.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            button40.BackColor = Color.Lime;
            button40.Location = new Point(549, 335);
            button40.Name = "button40";
            button40.Size = new Size(28, 23);
            button40.TabIndex = 180;
            button40.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            button38.BackColor = Color.Lime;
            button38.Location = new Point(440, 335);
            button38.Name = "button38";
            button38.Size = new Size(28, 23);
            button38.TabIndex = 178;
            button38.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            button35.BackColor = Color.Lime;
            button35.Location = new Point(277, 335);
            button35.Name = "button35";
            button35.Size = new Size(28, 23);
            button35.TabIndex = 175;
            button35.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            button37.BackColor = Color.Lime;
            button37.Location = new Point(386, 335);
            button37.Name = "button37";
            button37.Size = new Size(28, 23);
            button37.TabIndex = 177;
            button37.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            button36.BackColor = Color.Lime;
            button36.Location = new Point(331, 335);
            button36.Name = "button36";
            button36.Size = new Size(28, 23);
            button36.TabIndex = 176;
            button36.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            button34.BackColor = Color.Lime;
            button34.Location = new Point(222, 335);
            button34.Name = "button34";
            button34.Size = new Size(28, 23);
            button34.TabIndex = 174;
            button34.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            button31.BackColor = Color.Lime;
            button31.Location = new Point(59, 335);
            button31.Name = "button31";
            button31.Size = new Size(28, 23);
            button31.TabIndex = 171;
            button31.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            button33.BackColor = Color.Lime;
            button33.Location = new Point(168, 335);
            button33.Name = "button33";
            button33.Size = new Size(28, 23);
            button33.TabIndex = 173;
            button33.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            button32.BackColor = Color.Lime;
            button32.Location = new Point(113, 335);
            button32.Name = "button32";
            button32.Size = new Size(28, 23);
            button32.TabIndex = 172;
            button32.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = Color.Lime;
            button30.Location = new Point(717, 296);
            button30.Name = "button30";
            button30.Size = new Size(28, 23);
            button30.TabIndex = 170;
            button30.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = Color.Lime;
            button29.Location = new Point(658, 296);
            button29.Name = "button29";
            button29.Size = new Size(28, 23);
            button29.TabIndex = 169;
            button29.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            button26.BackColor = Color.Lime;
            button26.Location = new Point(495, 296);
            button26.Name = "button26";
            button26.Size = new Size(28, 23);
            button26.TabIndex = 166;
            button26.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = Color.Lime;
            button28.Location = new Point(604, 296);
            button28.Name = "button28";
            button28.Size = new Size(28, 23);
            button28.TabIndex = 168;
            button28.UseVisualStyleBackColor = false;
            button28.Click += button28_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.Lime;
            button27.Location = new Point(549, 296);
            button27.Name = "button27";
            button27.Size = new Size(28, 23);
            button27.TabIndex = 167;
            button27.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = Color.Lime;
            button25.Location = new Point(440, 296);
            button25.Name = "button25";
            button25.Size = new Size(28, 23);
            button25.TabIndex = 165;
            button25.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.Lime;
            button22.Location = new Point(277, 296);
            button22.Name = "button22";
            button22.Size = new Size(28, 23);
            button22.TabIndex = 162;
            button22.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = Color.Lime;
            button24.Location = new Point(386, 296);
            button24.Name = "button24";
            button24.Size = new Size(28, 23);
            button24.TabIndex = 164;
            button24.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = Color.Lime;
            button23.Location = new Point(331, 296);
            button23.Name = "button23";
            button23.Size = new Size(28, 23);
            button23.TabIndex = 163;
            button23.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.Lime;
            button21.Location = new Point(222, 296);
            button21.Name = "button21";
            button21.Size = new Size(28, 23);
            button21.TabIndex = 161;
            button21.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.Lime;
            button20.Location = new Point(168, 296);
            button20.Name = "button20";
            button20.Size = new Size(28, 23);
            button20.TabIndex = 160;
            button20.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.Lime;
            button19.Location = new Point(113, 296);
            button19.Name = "button19";
            button19.Size = new Size(28, 23);
            button19.TabIndex = 159;
            button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.Lime;
            button18.Location = new Point(658, 257);
            button18.Name = "button18";
            button18.Size = new Size(28, 23);
            button18.TabIndex = 158;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Lime;
            button15.Location = new Point(495, 257);
            button15.Name = "button15";
            button15.Size = new Size(28, 23);
            button15.TabIndex = 155;
            button15.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.Lime;
            button17.Location = new Point(604, 257);
            button17.Name = "button17";
            button17.Size = new Size(28, 23);
            button17.TabIndex = 157;
            button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.Lime;
            button16.Location = new Point(549, 257);
            button16.Name = "button16";
            button16.Size = new Size(28, 23);
            button16.TabIndex = 156;
            button16.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Lime;
            button14.Location = new Point(440, 257);
            button14.Name = "button14";
            button14.Size = new Size(28, 23);
            button14.TabIndex = 154;
            button14.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Lime;
            button11.Location = new Point(277, 257);
            button11.Name = "button11";
            button11.Size = new Size(28, 23);
            button11.TabIndex = 151;
            button11.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Lime;
            button13.Location = new Point(386, 257);
            button13.Name = "button13";
            button13.Size = new Size(28, 23);
            button13.TabIndex = 153;
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Lime;
            button12.Location = new Point(331, 257);
            button12.Name = "button12";
            button12.Size = new Size(28, 23);
            button12.TabIndex = 152;
            button12.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Lime;
            button10.Location = new Point(222, 257);
            button10.Name = "button10";
            button10.Size = new Size(28, 23);
            button10.TabIndex = 150;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Lime;
            button9.Location = new Point(168, 257);
            button9.Name = "button9";
            button9.Size = new Size(28, 23);
            button9.TabIndex = 149;
            button9.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Location = new Point(495, 219);
            button6.Name = "button6";
            button6.Size = new Size(28, 23);
            button6.TabIndex = 146;
            button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Lime;
            button8.Location = new Point(604, 219);
            button8.Name = "button8";
            button8.Size = new Size(28, 23);
            button8.TabIndex = 148;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(549, 219);
            button7.Name = "button7";
            button7.Size = new Size(28, 23);
            button7.TabIndex = 147;
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(440, 219);
            button5.Name = "button5";
            button5.Size = new Size(28, 23);
            button5.TabIndex = 145;
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(277, 219);
            button2.Name = "button2";
            button2.Size = new Size(28, 23);
            button2.TabIndex = 142;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Location = new Point(386, 219);
            button4.Name = "button4";
            button4.Size = new Size(28, 23);
            button4.TabIndex = 144;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(331, 219);
            button3.Name = "button3";
            button3.Size = new Size(28, 23);
            button3.TabIndex = 143;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(222, 219);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 141;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 140;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(881, 570);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 185;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(59, 361);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 186;
            label1.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(20, 335);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 187;
            label8.Text = "4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(20, 296);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 188;
            label9.Text = "3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(20, 257);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 189;
            label12.Text = "2";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(20, 219);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 190;
            label15.Text = "1";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.ForeColor = Color.Transparent;
            label16.Location = new Point(118, 361);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 191;
            label16.Text = "2";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.Transparent;
            label17.Location = new Point(168, 361);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 192;
            label17.Text = "3";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.ForeColor = Color.Transparent;
            label18.Location = new Point(222, 361);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 193;
            label18.Text = "4";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.ForeColor = Color.Transparent;
            label19.Location = new Point(774, 361);
            label19.Name = "label19";
            label19.Size = new Size(19, 15);
            label19.TabIndex = 194;
            label19.Text = "14";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.ForeColor = Color.Transparent;
            label20.Location = new Point(717, 361);
            label20.Name = "label20";
            label20.Size = new Size(19, 15);
            label20.TabIndex = 195;
            label20.Text = "13";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.ForeColor = Color.Transparent;
            label21.Location = new Point(658, 361);
            label21.Name = "label21";
            label21.Size = new Size(19, 15);
            label21.TabIndex = 196;
            label21.Text = "12";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.ForeColor = Color.Transparent;
            label22.Location = new Point(604, 361);
            label22.Name = "label22";
            label22.Size = new Size(19, 15);
            label22.TabIndex = 197;
            label22.Text = "11";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.ForeColor = Color.Transparent;
            label23.Location = new Point(549, 361);
            label23.Name = "label23";
            label23.Size = new Size(19, 15);
            label23.TabIndex = 198;
            label23.Text = "10";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.ForeColor = Color.Transparent;
            label24.Location = new Point(495, 361);
            label24.Name = "label24";
            label24.Size = new Size(13, 15);
            label24.TabIndex = 199;
            label24.Text = "9";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.ForeColor = Color.Transparent;
            label25.Location = new Point(440, 361);
            label25.Name = "label25";
            label25.Size = new Size(13, 15);
            label25.TabIndex = 200;
            label25.Text = "8";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.ForeColor = Color.Transparent;
            label26.Location = new Point(386, 361);
            label26.Name = "label26";
            label26.Size = new Size(13, 15);
            label26.TabIndex = 201;
            label26.Text = "7";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.ForeColor = Color.Transparent;
            label27.Location = new Point(331, 361);
            label27.Name = "label27";
            label27.Size = new Size(13, 15);
            label27.TabIndex = 202;
            label27.Text = "6";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.ForeColor = Color.Transparent;
            label28.Location = new Point(277, 361);
            label28.Name = "label28";
            label28.Size = new Size(13, 15);
            label28.TabIndex = 203;
            label28.Text = "5";
            // 
            // FrmAltaComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(871, 565);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(button44);
            Controls.Add(button43);
            Controls.Add(button42);
            Controls.Add(button39);
            Controls.Add(button41);
            Controls.Add(button40);
            Controls.Add(button38);
            Controls.Add(button35);
            Controls.Add(button37);
            Controls.Add(button36);
            Controls.Add(button34);
            Controls.Add(button31);
            Controls.Add(button33);
            Controls.Add(button32);
            Controls.Add(button30);
            Controls.Add(button29);
            Controls.Add(button26);
            Controls.Add(button28);
            Controls.Add(button27);
            Controls.Add(button25);
            Controls.Add(button22);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button15);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button14);
            Controls.Add(button11);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(cantEntradas);
            Controls.Add(cboFechaHora);
            Controls.Add(btnAgregar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboPeliculas);
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
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(887, 604);
            MinimumSize = new Size(887, 604);
            Name = "FrmAltaComprobante";
            Text = "Alta Comprobante";
            Load += FrmAltaComprobante_Load_1;
            ((System.ComponentModel.ISupportInitialize)cantEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private Label label13;
        private NumericUpDown cantEntradas;
        private ComboBox cboFechaHora;
        private Button btnAgregar;
        private Label label11;
        private Label label10;
        private ComboBox cboPeliculas;
        private TextBox txtPreUnitario;
        private Label label6;
        private DataGridView dgvTickets;
        private Label label7;
        private Button btnCancelar;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboClientes;
        private Label label2;
        private Label txtProximoComprobante;
        private Button btnAceptar;
        private ComboBox cboEmpleado;
        private ComboBox cboFormasP;
        private Button button44;
        private Button button43;
        private Button button42;
        private Button button39;
        private Button button41;
        private Button button40;
        private Button button38;
        private Button button35;
        private Button button37;
        private Button button36;
        private Button button34;
        private Button button31;
        private Button button33;
        private Button button32;
        private Button button30;
        private Button button29;
        private Button button26;
        private Button button28;
        private Button button27;
        private Button button25;
        private Button button22;
        private Button button24;
        private Button button23;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button15;
        private Button button17;
        private Button button16;
        private Button button14;
        private Button button11;
        private Button button13;
        private Button button12;
        private Button button10;
        private Button button9;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ColIdButaca;
        private DataGridViewTextBoxColumn ColPreUnitario;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColFechaHora;
        private DataGridViewButtonColumn ColQuitar;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
    }
}