namespace MSIF
{
    partial class frmTelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmailLogar = new System.Windows.Forms.TextBox();
            this.txtSenhaLogar = new System.Windows.Forms.TextBox();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Caladea", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(34, 181);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(221, 31);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Caladea", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(34, 146);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(221, 31);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "LOGIN";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(23, 62);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSenha.Location = new System.Drawing.Point(23, 90);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 17);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtEmailLogar
            // 
            this.txtEmailLogar.BackColor = System.Drawing.Color.White;
            this.txtEmailLogar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailLogar.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailLogar.Location = new System.Drawing.Point(81, 61);
            this.txtEmailLogar.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailLogar.Name = "txtEmailLogar";
            this.txtEmailLogar.Size = new System.Drawing.Size(174, 23);
            this.txtEmailLogar.TabIndex = 4;
            // 
            // txtSenhaLogar
            // 
            this.txtSenhaLogar.Location = new System.Drawing.Point(81, 90);
            this.txtSenhaLogar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaLogar.Name = "txtSenhaLogar";
            this.txtSenhaLogar.Size = new System.Drawing.Size(174, 23);
            this.txtSenhaLogar.TabIndex = 5;
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarSenha.FlatAppearance.BorderSize = 0;
            this.btnRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarSenha.Font = new System.Drawing.Font("Caladea", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnRecuperarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRecuperarSenha.Location = new System.Drawing.Point(55, 117);
            this.btnRecuperarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(178, 28);
            this.btnRecuperarSenha.TabIndex = 6;
            this.btnRecuperarSenha.Text = "Esqueci minha senha";
            this.btnRecuperarSenha.UseVisualStyleBackColor = false;
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MSIF.Properties.Resources.TELA_LOGIN;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.txtSenhaLogar);
            this.Controls.Add(this.txtEmailLogar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCadastrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTelaLogin";
            this.Text = "MSIF - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private Button btnEntrar;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtEmailLogar;
        private TextBox txtSenhaLogar;
        private Button btnRecuperarSenha;
    }
}