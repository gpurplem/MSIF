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
    public partial class frmChat : Form
    {
        int idLogado;
        int idDestinatario;

        public frmChat(int idLogado, int idDestinatario)
        {
            InitializeComponent();
            this.idLogado = idLogado;
            this.idDestinatario = idDestinatario;

            CarregarMensagens();
        }

        private void CarregarMensagens()
        {
            this.flpMensagem.Controls.Clear();

            UsuarioController uc = new UsuarioController();
            RecadoController rc = new RecadoController();
            List<Recado> ls = rc.GetRecadosObjs(idLogado, idDestinatario);

            foreach (Recado recado in ls)
            {
                String nomeRemetenteAtual = uc.GetUsuarioObj(recado.Remetente).Nome;

                Mensagem mensagem = new Mensagem(recado.Dataenvio, nomeRemetenteAtual, recado.Texto);

                mensagem.Show();
                flpMensagem.Controls.Add(mensagem);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!txtMsg.Text.IsNullOrEmpty())
            {
                //salvar msg no banco de dados
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
