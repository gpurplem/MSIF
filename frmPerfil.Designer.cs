namespace MSIF
{
    partial class frmPerfil
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
            lblEmail = new Label();
            lblApelido = new Label();
            pictureBox1 = new PictureBox();
            lblGetApelido = new Label();
            lblGetEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 49);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "E-mail";
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(63, 12);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(74, 25);
            lblApelido.TabIndex = 12;
            lblApelido.Text = "Apelido";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(629, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 178);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblGetApelido
            // 
            lblGetApelido.AutoSize = true;
            lblGetApelido.Location = new Point(143, 12);
            lblGetApelido.Name = "lblGetApelido";
            lblGetApelido.Size = new Size(16, 25);
            lblGetApelido.TabIndex = 15;
            lblGetApelido.Text = ".";
            // 
            // lblGetEmail
            // 
            lblGetEmail.AutoSize = true;
            lblGetEmail.Location = new Point(143, 49);
            lblGetEmail.Name = "lblGetEmail";
            lblGetEmail.Size = new Size(16, 25);
            lblGetEmail.TabIndex = 16;
            lblGetEmail.Text = ".";
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGetEmail);
            Controls.Add(lblGetApelido);
            Controls.Add(pictureBox1);
            Controls.Add(lblEmail);
            Controls.Add(lblApelido);
            Name = "frmPerfil";
            Text = "MSIF - Perfil usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEmail;
        private Label lblApelido;
        private PictureBox pictureBox1;
        private Label lblGetApelido;
        private Label lblGetEmail;
    }
}