namespace MSIF
{
    partial class frmTelaCadastro
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
            lblApelido = new Label();
            lblEmail = new Label();
            lblSenha1 = new Label();
            lblSenha2 = new Label();
            lblImagemPerfil = new Label();
            txtApelido = new TextBox();
            txtEmail = new TextBox();
            txtSenha1 = new TextBox();
            txtSenha2 = new TextBox();
            button1 = new Button();
            fileDialog = new OpenFileDialog();
            btnSelecionarImagem = new Button();
            lblNome = new Label();
            txtNomeCompleto = new TextBox();
            SuspendLayout();
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(61, 48);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(74, 25);
            lblApelido.TabIndex = 0;
            lblApelido.Text = "Apelido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(74, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblSenha1
            // 
            lblSenha1.AutoSize = true;
            lblSenha1.Location = new Point(75, 122);
            lblSenha1.Name = "lblSenha1";
            lblSenha1.Size = new Size(60, 25);
            lblSenha1.TabIndex = 2;
            lblSenha1.Text = "Senha";
            // 
            // lblSenha2
            // 
            lblSenha2.AutoSize = true;
            lblSenha2.Location = new Point(17, 165);
            lblSenha2.Name = "lblSenha2";
            lblSenha2.Size = new Size(118, 25);
            lblSenha2.TabIndex = 3;
            lblSenha2.Text = "Repetir senha";
            // 
            // lblImagemPerfil
            // 
            lblImagemPerfil.AutoSize = true;
            lblImagemPerfil.Location = new Point(12, 199);
            lblImagemPerfil.Name = "lblImagemPerfil";
            lblImagemPerfil.Size = new Size(123, 25);
            lblImagemPerfil.TabIndex = 4;
            lblImagemPerfil.Text = "Imagem perfil";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(141, 48);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(179, 31);
            txtApelido.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(141, 122);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.Size = new Size(179, 31);
            txtSenha1.TabIndex = 7;
            // 
            // txtSenha2
            // 
            txtSenha2.Location = new Point(141, 159);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(179, 31);
            txtSenha2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(17, 241);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // fileDialog
            // 
            fileDialog.FileName = "openFileDialog1";
            fileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.Location = new Point(141, 199);
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.Size = new Size(179, 34);
            btnSelecionarImagem.TabIndex = 11;
            btnSelecionarImagem.Text = "Selecionar imagem";
            btnSelecionarImagem.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(-7, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(142, 25);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(141, 12);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(179, 31);
            txtNomeCompleto.TabIndex = 13;
            // 
            // frmTelaCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNome);
            Controls.Add(btnSelecionarImagem);
            Controls.Add(button1);
            Controls.Add(txtSenha2);
            Controls.Add(txtSenha1);
            Controls.Add(txtEmail);
            Controls.Add(txtApelido);
            Controls.Add(lblImagemPerfil);
            Controls.Add(lblSenha2);
            Controls.Add(lblSenha1);
            Controls.Add(lblEmail);
            Controls.Add(lblApelido);
            Name = "frmTelaCadastro";
            Text = "MSIF - Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApelido;
        private Label lblEmail;
        private Label lblSenha1;
        private Label lblSenha2;
        private Label lblImagemPerfil;
        private TextBox txtApelido;
        private TextBox txtEmail;
        private TextBox txtSenha1;
        private TextBox txtSenha2;
        private Button button1;
        private OpenFileDialog fileDialog;
        private Button btnSelecionarImagem;
        private Label lblNome;
        private TextBox txtNomeCompleto;
    }
}