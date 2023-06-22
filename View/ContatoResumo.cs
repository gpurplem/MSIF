using MSIF.Controller;
using MSIF.Model;
using MSIF.View;
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
            ImagemController ic = new ImagemController();
            Imagem img = ic.GetImagemObj(int.Parse(idImagem));
            using (MemoryStream stream = new MemoryStream(img.ImageData))
            {
                pbFotoUsuario.Image = Image.FromStream(stream);
            }
        }

        private void ContatoResumo_Load(object sender, EventArgs e)
        {

        }

        private void lblNomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                rc.MarcarRecadosLidos(idUsuario, idLogado);
                frm.ShowDialog();
            }
            else
            {

            }

        }

    }
}
