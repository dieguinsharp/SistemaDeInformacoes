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

using MaterialSkin;

namespace Save_Data {
    public partial class frmLogin: MaterialSkin.Controls.MaterialForm {
        private Modelo.ModeloLogin cruds;
        private CriptDecript.CripDecript crypt;

        public frmLogin() {
            InitializeComponent();

            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.Orange100,
                TextShade.WHITE
            );
        }
        private void btnCadastro_Click(object sender, EventArgs e) {

            

        }
        private void frmPainel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_Load(object sender, EventArgs e) {
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) {
            if(txtSenha.TextLength >= 8 && txtSenha.TextLength <= 20 && txtEmail.TextLength >= 10 && txtSenha.TextLength <= 40) {
                crypt = new CriptDecript.CripDecript();

                cruds = new Modelo.ModeloLogin();

                cruds.email = txtEmail.Text;
                cruds.senha = crypt.Encrypt(txtSenha.Text, txtSenha.Text);

                bool Logado = cruds.ValidarLogin();

                if(Logado) {
                    MessageBox.Show("Usuario logado com sucesso!");

                    string usuario = cruds.getUsuario();
                    int id = cruds.getId();

                    this.txtEmail.Text = "";
                    this.txtSenha.Text = "";

                    frmPainel painel = new frmPainel(usuario, cruds.email, id);
                    painel.Show();
                    this.Hide();
                } else {
                    lblMessage.Text = "Nome de usuario/senha incorretos.";
                }
            } else {
                lblMessage.Text = "Informe um usuario válido!";
            }
        }

        private void btnCadastro_Click_1(object sender, EventArgs e) {
            frmCriarUsuario createUser = new frmCriarUsuario();
            createUser.Show();
        }
    }
}
