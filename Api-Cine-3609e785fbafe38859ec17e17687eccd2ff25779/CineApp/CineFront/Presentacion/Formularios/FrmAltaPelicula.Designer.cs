namespace CineFront.Presentacion.Formularios
{
    partial class FrmAltaPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPelicula));
            cboDirectores = new ComboBox();
            cboIdioma = new ComboBox();
            cboTipoPublico = new ComboBox();
            cboTipoPelicula = new ComboBox();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            rbtSi = new RadioButton();
            rbtNo = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboDirectores
            // 
            cboDirectores.BackColor = Color.Gray;
            cboDirectores.ForeColor = SystemColors.ButtonFace;
            cboDirectores.FormattingEnabled = true;
            cboDirectores.Location = new Point(222, 173);
            cboDirectores.Name = "cboDirectores";
            cboDirectores.Size = new Size(167, 23);
            cboDirectores.TabIndex = 2;
            // 
            // cboIdioma
            // 
            cboIdioma.BackColor = Color.Gray;
            cboIdioma.ForeColor = SystemColors.ButtonFace;
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(222, 237);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(146, 23);
            cboIdioma.TabIndex = 3;
            // 
            // cboTipoPublico
            // 
            cboTipoPublico.BackColor = Color.Gray;
            cboTipoPublico.ForeColor = SystemColors.ButtonFace;
            cboTipoPublico.FormattingEnabled = true;
            cboTipoPublico.Location = new Point(222, 365);
            cboTipoPublico.Name = "cboTipoPublico";
            cboTipoPublico.Size = new Size(146, 23);
            cboTipoPublico.TabIndex = 5;
            // 
            // cboTipoPelicula
            // 
            cboTipoPelicula.BackColor = Color.Gray;
            cboTipoPelicula.ForeColor = SystemColors.ButtonFace;
            cboTipoPelicula.FormattingEnabled = true;
            cboTipoPelicula.Location = new Point(222, 302);
            cboTipoPelicula.Name = "cboTipoPelicula";
            cboTipoPelicula.Size = new Size(146, 23);
            cboTipoPelicula.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Gray;
            txtDescripcion.ForeColor = SystemColors.ButtonFace;
            txtDescripcion.Location = new Point(222, 103);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(167, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = SystemColors.ActiveCaptionText;
            btnAceptar.Location = new Point(77, 470);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 36);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(239, 470);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.BackColor = Color.Gray;
            rbtSi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtSi.ForeColor = SystemColors.ButtonFace;
            rbtSi.Location = new Point(220, 420);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(41, 25);
            rbtSi.TabIndex = 6;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = false;
            rbtSi.CheckedChanged += rbtSi_CheckedChanged;
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.BackColor = Color.Gray;
            rbtNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNo.ForeColor = SystemColors.ButtonFace;
            rbtNo.Location = new Point(286, 420);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(49, 25);
            rbtNo.TabIndex = 7;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(41, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 13;
            label1.Text = "Nueva Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(94, 103);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 43;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 420);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 44;
            label2.Text = "Subtitulada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(32, 365);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 45;
            label4.Text = "Tipo de Publico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(30, 302);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 46;
            label5.Text = "Tipo de Pelicula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(95, 171);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 47;
            label6.Text = "Director:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(105, 237);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 48;
            label7.Text = "Idioma:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(889, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // FrmAltaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 562);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(rbtNo);
            Controls.Add(rbtSi);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(cboTipoPelicula);
            Controls.Add(cboTipoPublico);
            Controls.Add(cboIdioma);
            Controls.Add(cboDirectores);
            Controls.Add(pictureBox1);
            Name = "FrmAltaPelicula";
            Text = "Peliculas";
            Load += FrmAltaPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboDirectores;
        private ComboBox cboIdioma;
        private ComboBox cboTipoPublico;
        private ComboBox cboTipoPelicula;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private RadioButton rbtSi;
        private RadioButton rbtNo;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
    }
}