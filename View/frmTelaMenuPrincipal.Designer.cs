﻿namespace MSIF
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
            components = new System.ComponentModel.Container();
            tabControlMenuPrincipal = new TabControl();
            tabPage1 = new TabPage();
            btnContatosAtualizar = new Button();
            flpContatos = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            btnAtualizarSolicitacoes = new Button();
            flpSolicitacoes = new FlowLayoutPanel();
            tabPage4 = new TabPage();
            btnPesquisarAdicionar = new Button();
            flpApelidoPesquisa = new FlowLayoutPanel();
            btnApelidoPesquisa = new Button();
            txtApelidoPesquisa = new TextBox();
            lblApelidoPesquisa = new Label();
            tabPage5 = new TabPage();
            lblNomeUsuarioMeuPerfil = new Label();
            picFotoMeuPerfil = new PictureBox();
            btnSelecionarImagemMeuPerfil = new Button();
            btnSalvarMeuPerfil = new Button();
            txtSenha2MeuPerfil = new TextBox();
            txtSenha1MeuPerfil = new TextBox();
            txtEmailMeuPerfil = new TextBox();
            txtApelidoMeuPerfil = new TextBox();
            lblImagemPerfilMeuPerfil = new Label();
            lblSenha2MeuPerfil = new Label();
            lblSenha1MeuPerfil = new Label();
            lblEmailMeuPerfil = new Label();
            lblApelidoMeuPerfil = new Label();
            ofdMeuPerfil = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControlMenuPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoMeuPerfil).BeginInit();
            SuspendLayout();
            // 
            // tabControlMenuPrincipal
            // 
            tabControlMenuPrincipal.Controls.Add(tabPage1);
            tabControlMenuPrincipal.Controls.Add(tabPage3);
            tabControlMenuPrincipal.Controls.Add(tabPage4);
            tabControlMenuPrincipal.Controls.Add(tabPage5);
            tabControlMenuPrincipal.Location = new Point(1, 1);
            tabControlMenuPrincipal.Name = "tabControlMenuPrincipal";
            tabControlMenuPrincipal.SelectedIndex = 0;
            tabControlMenuPrincipal.Size = new Size(475, 670);
            tabControlMenuPrincipal.TabIndex = 0;
            tabControlMenuPrincipal.Click += tabControlMenuPrincipal_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnContatosAtualizar);
            tabPage1.Controls.Add(flpContatos);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(467, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Contatos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnContatosAtualizar
            // 
            btnContatosAtualizar.Location = new Point(178, 578);
            btnContatosAtualizar.Name = "btnContatosAtualizar";
            btnContatosAtualizar.Size = new Size(112, 34);
            btnContatosAtualizar.TabIndex = 4;
            btnContatosAtualizar.Text = "Atualizar";
            btnContatosAtualizar.UseVisualStyleBackColor = true;
            btnContatosAtualizar.Visible = false;
            btnContatosAtualizar.Click += btnContatosAtualizar_Click;
            // 
            // flpContatos
            // 
            flpContatos.AutoScroll = true;
            flpContatos.FlowDirection = FlowDirection.TopDown;
            flpContatos.Location = new Point(3, 6);
            flpContatos.Name = "flpContatos";
            flpContatos.Size = new Size(458, 566);
            flpContatos.TabIndex = 0;
            flpContatos.WrapContents = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAtualizarSolicitacoes);
            tabPage3.Controls.Add(flpSolicitacoes);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(467, 632);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Solicitações";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarSolicitacoes
            // 
            btnAtualizarSolicitacoes.Location = new Point(179, 572);
            btnAtualizarSolicitacoes.Name = "btnAtualizarSolicitacoes";
            btnAtualizarSolicitacoes.Size = new Size(112, 34);
            btnAtualizarSolicitacoes.TabIndex = 3;
            btnAtualizarSolicitacoes.Text = "Atualizar";
            btnAtualizarSolicitacoes.UseVisualStyleBackColor = true;
            btnAtualizarSolicitacoes.Visible = false;
            btnAtualizarSolicitacoes.Click += btnAtualizarSolicitacoes_Click;
            // 
            // flpSolicitacoes
            // 
            flpSolicitacoes.AutoScroll = true;
            flpSolicitacoes.FlowDirection = FlowDirection.TopDown;
            flpSolicitacoes.Location = new Point(7, 6);
            flpSolicitacoes.Name = "flpSolicitacoes";
            flpSolicitacoes.Size = new Size(451, 560);
            flpSolicitacoes.TabIndex = 0;
            flpSolicitacoes.WrapContents = false;
            flpSolicitacoes.Paint += flpSolicitacoes_Paint;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnPesquisarAdicionar);
            tabPage4.Controls.Add(flpApelidoPesquisa);
            tabPage4.Controls.Add(btnApelidoPesquisa);
            tabPage4.Controls.Add(txtApelidoPesquisa);
            tabPage4.Controls.Add(lblApelidoPesquisa);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(467, 632);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pesquisar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarAdicionar
            // 
            btnPesquisarAdicionar.Location = new Point(353, 578);
            btnPesquisarAdicionar.Name = "btnPesquisarAdicionar";
            btnPesquisarAdicionar.Size = new Size(105, 36);
            btnPesquisarAdicionar.TabIndex = 7;
            btnPesquisarAdicionar.Text = "Adicionar";
            btnPesquisarAdicionar.UseVisualStyleBackColor = true;
            btnPesquisarAdicionar.Click += btnPesquisarAdicionar_Click;
            // 
            // flpApelidoPesquisa
            // 
            flpApelidoPesquisa.AutoScroll = true;
            flpApelidoPesquisa.FlowDirection = FlowDirection.TopDown;
            flpApelidoPesquisa.Location = new Point(7, 48);
            flpApelidoPesquisa.Name = "flpApelidoPesquisa";
            flpApelidoPesquisa.Size = new Size(451, 524);
            flpApelidoPesquisa.TabIndex = 6;
            flpApelidoPesquisa.WrapContents = false;
            flpApelidoPesquisa.Paint += flowLayoutPanel1_Paint;
            // 
            // btnApelidoPesquisa
            // 
            btnApelidoPesquisa.Location = new Point(346, 11);
            btnApelidoPesquisa.Name = "btnApelidoPesquisa";
            btnApelidoPesquisa.Size = new Size(112, 34);
            btnApelidoPesquisa.TabIndex = 5;
            btnApelidoPesquisa.Text = "Pesquisar";
            btnApelidoPesquisa.UseVisualStyleBackColor = true;
            btnApelidoPesquisa.Click += btnApelidoPesquisa_Click;
            // 
            // txtApelidoPesquisa
            // 
            txtApelidoPesquisa.Location = new Point(87, 11);
            txtApelidoPesquisa.Name = "txtApelidoPesquisa";
            txtApelidoPesquisa.Size = new Size(253, 31);
            txtApelidoPesquisa.TabIndex = 4;
            // 
            // lblApelidoPesquisa
            // 
            lblApelidoPesquisa.AutoSize = true;
            lblApelidoPesquisa.Location = new Point(7, 17);
            lblApelidoPesquisa.Name = "lblApelidoPesquisa";
            lblApelidoPesquisa.Size = new Size(74, 25);
            lblApelidoPesquisa.TabIndex = 3;
            lblApelidoPesquisa.Text = "Apelido";
            lblApelidoPesquisa.Click += label1_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lblNomeUsuarioMeuPerfil);
            tabPage5.Controls.Add(picFotoMeuPerfil);
            tabPage5.Controls.Add(btnSelecionarImagemMeuPerfil);
            tabPage5.Controls.Add(btnSalvarMeuPerfil);
            tabPage5.Controls.Add(txtSenha2MeuPerfil);
            tabPage5.Controls.Add(txtSenha1MeuPerfil);
            tabPage5.Controls.Add(txtEmailMeuPerfil);
            tabPage5.Controls.Add(txtApelidoMeuPerfil);
            tabPage5.Controls.Add(lblImagemPerfilMeuPerfil);
            tabPage5.Controls.Add(lblSenha2MeuPerfil);
            tabPage5.Controls.Add(lblSenha1MeuPerfil);
            tabPage5.Controls.Add(lblEmailMeuPerfil);
            tabPage5.Controls.Add(lblApelidoMeuPerfil);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(467, 632);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Meu perfil";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
            // 
            // lblNomeUsuarioMeuPerfil
            // 
            lblNomeUsuarioMeuPerfil.AutoSize = true;
            lblNomeUsuarioMeuPerfil.Location = new Point(136, 225);
            lblNomeUsuarioMeuPerfil.Name = "lblNomeUsuarioMeuPerfil";
            lblNomeUsuarioMeuPerfil.Size = new Size(121, 25);
            lblNomeUsuarioMeuPerfil.TabIndex = 35;
            lblNomeUsuarioMeuPerfil.Text = "NomeUsuario";
            // 
            // picFotoMeuPerfil
            // 
            picFotoMeuPerfil.Location = new Point(136, 23);
            picFotoMeuPerfil.Name = "picFotoMeuPerfil";
            picFotoMeuPerfil.Size = new Size(212, 185);
            picFotoMeuPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoMeuPerfil.TabIndex = 34;
            picFotoMeuPerfil.TabStop = false;
            picFotoMeuPerfil.Click += pictureBox1_Click;
            // 
            // btnSelecionarImagemMeuPerfil
            // 
            btnSelecionarImagemMeuPerfil.Location = new Point(185, 422);
            btnSelecionarImagemMeuPerfil.Name = "btnSelecionarImagemMeuPerfil";
            btnSelecionarImagemMeuPerfil.Size = new Size(179, 34);
            btnSelecionarImagemMeuPerfil.TabIndex = 33;
            btnSelecionarImagemMeuPerfil.Text = "Selecionar imagem";
            btnSelecionarImagemMeuPerfil.UseVisualStyleBackColor = true;
            btnSelecionarImagemMeuPerfil.Click += btnSelecionarImagemMeuPerfil_Click;
            // 
            // btnSalvarMeuPerfil
            // 
            btnSalvarMeuPerfil.Location = new Point(61, 464);
            btnSalvarMeuPerfil.Name = "btnSalvarMeuPerfil";
            btnSalvarMeuPerfil.Size = new Size(163, 34);
            btnSalvarMeuPerfil.TabIndex = 32;
            btnSalvarMeuPerfil.Text = "Salvar mudanças";
            btnSalvarMeuPerfil.UseVisualStyleBackColor = true;
            btnSalvarMeuPerfil.Click += btnSalvarMeuPerfil_Click;
            // 
            // txtSenha2MeuPerfil
            // 
            txtSenha2MeuPerfil.Location = new Point(185, 382);
            txtSenha2MeuPerfil.Name = "txtSenha2MeuPerfil";
            txtSenha2MeuPerfil.Size = new Size(179, 31);
            txtSenha2MeuPerfil.TabIndex = 31;
            // 
            // txtSenha1MeuPerfil
            // 
            txtSenha1MeuPerfil.Location = new Point(185, 345);
            txtSenha1MeuPerfil.Name = "txtSenha1MeuPerfil";
            txtSenha1MeuPerfil.Size = new Size(179, 31);
            txtSenha1MeuPerfil.TabIndex = 30;
            // 
            // txtEmailMeuPerfil
            // 
            txtEmailMeuPerfil.Enabled = false;
            txtEmailMeuPerfil.Location = new Point(185, 308);
            txtEmailMeuPerfil.Name = "txtEmailMeuPerfil";
            txtEmailMeuPerfil.Size = new Size(179, 31);
            txtEmailMeuPerfil.TabIndex = 29;
            // 
            // txtApelidoMeuPerfil
            // 
            txtApelidoMeuPerfil.Location = new Point(185, 271);
            txtApelidoMeuPerfil.Name = "txtApelidoMeuPerfil";
            txtApelidoMeuPerfil.Size = new Size(179, 31);
            txtApelidoMeuPerfil.TabIndex = 28;
            txtApelidoMeuPerfil.TextChanged += txtApelidoMeuPerfil_TextChanged;
            // 
            // lblImagemPerfilMeuPerfil
            // 
            lblImagemPerfilMeuPerfil.AutoSize = true;
            lblImagemPerfilMeuPerfil.Location = new Point(56, 422);
            lblImagemPerfilMeuPerfil.Name = "lblImagemPerfilMeuPerfil";
            lblImagemPerfilMeuPerfil.Size = new Size(123, 25);
            lblImagemPerfilMeuPerfil.TabIndex = 27;
            lblImagemPerfilMeuPerfil.Text = "Imagem perfil";
            // 
            // lblSenha2MeuPerfil
            // 
            lblSenha2MeuPerfil.AutoSize = true;
            lblSenha2MeuPerfil.Location = new Point(61, 388);
            lblSenha2MeuPerfil.Name = "lblSenha2MeuPerfil";
            lblSenha2MeuPerfil.Size = new Size(118, 25);
            lblSenha2MeuPerfil.TabIndex = 26;
            lblSenha2MeuPerfil.Text = "Repetir senha";
            // 
            // lblSenha1MeuPerfil
            // 
            lblSenha1MeuPerfil.AutoSize = true;
            lblSenha1MeuPerfil.Location = new Point(74, 345);
            lblSenha1MeuPerfil.Name = "lblSenha1MeuPerfil";
            lblSenha1MeuPerfil.Size = new Size(105, 25);
            lblSenha1MeuPerfil.TabIndex = 25;
            lblSenha1MeuPerfil.Text = "Nova senha";
            // 
            // lblEmailMeuPerfil
            // 
            lblEmailMeuPerfil.AutoSize = true;
            lblEmailMeuPerfil.Location = new Point(118, 308);
            lblEmailMeuPerfil.Name = "lblEmailMeuPerfil";
            lblEmailMeuPerfil.Size = new Size(61, 25);
            lblEmailMeuPerfil.TabIndex = 24;
            lblEmailMeuPerfil.Text = "E-mail";
            // 
            // lblApelidoMeuPerfil
            // 
            lblApelidoMeuPerfil.AutoSize = true;
            lblApelidoMeuPerfil.Location = new Point(105, 271);
            lblApelidoMeuPerfil.Name = "lblApelidoMeuPerfil";
            lblApelidoMeuPerfil.Size = new Size(74, 25);
            lblApelidoMeuPerfil.TabIndex = 23;
            lblApelidoMeuPerfil.Text = "Apelido";
            // 
            // ofdMeuPerfil
            // 
            ofdMeuPerfil.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmTelaMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 673);
            Controls.Add(tabControlMenuPrincipal);
            Name = "frmTelaMenuPrincipal";
            Text = "MenuPrincipal";
            Load += frmTelaMenuPrincipal_Load;
            tabControlMenuPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoMeuPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMenuPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btnSelecionarImagemMeuPerfil;
        private Button btnSalvarMeuPerfil;
        private TextBox txtSenha2MeuPerfil;
        private TextBox txtSenha1MeuPerfil;
        private TextBox txtEmailMeuPerfil;
        private TextBox txtApelidoMeuPerfil;
        private Label lblImagemPerfilMeuPerfil;
        private Label lblSenha2MeuPerfil;
        private Label lblSenha1MeuPerfil;
        private Label lblEmailMeuPerfil;
        private Label lblApelidoMeuPerfil;
        private Label lblNomeUsuarioMeuPerfil;
        private PictureBox picFotoMeuPerfil;
        private FlowLayoutPanel flpApelidoPesquisa;
        private Button btnApelidoPesquisa;
        private TextBox txtApelidoPesquisa;
        private Label lblApelidoPesquisa;
        private FlowLayoutPanel flpSolicitacoes;
        private FlowLayoutPanel flpContatos;
        private Button btnPesquisarAdicionar;
        private OpenFileDialog ofdMeuPerfil;
        private Button btnAtualizarSolicitacoes;
        private Button btnContatosAtualizar;
        private System.Windows.Forms.Timer timer1;
    }
}