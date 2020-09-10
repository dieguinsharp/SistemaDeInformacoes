using Save_Data.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Data {
    public partial class frmLogin: Form {
        private Modelo.ModeloLogin cruds;
        private CriptDecript.CripDecript crypt;

        public frmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {

            if (txtSenha.TextLength >= 8 && txtSenha.TextLength <= 20 && txtEmail.TextLength >= 10 && txtSenha.TextLength <= 40) {
                crypt = new CriptDecript.CripDecript();

                cruds = new Modelo.ModeloLogin();

                cruds.email = txtEmail.Text;
                cruds.senha = crypt.Encrypt(txtSenha.Text, txtSenha.Text);

                bool Logado = cruds.ValidarLogin();

                if(Logado) {
                    MessageBox.Show("Usuario logado com sucesso!");

                    string usuario = cruds.getUsuario();
                    int id = cruds.getId();

                    frmPainel painel = new frmPainel(usuario, cruds.email, id);
                    painel.Show();
                    this.Hide();
                } else {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Nome de usuario/senha incorretos.";
                }
            }else {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Informe um usuario válido!";
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e) {

            frmCriarUsuario createUser = new frmCriarUsuario();
            createUser.Show();

        }

        private void frmLogin_Load(object sender, EventArgs e) {
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
