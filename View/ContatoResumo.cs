using MSIF.Controller;
using MSIF.Model;
using MSIF.View;

namespace MSIF
{
    public partial class ContatoResumo : UserControl
    {
        Usuario usuario;
        int idLogado;
        int idUsuario;

        public ContatoResumo(String apelido, int logado)
        {
            InitializeComponent();
            lblNomeUsuario.Text = apelido;

            idLogado = logado;

            UsuarioController uc = new UsuarioController();
            MSIF.Model.Usuario usuario = new MSIF.Model.Usuario();
            usuario = uc.GetUsuarioObj(apelido);
            idUsuario = usuario.UsuarioId;

            String idImagem = usuario.Url;

            if (!idImagem.Equals("-1"))
            {
                ImagemController ic = new ImagemController();
                Imagem img = ic.GetImagemObj(int.Parse(idImagem));
                using (MemoryStream stream = new MemoryStream(img.ImageData))
                {
                    pbFotoUsuario.Image = Image.FromStream(stream);
                }
            }            
        }

        private void ContatoResumo_MouseClick(object sender, MouseEventArgs e)
        {
            if (Parent.Name == "flpSolicitacoes")
            {
                frmAceitarRecurasSolicitacao frm = new frmAceitarRecurasSolicitacao(idUsuario, idLogado);

                frm.ShowDialog();
            }
            else if (Parent.Name == "flpContatos")
            {
                frmChat frm = new frmChat(idLogado, idUsuario);

                RecadoController rc = new RecadoController();
                frm.ShowDialog();
            }
        }
    }
}
