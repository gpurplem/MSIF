namespace MSIF
{
    partial class frmTelaEditarCadastro
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
            btnSelecionarImagem = new Button();
            button1 = new Button();
            txtSenha2 = new TextBox();
            txtSenha1 = new TextBox();
            txtEmail = new TextBox();
            txtApelido = new TextBox();
            lblImagemPerfil = new Label();
            lblSenha2 = new Label();
            lblSenha1 = new Label();
            lblEmail = new Label();
            lblApelido = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.Location = new Point(137, 160);
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.Size = new Size(179, 34);
            btnSelecionarImagem.TabIndex = 22;
            btnSelecionarImagem.Text = "Selecionar imagem";
            btnSelecionarImagem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 202);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 21;
            button1.Text = "Salvar mudanças";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSenha2
            // 
            txtSenha2.Location = new Point(137, 120);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(179, 31);
            txtSenha2.TabIndex = 20;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(137, 83);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.Size = new Size(179, 31);
            txtSenha1.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 31);
            txtEmail.TabIndex = 18;
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(137, 9);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(179, 31);
            txtApelido.TabIndex = 17;
            // 
            // lblImagemPerfil
            // 
            lblImagemPerfil.AutoSize = true;
            lblImagemPerfil.Location = new Point(8, 160);
            lblImagemPerfil.Name = "lblImagemPerfil";
            lblImagemPerfil.Size = new Size(123, 25);
            lblImagemPerfil.TabIndex = 16;
            lblImagemPerfil.Text = "Imagem perfil";
            // 
            // lblSenha2
            // 
            lblSenha2.AutoSize = true;
            lblSenha2.Location = new Point(13, 126);
            lblSenha2.Name = "lblSenha2";
            lblSenha2.Size = new Size(118, 25);
            lblSenha2.TabIndex = 15;
            lblSenha2.Text = "Repetir senha";
            // 
            // lblSenha1
            // 
            lblSenha1.AutoSize = true;
            lblSenha1.Location = new Point(26, 83);
            lblSenha1.Name = "lblSenha1";
            lblSenha1.Size = new Size(105, 25);
            lblSenha1.TabIndex = 14;
            lblSenha1.Text = "Nova senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(70, 46);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "E-mail";
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(57, 9);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(74, 25);
            lblApelido.TabIndex = 12;
            lblApelido.Text = "Apelido";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(322, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 185);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frmTelaEditarCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
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
            Name = "frmTelaEditarCadastro";
            Text = "MSIF - Editar cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecionarImagem;
        private Button button1;
        private TextBox txtSenha2;
        private TextBox txtSenha1;
        private TextBox txtEmail;
        private TextBox txtApelido;
        private Label lblImagemPerfil;
        private Label lblSenha2;
        private Label lblSenha1;
        private Label lblEmail;
        private Label lblApelido;
        private PictureBox pictureBox1;
    }
}