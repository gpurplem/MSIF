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
    public partial class ContatoResumo : UserControl
    {
        public ContatoResumo(String apelido)
        {
            InitializeComponent();
            lblNomeUsuario.Text = apelido;

            UsuarioController uc = new UsuarioController();
            MSIF.Model.Usuario usuario = new MSIF.Model.Usuario();
            usuario = uc.GetUsuarioObj(apelido);

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
    }
}
