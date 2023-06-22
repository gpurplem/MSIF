using Microsoft.IdentityModel.Tokens;
using MSIF.Controller;
using MSIF.View;

namespace MSIF
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmTelaCadastro frm = new frmTelaCadastro();
            frm.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Boolean haProblema = false;

            String email = txtEmailLogar.Text;
            String senha = txtSenhaLogar.Text;

            //Tira alertas
            txtEmailLogar.BackColor = Color.Empty;
            txtSenhaLogar.BackColor = Color.Empty;

            //Verifica se campo está vazio ou nulo
            if (email.IsNullOrEmpty())
            {
                txtEmailLogar.BackColor = Color.Plum;
                haProblema = true;
            }
            if (senha.IsNullOrEmpty())
            {
                txtSenhaLogar.BackColor = Color.Plum;
                haProblema = true;
            }

            if (!haProblema)
            {
                int idLogado = -1;

                UsuarioController uc = new UsuarioController();
                idLogado = uc.GetIdUsuario(email, senha);

                if (idLogado != -1)
                {
                    frmTelaMenuPrincipal frmTelaMenuPrincipal = new frmTelaMenuPrincipal(idLogado);

                    this.Hide();
                    frmTelaMenuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    txtEmailLogar.BackColor = Color.Plum;
                    txtSenhaLogar.BackColor = Color.Plum;
                }
            }
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha frm = new frmRecuperarSenha();
            frm.ShowDialog();
        }
    }
}