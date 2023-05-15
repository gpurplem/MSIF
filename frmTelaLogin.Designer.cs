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
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(24, 219);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 34);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(226, 137);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 34);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 39);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(24, 86);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtEmailLogar
            // 
            txtEmailLogar.Location = new Point(91, 39);
            txtEmailLogar.Name = "txtEmailLogar";
            txtEmailLogar.Size = new Size(247, 31);
            txtEmailLogar.TabIndex = 4;
            // 
            // txtSenhaLogar
            // 
            txtSenhaLogar.Location = new Point(91, 86);
            txtSenhaLogar.Name = "txtSenhaLogar";
            txtSenhaLogar.Size = new Size(247, 31);
            txtSenhaLogar.TabIndex = 5;
            // 
            // frmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenhaLogar);
            Controls.Add(txtEmailLogar);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastrar);
            Name = "frmTelaLogin";
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
    }
}