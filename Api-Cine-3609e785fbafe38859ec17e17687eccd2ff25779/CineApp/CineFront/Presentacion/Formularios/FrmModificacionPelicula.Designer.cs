namespace CineFront.Presentacion.Formularios
{
    partial class FrmModificacionPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificacionPelicula));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            rbtNo = new RadioButton();
            rbtSi = new RadioButton();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtDescripcion = new TextBox();
            cboTipoPelicula = new ComboBox();
            cboTipoPublico = new ComboBox();
            cboIdioma = new ComboBox();
            cboDirectores = new ComboBox();
            txtNumPelicula = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(92, 245);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 64;
            label7.Text = "Idioma:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(81, 166);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 63;
            label6.Text = "Director:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(16, 308);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 62;
            label5.Text = "Tipo de Pelicula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(18, 374);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 61;
            label4.Text = "Tipo de Publico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 440);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 60;
            label2.Text = "Subtitulada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(81, 96);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 59;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(55, 27);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 58;
            label1.Text = "Modificar Pelicula";
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.BackColor = Color.Gray;
            rbtNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNo.ForeColor = SystemColors.ButtonFace;
            rbtNo.Location = new Point(299, 438);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(55, 29);
            rbtNo.TabIndex = 57;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = false;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.BackColor = Color.Gray;
            rbtSi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtSi.ForeColor = SystemColors.ButtonFace;
            rbtSi.Location = new Point(220, 438);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(45, 29);
            rbtSi.TabIndex = 56;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(283, 502);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 55;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(92, 502);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 36);
            btnAceptar.TabIndex = 54;
            btnAceptar.Text = "Modificar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Gray;
            txtDescripcion.ForeColor = SystemColors.ButtonFace;
            txtDescripcion.Location = new Point(220, 98);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(191, 23);
            txtDescripcion.TabIndex = 53;
            // 
            // cboTipoPelicula
            // 
            cboTipoPelicula.BackColor = Color.Gray;
            cboTipoPelicula.ForeColor = SystemColors.ButtonFace;
            cboTipoPelicula.FormattingEnabled = true;
            cboTipoPelicula.Location = new Point(220, 310);
            cboTipoPelicula.Name = "cboTipoPelicula";
            cboTipoPelicula.Size = new Size(158, 23);
            cboTipoPelicula.TabIndex = 52;
            // 
            // cboTipoPublico
            // 
            cboTipoPublico.BackColor = Color.Gray;
            cboTipoPublico.ForeColor = SystemColors.ButtonFace;
            cboTipoPublico.FormattingEnabled = true;
            cboTipoPublico.Location = new Point(220, 374);
            cboTipoPublico.Name = "cboTipoPublico";
            cboTipoPublico.Size = new Size(156, 23);
            cboTipoPublico.TabIndex = 51;
            // 
            // cboIdioma
            // 
            cboIdioma.BackColor = Color.Gray;
            cboIdioma.ForeColor = SystemColors.ButtonFace;
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(220, 247);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(132, 23);
            cboIdioma.TabIndex = 50;
            // 
            // cboDirectores
            // 
            cboDirectores.BackColor = Color.Gray;
            cboDirectores.ForeColor = SystemColors.ButtonFace;
            cboDirectores.FormattingEnabled = true;
            cboDirectores.Location = new Point(220, 168);
            cboDirectores.Name = "cboDirectores";
            cboDirectores.Size = new Size(182, 23);
            cboDirectores.TabIndex = 49;
            // 
            // txtNumPelicula
            // 
            txtNumPelicula.AutoSize = true;
            txtNumPelicula.BackColor = Color.Black;
            txtNumPelicula.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumPelicula.ForeColor = SystemColors.ButtonFace;
            txtNumPelicula.Location = new Point(251, 27);
            txtNumPelicula.Name = "txtNumPelicula";
            txtNumPelicula.Size = new Size(51, 25);
            txtNumPelicula.TabIndex = 65;
            txtNumPelicula.Text = "N°: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(881, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // FrmModificacionPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 565);
            Controls.Add(txtNumPelicula);
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
            Name = "FrmModificacionPelicula";
            Text = "Modificar Pelicula";
            Load += FrmModificacionPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private RadioButton rbtNo;
        private RadioButton rbtSi;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtDescripcion;
        private ComboBox cboTipoPelicula;
        private ComboBox cboTipoPublico;
        private ComboBox cboIdioma;
        private ComboBox cboDirectores;
        private Label txtNumPelicula;
        private PictureBox pictureBox1;
    }
}