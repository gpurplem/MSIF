using MSIF.Controller;
using MSIF.Model;

namespace MSIF.View
{
    public partial class frmAceitarRecurasSolicitacao : Form
    {
        int idUsuarioAdd;
        int idLogado;

        public frmAceitarRecurasSolicitacao(int idUsuarioAdd, int idLogado)
        {
            InitializeComponent();
            this.idUsuarioAdd = idUsuarioAdd;
            this.idLogado = idLogado;
        }

        private void btnSolicitacaoRejeitar_Click_1(object sender, EventArgs e)
        {
            SolicitacaoController sc = new SolicitacaoController();
            sc.DeleteSolicitacao(idUsuarioAdd, idLogado);
            this.Close();
        }

        private void btnSolicitacaoAceitar_Click_1(object sender, EventArgs e)
        {
            Contatos contato = new Contatos();
            contato.Logado = idLogado;
            contato.Contato = idUsuarioAdd;

            ContatosController cc = new ContatosController();
            if (!cc.HaContatoRepetido(contato))
            {
                cc.Salvar(contato);
            }

            SolicitacaoController sc = new SolicitacaoController();
            sc.DeleteSolicitacao(idUsuarioAdd, idLogado);
            this.Close();
        }

    }
}
