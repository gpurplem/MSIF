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
        int qtdInicialMensagens;
        UsuarioController usuarioController;
        RecadoController recadoController;

        public frmChat(int idLogado, int idDestinatario)
        {
            InitializeComponent();
            this.idLogado = idLogado;
            this.idDestinatario = idDestinatario;
            this.usuarioController = new UsuarioController();
            this.recadoController = new RecadoController();

            this.qtdInicialMensagens = recadoController.GetNumeroMensagens(idLogado);

            CarregarMensagens();
        }

        private void CarregarMensagens()
        {
            recadoController.MarcarRecadosLidos(idLogado, idDestinatario);

            this.flpMensagem.Controls.Clear();
            List<Recado> ls = recadoController.GetRecadosObjs(idLogado, idDestinatario);

            if (ls != null)
            {
                foreach (Recado recado in ls)
                {
                    String nomeRemetenteAtual = usuarioController.GetUsuarioObj(recado.Remetente).Nome;

                    Mensagem mensagem = new Mensagem(recado.Dataenvio, nomeRemetenteAtual, recado.Texto);

                    if (recado.Status == 0)
                    {
                        mensagem.BackColor = Color.LightCoral;
                    }

                    mensagem.Show();
                    flpMensagem.Controls.Add(mensagem);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!txtMsg.Text.IsNullOrEmpty())
            {
                RecadoController rc = new RecadoController();
                rc.Salvar(item: new Recado()
                {
                    Remetente = idLogado,
                    Destinatario = idDestinatario,
                    Texto = txtMsg.Text,
                    Dataenvio = DateTime.Now
                });

                txtMsg.Text = "";
                CarregarMensagens();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flpMensagem_Paint(object sender, PaintEventArgs e)
        {

        }

        private Boolean verificaNovasMensagens()
        {
            if (qtdInicialMensagens != recadoController.GetNumeroMensagens(idLogado))
            {
                //CarregarMensagens();
                qtdInicialMensagens = recadoController.GetNumeroMensagens(idLogado);
                return true;
            }

            return false;
        }

        private void timerMensagens_Tick(object sender, EventArgs e)
        {
            if (verificaNovasMensagens())
            {
                CarregarMensagens();
            }
        }
    }
}
