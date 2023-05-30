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
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.BackColor = System.Drawing.Color.Transparent;
            this.lblApelido.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApelido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblApelido.Location = new System.Drawing.Point(64, 84);
            this.lblApelido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(68, 17);
            this.lblApelido.TabIndex = 0;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(69, 108);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha1.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSenha1.Location = new System.Drawing.Point(73, 133);
            this.lblSenha1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(56, 17);
            this.lblSenha1.TabIndex = 2;
            this.lblSenha1.Text = "Senha:";
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha2.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSenha2.Location = new System.Drawing.Point(17, 161);
            this.lblSenha2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(112, 17);
            this.lblSenha2.TabIndex = 3;
            this.lblSenha2.Text = "Repetir senha:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(133, 82);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(126, 23);
            this.txtApelido.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 107);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(133, 132);
            this.txtSenha1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(126, 23);
            this.txtSenha1.TabIndex = 7;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(133, 157);
            this.txtSenha2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(126, 23);
            this.txtSenha2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Caladea", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(73, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.BackgroundImage = global::MSIF.Properties.Resources.SEM_FOTO;
            this.btnSelecionarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarImagem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(263, 57);
            this.btnSelecionarImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(84, 83);
            this.btnSelecionarImagem.TabIndex = 11;
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNome.Location = new System.Drawing.Point(9, 58);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(124, 17);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome completo:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(133, 57);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(126, 23);
            this.txtNomeCompleto.TabIndex = 13;
            // 
            // frmTelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MSIF.Properties.Resources.TELA_LOGIN;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.lblSenha1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApelido);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTelaCadastro";
            this.Text = "MSIF - Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblApelido;
        private Label lblEmail;
        private Label lblSenha1;
        private Label lblSenha2;
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