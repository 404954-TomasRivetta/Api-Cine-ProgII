namespace CineFront.Presentacion.Formularios
{
    partial class FrmConsultarCliente
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
            dgvClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            cboBarrio = new ComboBox();
            label1 = new Label();
            btnConsultar = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvClientes.Location = new Point(24, 128);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(794, 326);
            dgvClientes.TabIndex = 21;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id Cliente";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre Cliente";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Correo Cliente";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Barrio";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Nro telefono";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(24, 478);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(147, 35);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 478);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 35);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(682, 478);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cboBarrio
            // 
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(98, 32);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(153, 23);
            cboBarrio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 17;
            label1.Text = "Barrios:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(585, 25);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 35);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboBarrio);
            groupBox1.Location = new Point(24, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 83);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 565);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Name = "FrmConsultarCliente";
            Text = "Consulta de Clientes";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private ComboBox cboBarrio;
        private Label label1;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
    }
}