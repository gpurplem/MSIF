using Microsoft.IdentityModel.Tokens;
using MSIF.Controller;
using MSIF.Model;

namespace MSIF
{
    public partial class frmTelaMenuPrincipal : Form
    {
        private int idLogado;
        private Usuario usuarioLogado;
        private UsuarioController usuarioController;
        private Usuario usuarioPesquisado;
        private SolicitacaoController solicitacaoController;
        private ContatosController contatosController;
        private RecadoController recadoController;
        int qtdInicialSolicitacoes;
        int qtdInicialContatos;

        public frmTelaMenuPrincipal(int IdLogado)
        {
            this.idLogado = IdLogado;
            InitializeComponent();

            usuarioController = new UsuarioController();
            solicitacaoController = new SolicitacaoController();
            contatosController = new ContatosController();
            usuarioLogado = usuarioController.GetUsuarioObj(this.idLogado);
            recadoController = new RecadoController();
            qtdInicialSolicitacoes = solicitacaoController.GetNumeroSolicitacoes(IdLogado);
            qtdInicialContatos = contatosController.GetNumeroContatos(IdLogado);

            atualizarCampos(idLogado);
            atualizarSolicitacoes();
            atualizarContatos();
        }

        public void atualizarCampos(int IdLogado)
        {
            txtApelidoMeuPerfil.Text = usuarioLogado.Apelido;
            txtEmailMeuPerfil.Text = usuarioLogado.Email;
            lblNomeUsuarioMeuPerfil.Text = usuarioLogado.Nome;

            String idImagem = usuarioLogado.Url;

            if (!idImagem.Equals("-1"))
            {
                ImagemController ic = new ImagemController();
                Imagem img = ic.GetImagemObj(int.Parse(idImagem));
                using (MemoryStream stream = new MemoryStream(img.ImageData))
                {
                    picFotoMeuPerfil.Image = Image.FromStream(stream);
                }
            }
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

            atualizarCampos(idLogado);
        }

        private void btnSelecionarImagemMeuPerfil_Click(object sender, EventArgs e)
        {
            if (ofdMeuPerfil.ShowDialog() == DialogResult.OK)
            {
                btnSelecionarImagemMeuPerfil.Text = ofdMeuPerfil.SafeFileName;
            }
        }

        private void btnPesquisarAdicionar_Click(object sender, EventArgs e)
        {
            if (usuarioLogado != null && usuarioPesquisado != null)
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

                Boolean haContatoRepetido = cc.HaContatoRepetido(contatos);
                Boolean haSolicitacaoRepetida = sc.HaSolicitacaoRepetida(solicitacao);

                if (!haContatoRepetido && !haSolicitacaoRepetida)
                {
                    sc.Salvar(solicitacao);
                    lblRetornoSolicitacao.Text = "Solicitação enviada com sucesso!";
                    lblRetornoSolicitacao.ForeColor = Color.Green;
                } else
                {
                    lblRetornoSolicitacao.Text = "Solicitação já enviada!";
                    lblRetornoSolicitacao.ForeColor = Color.Red;
                }
            } else
            {
                lblRetornoSolicitacao.Text = "Usuário não encontrado!";
                lblRetornoSolicitacao.ForeColor = Color.Red;
            }
        }

        public void btnAtualizarSolicitacoes_Click(object sender, EventArgs e)
        {
            atualizarSolicitacoes();
        }

        public void atualizarSolicitacoes()
        {
            this.flpSolicitacoes.Controls.Clear();

            List<Solicitacao> ls = solicitacaoController.GetSolicitacoesObjs(idLogado);

            if (ls != null)
            {
                foreach (Solicitacao solicitacao in ls)
                {
                    int idRemetente = solicitacao.Remetente;

                    ContatoResumo contatoResumo = new ContatoResumo(usuarioController.GetUsuarioObj(idRemetente).Apelido, idLogado);
                    contatoResumo.Show();
                    flpSolicitacoes.Controls.Add(contatoResumo);
                }
            }
        }

        private void btnContatosAtualizar_Click(object sender, EventArgs e)
        {
            atualizarContatos();
        }

        public void atualizarContatos()
        {
            this.flpContatos.Controls.Clear();

            List<Contatos> ls = contatosController.GetContatosObjs(idLogado);

            if (ls != null)
            {
                foreach (Contatos contato in ls)
                {
                    ContatoResumo contatoResumo = new ContatoResumo(usuarioController.GetUsuarioObj(contato.Contato).Apelido, idLogado);

                    if (haNovasMensagens(contato.Contato))
                    {
                        contatoResumo.BackColor = Color.LightGreen;
                    }

                    contatoResumo.Show();
                    flpContatos.Controls.Add(contatoResumo);
                }
            }
        }

        public Boolean haNovasMensagens(int RemetenteId)
        {
            Boolean haNovasMensagens = false;

            List<Recado> recados = recadoController.GetRecadosObjsParaLogado(idLogado);

            if (recados != null)
            {
                foreach (Recado recado in recados)
                {
                    if (recado.Remetente == RemetenteId && recado.Status == 0)
                    {
                        haNovasMensagens = true;
                        return haNovasMensagens;
                    }
                }
            }

            return haNovasMensagens;
        }

        public Boolean haNovasMensagensParaLogado()
        {
            Boolean haNovasMensagens = false;

            List<Recado> recados = recadoController.GetRecadosObjsParaLogado(idLogado);

            if (recados != null)
            {
                foreach (Recado recado in recados)
                {
                    if (recado.Destinatario == idLogado && recado.Status == 0)
                    {
                        haNovasMensagens = true;
                        return haNovasMensagens;
                    }
                }
            }

            return haNovasMensagens;
        }

        private Boolean verificaNovasSolicitacoes()
        {
            if (qtdInicialSolicitacoes != solicitacaoController.GetNumeroSolicitacoes(idLogado))
            {
                qtdInicialSolicitacoes = solicitacaoController.GetNumeroSolicitacoes(idLogado);
                return true;
            }

            return false;
        }

        private Boolean verificaNovosContatos()
        {
            if (qtdInicialContatos != contatosController.GetNumeroContatos(idLogado))
            {
                qtdInicialContatos = contatosController.GetNumeroContatos(idLogado);
                return true;
            }

            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (verificaNovasSolicitacoes())
            {
                atualizarSolicitacoes();

            }

            if (verificaNovosContatos())
            {
                atualizarContatos();
            }
        }

        private void timerContatos_Tick(object sender, EventArgs e)
        {
            atualizarContatos();
            lblRetornoSolicitacao.Text = "";
        }
    }
}
