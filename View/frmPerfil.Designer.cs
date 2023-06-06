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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGetApelido = new System.Windows.Forms.Label();
            this.lblGetEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(54, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 17);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.BackColor = System.Drawing.Color.Transparent;
            this.lblApelido.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApelido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblApelido.Location = new System.Drawing.Point(54, 97);
            this.lblApelido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(68, 17);
            this.lblApelido.TabIndex = 12;
            this.lblApelido.Text = "Apelido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(412, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 107);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblGetApelido
            // 
            this.lblGetApelido.AutoSize = true;
            this.lblGetApelido.BackColor = System.Drawing.Color.Transparent;
            this.lblGetApelido.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetApelido.ForeColor = System.Drawing.Color.White;
            this.lblGetApelido.Location = new System.Drawing.Point(122, 99);
            this.lblGetApelido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGetApelido.Name = "lblGetApelido";
            this.lblGetApelido.Size = new System.Drawing.Size(10, 15);
            this.lblGetApelido.TabIndex = 15;
            this.lblGetApelido.Text = ".";
            // 
            // lblGetEmail
            // 
            this.lblGetEmail.AutoSize = true;
            this.lblGetEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblGetEmail.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetEmail.ForeColor = System.Drawing.Color.White;
            this.lblGetEmail.Location = new System.Drawing.Point(115, 54);
            this.lblGetEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGetEmail.Name = "lblGetEmail";
            this.lblGetEmail.Size = new System.Drawing.Size(10, 15);
            this.lblGetEmail.TabIndex = 16;
            this.lblGetEmail.Text = ".";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MSIF.Properties.Resources.TELA_PERFIL;
            this.ClientSize = new System.Drawing.Size(560, 308);
            this.Controls.Add(this.lblGetEmail);
            this.Controls.Add(this.lblGetApelido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApelido);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPerfil";
            this.Text = "MSIF - Perfil usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblEmail;
        private Label lblApelido;
        private PictureBox pictureBox1;
        private Label lblGetApelido;
        private Label lblGetEmail;
    }
}