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
            btnCadastrar = new Button();
            btnEntrar = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            txtEmailLogar = new TextBox();
            txtSenhaLogar = new TextBox();
            btnRecuperarSenha = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(185, 148);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(120, 34);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(311, 148);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 34);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 26);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(29, 89);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtEmailLogar
            // 
            txtEmailLogar.Location = new Point(95, 23);
            txtEmailLogar.Name = "txtEmailLogar";
            txtEmailLogar.Size = new Size(328, 31);
            txtEmailLogar.TabIndex = 0;
            // 
            // txtSenhaLogar
            // 
            txtSenhaLogar.Location = new Point(95, 83);
            txtSenhaLogar.Name = "txtSenhaLogar";
            txtSenhaLogar.Size = new Size(328, 31);
            txtSenhaLogar.TabIndex = 1;
            // 
            // btnRecuperarSenha
            // 
            btnRecuperarSenha.Location = new Point(29, 148);
            btnRecuperarSenha.Name = "btnRecuperarSenha";
            btnRecuperarSenha.Size = new Size(150, 34);
            btnRecuperarSenha.TabIndex = 2;
            btnRecuperarSenha.Text = "Recuperar senha";
            btnRecuperarSenha.UseVisualStyleBackColor = true;
            btnRecuperarSenha.Click += btnRecuperarSenha_Click;
            // 
            // frmTelaLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(471, 219);
            Controls.Add(btnRecuperarSenha);
            Controls.Add(txtSenhaLogar);
            Controls.Add(txtEmailLogar);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmTelaLogin";
            Padding = new Padding(20);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MSIF - Login";
            ResumeLayout(false);
            PerformLayout();
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