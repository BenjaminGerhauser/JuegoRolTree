namespace JuegoRol
{
    partial class frmCrearJugador
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            picImagen = new PictureBox();
            txtNombre = new TextBox();
            txtAtaque = new TextBox();
            txtImagen = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            btnCancenlar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 27);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 77);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Ataque";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(110, 163);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(192, 192);
            picImagen.TabIndex = 3;
            picImagen.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(119, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtAtaque
            // 
            txtAtaque.Location = new Point(66, 95);
            txtAtaque.Name = "txtAtaque";
            txtAtaque.Size = new Size(119, 23);
            txtAtaque.TabIndex = 5;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(227, 95);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(121, 23);
            txtImagen.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 77);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "Imagen(url)";
            // 
            // btnCancenlar
            // 
            btnCancenlar.Location = new Point(227, 124);
            btnCancenlar.Name = "btnCancenlar";
            btnCancenlar.Size = new Size(75, 23);
            btnCancenlar.TabIndex = 9;
            btnCancenlar.Text = "Cancelar";
            btnCancenlar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(110, 124);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmCrearJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 365);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancenlar);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(txtImagen);
            Controls.Add(txtAtaque);
            Controls.Add(txtNombre);
            Controls.Add(picImagen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCrearJugador";
            Text = "frmCrearJugador";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox picImagen;
        private TextBox txtNombre;
        private TextBox txtAtaque;
        private TextBox txtImagen;
        private ComboBox comboBox1;
        private Label label4;
        private Button btnCancenlar;
        private Button btnAceptar;
    }
}