namespace JuegoRol
{
    partial class frmCombate
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
            progresJugador = new ProgressBar();
            progressEnemigo = new ProgressBar();
            lblTiempo = new Label();
            picJugador = new PictureBox();
            picEnemigo = new PictureBox();
            lblNombrePlayer = new Label();
            lblNombreEnemigo = new Label();
            ((System.ComponentModel.ISupportInitialize)picJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).BeginInit();
            SuspendLayout();
            // 
            // progresJugador
            // 
            progresJugador.Location = new Point(41, 74);
            progresJugador.Name = "progresJugador";
            progresJugador.RightToLeftLayout = true;
            progresJugador.Size = new Size(215, 20);
            progresJugador.Style = ProgressBarStyle.Continuous;
            progresJugador.TabIndex = 0;
            // 
            // progressEnemigo
            // 
            progressEnemigo.Location = new Point(544, 74);
            progressEnemigo.Name = "progressEnemigo";
            progressEnemigo.Size = new Size(215, 20);
            progressEnemigo.Style = ProgressBarStyle.Continuous;
            progressEnemigo.TabIndex = 1;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(370, 9);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(38, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "label1";
            // 
            // picJugador
            // 
            picJugador.Location = new Point(41, 141);
            picJugador.Name = "picJugador";
            picJugador.Size = new Size(215, 215);
            picJugador.SizeMode = PictureBoxSizeMode.Zoom;
            picJugador.TabIndex = 3;
            picJugador.TabStop = false;
            // 
            // picEnemigo
            // 
            picEnemigo.Location = new Point(544, 141);
            picEnemigo.Name = "picEnemigo";
            picEnemigo.Size = new Size(215, 215);
            picEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            picEnemigo.TabIndex = 4;
            picEnemigo.TabStop = false;
            picEnemigo.Click += picEnemigo_Click;
            // 
            // lblNombrePlayer
            // 
            lblNombrePlayer.AutoSize = true;
            lblNombrePlayer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombrePlayer.Location = new Point(41, 51);
            lblNombrePlayer.Name = "lblNombrePlayer";
            lblNombrePlayer.Size = new Size(54, 20);
            lblNombrePlayer.TabIndex = 5;
            lblNombrePlayer.Text = "label1";
            // 
            // lblNombreEnemigo
            // 
            lblNombreEnemigo.AutoSize = true;
            lblNombreEnemigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombreEnemigo.Location = new Point(544, 51);
            lblNombreEnemigo.Name = "lblNombreEnemigo";
            lblNombreEnemigo.Size = new Size(54, 20);
            lblNombreEnemigo.TabIndex = 6;
            lblNombreEnemigo.Text = "label1";
            // 
            // frmCombate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(lblNombreEnemigo);
            Controls.Add(lblNombrePlayer);
            Controls.Add(picEnemigo);
            Controls.Add(picJugador);
            Controls.Add(lblTiempo);
            Controls.Add(progressEnemigo);
            Controls.Add(progresJugador);
            Name = "frmCombate";
            Text = "frmCombate";
            Load += frmCombate_Load;
            ((System.ComponentModel.ISupportInitialize)picJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progresJugador;
        private ProgressBar progressEnemigo;
        private Label lblTiempo;
        private PictureBox picJugador;
        private PictureBox picEnemigo;
        private Label lblNombrePlayer;
        private Label lblNombreEnemigo;
    }
}