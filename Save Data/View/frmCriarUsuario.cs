using Save_Data.Modelo;
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
    public partial class frmCriarUsuario: MaterialSkin.Controls.MaterialForm {

        private Modelo.ModeloLogin cruds;
        private CriptDecript.CripDecript cript;

        public frmCriarUsuario() {
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

        private void button1_Click(object sender, EventArgs e) {
        }

        // MENSAGEM DE AVISO POSITIVO.

        public void verde(string message) {
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = message;
        }

        // MENSAGEM DE AVISO DE ERRO.

        public void vermelho(string message) {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = message;
        }

        private void frmCriarUsuario_Load(object sender, EventArgs e) {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.TextLength >= 10)
            {
                if (txtEmail.TextLength <= 40)
                {
                    if (txtSenha.TextLength >= 8)
                    {
                        if (txtSenha.TextLength <= 20)
                        {
                            if (txtUsuario.TextLength >= 5)
                            {
                                if (txtUsuario.TextLength <= 25)
                                {
                                    cript = new CriptDecript.CripDecript();
                                    cruds = new Modelo.ModeloLogin();

                                    cruds.email = txtEmail.Text;
                                    cruds.senha = cript.Encrypt(txtSenha.Text, txtSenha.Text);
                                    cruds.usuario = txtUsuario.Text;

                                    bool criado = cruds.RegistrarUsuario();
                                    if (criado)
                                    {
                                        MessageBox.Show("Usuario criado com sucesso!");
                                        this.Hide();
                                    }
                                    else
                                    {
                                        vermelho("O email/usuario já está em uso!");
                                    }
                                }
                                else
                                {
                                    vermelho("O nome de Usuario não deve ultrapassar 25 caracteres.");
                                }
                            }
                            else
                            {
                                vermelho("O nome de usuario deve ter no minimo 5 carcteres.");
                            }
                        }
                        else
                        {
                            vermelho("A senha não deve ultrapassar 20 caracteres.");
                        }
                    }
                    else
                    {
                        vermelho("A senha deve ter no minimo 8 caracteres.");
                    }
                }
                else
                {
                    vermelho("O Email não deve ultrapassar 40 caracteres.");
                }
            }
            else
            {
                vermelho("O Email deve ter no minimo 10 caracteres.");
            }
        }
    }
}
