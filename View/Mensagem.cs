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
    public partial class Mensagem : UserControl
    {
        public Mensagem(DateTime dataMsg, String nome, String mensagem)
        {
            InitializeComponent();
            lblDataMsg.Text = dataMsg.ToString();
            lblMensagemNome.Text = nome;
            lblMensagemCorpo.Text = mensagem;
        }

        private void lblMensagemNome_Click(object sender, EventArgs e)
        {

        }

        private void Mensagem_Load(object sender, EventArgs e)
        {

        }
    }
}
