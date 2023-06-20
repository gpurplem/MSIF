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
        public frmTelaMenuPrincipal()
        {
            InitializeComponent();
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
            ContatoResumo contatoResumo = new ContatoResumo();
            contatoResumo.Show();
            flpSolicitacoes.Controls.Add(contatoResumo);
        }

        private void btnApelidoPesquisa_Click(object sender, EventArgs e)
        {
            ContatoResumo contatoResumo = new ContatoResumo();
            contatoResumo.Show();
            flpApelidoPesquisa.Controls.Add(contatoResumo);
        }

        private void btnAbrirMensagem_Click(object sender, EventArgs e)
        {
            ContatoResumo contatoResumo = new ContatoResumo();
            contatoResumo.Show();
            //flpMensagem.Controls.Add(contatoResumo);
        }

        private void btnContatosConversar_Click(object sender, EventArgs e)
        {
            ContatoResumo contatoResumo = new ContatoResumo();
            contatoResumo.Show();
            //flpContatosOnline.Controls.Add(contatoResumo);
        }

        private void btnContatosAbrirPerfil_Click(object sender, EventArgs e)
        {
            ContatoResumo contatoResumo = new ContatoResumo();
            contatoResumo.Show();
            //flpContatosOffline.Controls.Add(contatoResumo);
        }

        private void tabPage5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEmailMeuPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblApelidoMeuPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha1MeuPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha2MeuPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
