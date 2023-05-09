namespace MSIF
{
    partial class frmTelaMenuPrincipal
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
            btnAbrirListaContatos = new Button();
            btnAbrirListaMensagens = new Button();
            btnAbrirListaSolicitacoesAmizade = new Button();
            btnAbrirEditarPerfil = new Button();
            btnAbrirPesquisaContatos = new Button();
            SuspendLayout();
            // 
            // btnAbrirListaContatos
            // 
            btnAbrirListaContatos.Location = new Point(12, 12);
            btnAbrirListaContatos.Name = "btnAbrirListaContatos";
            btnAbrirListaContatos.Size = new Size(211, 34);
            btnAbrirListaContatos.TabIndex = 0;
            btnAbrirListaContatos.Text = "Lista de contatos";
            btnAbrirListaContatos.UseVisualStyleBackColor = true;
            // 
            // btnAbrirListaMensagens
            // 
            btnAbrirListaMensagens.Location = new Point(12, 92);
            btnAbrirListaMensagens.Name = "btnAbrirListaMensagens";
            btnAbrirListaMensagens.Size = new Size(211, 34);
            btnAbrirListaMensagens.TabIndex = 1;
            btnAbrirListaMensagens.Text = "Lista de mensagens";
            btnAbrirListaMensagens.UseVisualStyleBackColor = true;
            // 
            // btnAbrirListaSolicitacoesAmizade
            // 
            btnAbrirListaSolicitacoesAmizade.Location = new Point(12, 132);
            btnAbrirListaSolicitacoesAmizade.Name = "btnAbrirListaSolicitacoesAmizade";
            btnAbrirListaSolicitacoesAmizade.Size = new Size(211, 34);
            btnAbrirListaSolicitacoesAmizade.TabIndex = 2;
            btnAbrirListaSolicitacoesAmizade.Text = "Lista de solicitações";
            btnAbrirListaSolicitacoesAmizade.UseVisualStyleBackColor = true;
            // 
            // btnAbrirEditarPerfil
            // 
            btnAbrirEditarPerfil.Location = new Point(12, 172);
            btnAbrirEditarPerfil.Name = "btnAbrirEditarPerfil";
            btnAbrirEditarPerfil.Size = new Size(211, 34);
            btnAbrirEditarPerfil.TabIndex = 3;
            btnAbrirEditarPerfil.Text = "Editar cadastro";
            btnAbrirEditarPerfil.UseVisualStyleBackColor = true;
            // 
            // btnAbrirPesquisaContatos
            // 
            btnAbrirPesquisaContatos.Location = new Point(12, 52);
            btnAbrirPesquisaContatos.Name = "btnAbrirPesquisaContatos";
            btnAbrirPesquisaContatos.Size = new Size(211, 34);
            btnAbrirPesquisaContatos.TabIndex = 4;
            btnAbrirPesquisaContatos.Text = "Pesquisa de usuários";
            btnAbrirPesquisaContatos.UseVisualStyleBackColor = true;
            // 
            // frmTelaMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrirPesquisaContatos);
            Controls.Add(btnAbrirEditarPerfil);
            Controls.Add(btnAbrirListaSolicitacoesAmizade);
            Controls.Add(btnAbrirListaMensagens);
            Controls.Add(btnAbrirListaContatos);
            Name = "frmTelaMenuPrincipal";
            Text = "MSIF - Menu principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirListaContatos;
        private Button btnAbrirListaMensagens;
        private Button btnAbrirListaSolicitacoesAmizade;
        private Button btnAbrirEditarPerfil;
        private Button btnAbrirPesquisaContatos;
    }
}