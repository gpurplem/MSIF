using Microsoft.IdentityModel.Tokens;
using MSIF.Controller;
using MSIF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIF
{
    public partial class frmTelaMenuPrincipal : Form
    {
        private int idLogado;
        private Usuario usuarioLogado;
        private UsuarioController usuarioController;
        Usuario usuarioPesquisado;
        public frmTelaMenuPrincipal(int IdLogado)
        {
            this.idLogado = IdLogado;
            InitializeComponent();

            usuarioController = new UsuarioController();
            usuarioLogado = usuarioController.GetUsuarioObj(this.idLogado);

            txtApelidoMeuPerfil.Text = usuarioLogado.Apelido;
            txtEmailMeuPerfil.Text = usuarioLogado.Email;
            lblNomeUsuarioMeuPerfil.Text = usuarioLogado.Nome;

            String idImagem = usuarioLogado.Url;
            ImagemController ic = new ImagemController();
            Imagem img = ic.GetImagemObj(int.Parse(idImagem));
            using (MemoryStream stream = new MemoryStream(img.ImageData))
            {
                picFotoMeuPerfil.Image = Image.FromStream(stream);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAceitarSolicitacoes_Click(object sender, EventArgs e)
        {
            //ContatoResumo contatoResumo = new ContatoResumo();
            //contatoResumo.Show();
            //flpSolicitacoes.Controls.Add(contatoResumo);
        }

        private void btnApelidoPesquisa_Click(object sender, EventArgs e)
        {
            this.flpApelidoPesquisa.Controls.Clear();

            usuarioPesquisado = usuarioController.GetUsuarioObj(txtApelidoPesquisa.Text);

            if (usuarioPesquisado != null)
            {
                ContatoResumo contatoResumo = new ContatoResumo(usuarioPesquisado.Apelido, idLogado);
                contatoResumo.Show();
                flpApelidoPesquisa.Controls.Add(contatoResumo);
            }
        }

        private void btnAbrirMensagem_Click(object sender, EventArgs e)
        {
            //ContatoResumo contatoResumo = new ContatoResumo();
            //contatoResumo.Show();
            //flpMensagem.Controls.Add(contatoResumo);
        }

        private void btnContatosConversar_Click(object sender, EventArgs e)
        {
            //ContatoResumo contatoResumo = new ContatoResumo();
            //contatoResumo.Show();
            //flpContatosOnline.Controls.Add(contatoResumo);
        }

        private void btnContatosAbrirPerfil_Click(object sender, EventArgs e)
        {
            //ContatoResumo contatoResumo = new ContatoResumo();
            //contatoResumo.Show();
            //flpContatosOffline.Controls.Add(contatoResumo);
        }

        private void tabControlMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarMeuPerfil_Click(object sender, EventArgs e)
        {
            String apelidoOriginal = usuarioLogado.Apelido;
            String senhaOriginal = usuarioLogado.Senha;

            String apelidoNovo = txtApelidoMeuPerfil.Text;
            String senhaNova1 = txtSenha1MeuPerfil.Text;
            String senhaNova2 = txtSenha2MeuPerfil.Text;

            txtApelidoMeuPerfil.BackColor = Color.Empty;
            txtSenha1MeuPerfil.BackColor = Color.Empty;
            txtSenha2MeuPerfil.BackColor = Color.Empty;

            Boolean haProblema = false;

            //Apelido
            if (apelidoNovo.IsNullOrEmpty())
            {
                txtApelidoMeuPerfil.BackColor = Color.Plum;
                haProblema = true;
            }
            else if (!apelidoOriginal.Equals(apelidoNovo) && usuarioController.HaApelidoRepetido(apelidoNovo))
            {
                txtApelidoMeuPerfil.BackColor = Color.Plum;
                haProblema = true;
            }

            //Senhas
            if (!senhaNova1.Equals(senhaNova2))
            {
                txtSenha1MeuPerfil.BackColor = Color.Plum;
                txtSenha2MeuPerfil.BackColor = Color.Plum;
                haProblema = true;
            }

            //Arquivo
            if (!btnSelecionarImagemMeuPerfil.Text.Equals("Selecionar imagem"))
            {
                int idImagemOriginal = int.Parse(usuarioLogado.Url);

                byte[] imageData = File.ReadAllBytes(ofdMeuPerfil.FileName);
                ImagemController ic = new ImagemController();


                Imagem img = new Imagem();
                img.ImageData = imageData;
                ic.Create(img);
                String nomeArquivo = img.ImagemId.ToString();

                //Atualizar URL de usuário
                usuarioController.UpdateUsuarioUrl(usuarioLogado.UsuarioId, nomeArquivo);
            }

            if (!haProblema)
            {
                if (!apelidoOriginal.Equals(apelidoNovo))
                {
                    usuarioController.UpdateUsuarioApelido(usuarioLogado.UsuarioId, apelidoNovo);
                }

                if (!senhaNova1.IsNullOrEmpty())
                {
                    usuarioController.UpdateUsuarioSenha(usuarioLogado.UsuarioId, senhaNova1);
                }
            }

        }

        private void btnSelecionarImagemMeuPerfil_Click(object sender, EventArgs e)
        {
            if (ofdMeuPerfil.ShowDialog() == DialogResult.OK)
            {
                btnSelecionarImagemMeuPerfil.Text = ofdMeuPerfil.SafeFileName;
            }
        }

        private void txtApelidoMeuPerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarAdicionar_Click(object sender, EventArgs e)
        {
            if (usuarioLogado != null)
            {
                ContatosController cc = new ContatosController();
                Contatos contatos = new Contatos();
                contatos.Logado = idLogado;
                contatos.Contato = usuarioPesquisado.UsuarioId;

                SolicitacaoController sc = new SolicitacaoController();
                Solicitacao solicitacao = new Solicitacao();
                solicitacao.Remetente = contatos.Logado;
                solicitacao.Destinatario = contatos.Contato;
                solicitacao.Status = 1;

                if (!cc.HaContatoRepetido(contatos))
                {
                    sc.Salvar(solicitacao);
                }
            }
        }

        private void btnAtualizarSolicitacoes_Click(object sender, EventArgs e)
        {
            this.flpSolicitacoes.Controls.Clear();

            UsuarioController uc = new UsuarioController();

            SolicitacaoController sc = new SolicitacaoController();
            List<Solicitacao> ls = sc.GetSolicitacoesObjs(idLogado);
            foreach (Solicitacao solicitacao in ls)
            {
                int idRemetente = solicitacao.Remetente;

                ContatoResumo contatoResumo = new ContatoResumo(uc.GetUsuarioObj(idRemetente).Apelido, idLogado);
                contatoResumo.Show();
                flpSolicitacoes.Controls.Add(contatoResumo);
            }

        }

        private void flpSolicitacoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnContatosAtualizar_Click(object sender, EventArgs e)
        {
            this.flpContatos.Controls.Clear();

            UsuarioController uc = new UsuarioController();
            ContatosController cc = new ContatosController();

            List<Contatos> ls = cc.GetContatosObjs(idLogado);

            foreach (Contatos contato in ls)
            {
                ContatoResumo contatoResumo = new ContatoResumo(uc.GetUsuarioObj(contato.Contato).Apelido, idLogado);
                contatoResumo.Show();
                flpContatos.Controls.Add(contatoResumo);
            }
        }
    }
}
