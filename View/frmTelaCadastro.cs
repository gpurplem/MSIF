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
    public partial class frmTelaCadastro : Form
    {
        public frmTelaCadastro()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Boolean haProblema = false;

            String nomeCompleto = txtNomeCompleto.Text;
            String apelido = txtApelido.Text;
            String email = txtEmail.Text;
            String senha1 = txtSenha1.Text;
            String senha2 = txtSenha2.Text;
            String nomeArquivo = btnSelecionarImagem.Text;

            //Tira alertas
            txtNomeCompleto.BackColor = Color.Empty;
            txtEmail.BackColor = Color.Empty;
            txtSenha1.BackColor = Color.Empty;
            txtSenha2.BackColor = Color.Empty;
            txtApelido.BackColor = Color.Empty;

            //Verifica se campo está vazio ou nulo
            if (nomeCompleto.IsNullOrEmpty())
            {
                txtNomeCompleto.BackColor = Color.Plum;
                haProblema = true;
            }
            if (email.IsNullOrEmpty())
            {
                txtEmail.BackColor = Color.Plum;
                haProblema = true;
            }
            if (senha1.IsNullOrEmpty())
            {
                txtSenha1.BackColor = Color.Plum;
                haProblema = true;
            }
            if (senha2.IsNullOrEmpty())
            {
                txtSenha2.BackColor = Color.Plum;
                haProblema = true;
            }
            if (apelido.IsNullOrEmpty())
            {
                txtApelido.BackColor = Color.Plum;
                haProblema = true;
            }

            //Arquivo
            if (nomeArquivo.Equals("Selecionar imagem"))
            {
                nomeArquivo = "6";
            } else
            {
                byte[] imageData = File.ReadAllBytes(fileDialog.FileName);
                ImagemController ic = new ImagemController();
                Imagem img = new Imagem();
                img.ImageData = imageData;
                ic.Create(img);
                nomeArquivo = img.ImagemId.ToString();
            }

            //Senhas
            if (!senha1.Equals(senha2))
            {
                txtSenha1.BackColor = Color.Plum;
                txtSenha2.BackColor = Color.Plum;
                haProblema = true;
            }

            if (!haProblema)
            {
                Usuario usuario = new Usuario();
                usuario.Status = 0;
                usuario.Senha = senha1;
                usuario.Email = email;
                usuario.Apelido = apelido;
                usuario.Nome = nomeCompleto;
                usuario.Url = nomeArquivo;

                //Verificar email repetido
                UsuarioController uc = new UsuarioController();
                if (uc.HaEmailRepetido(usuario))
                {
                    txtEmail.BackColor = Color.Plum;
                }
                else
                {
                    uc.Create(usuario);

                    //Limpar campos
                    //txtNomeCompleto.Text = "";
                    //txtApelido.Text = "";
                    //txtEmail.Text = "";
                    //txtSenha1.Text = "";
                    //txtSenha2.Text = "";
                    //btnSelecionarImagem.Text = "Selecionar imagem";

                    this.Close();
                }
            }

        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                btnSelecionarImagem.Text = fileDialog.SafeFileName;
            }

        }

        private void lblSenha1_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
