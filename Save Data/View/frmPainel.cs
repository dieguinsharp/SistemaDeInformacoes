using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Save_Data.Validador;

namespace Save_Data {
    public partial class frmPainel: Form {

        private string _senhaAES;

        private bool deuCerto;

        private int _Myid, linha;

        private Conexao.ConexaoSTRING conexao;

        public frmPainel(string usuario, string email, int id) {
            InitializeComponent();

            this._Myid = id;

            lblEmail.Text = email;
            lblUsuarioLogado.Text = usuario;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Conectado";
        }

        private void frmPainel_Load(object sender, EventArgs e) {
                CarregarDados();    
        }

        //METODOS USADOS

        // CARREGAR OS DADOS SELECIONADOS NOS TEXTBOX DA ESQUERDA.
        public void CarregarNasTextBox() {
            DataGridViewRow linha = dtvDados.CurrentRow;
            txtEmail.Text = linha.Cells[1].Value.ToString();
            txtSenha.Text = linha.Cells[2].Value.ToString();
            txtSite.Text = linha.Cells[3].Value.ToString();
            txtCelular.Text = linha.Cells[4].Value.ToString();
            txtAnotacoes.Text = linha.Cells[5].Value.ToString();
        }

        // CARREGAR OS DADOS DO BANCO DE DADOS.

        public void CarregarDados() {
            conexao = new Conexao.ConexaoSTRING();

            dtvDados.DataSource = null;
            dtvDados.Rows.Clear();
            dtvDados.Refresh();

            string conexaoString = conexao.getConnectionString();
            string query = "SELECT d.id, d.email, d.senha, d.site, d.celular, d.anotacoes FROM usuarios as u join dados as d ON d.vinculo = u.id where d.vinculo =" + this._Myid;

            using(MySqlConnection conect = new MySqlConnection(conexaoString)) {
                using(MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conect)) {
                    try {
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);

                        for(int i = 0;i < dataTable.Rows.Count;i++) {

                            dtvDados.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
                        }

                        verde("Dados carregados com sucesso.");
                    } catch(Exception ex) {

                        vermelho("Ouve um erro ao carregar os dados.");
                        MessageBox.Show("Error" + ex);
                    }
                }
            }
        }

        // MENSAGEM DE AVISO POSITIVO.

        public void verde(string message) {
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = message;
        }

        // MENSAGEM DE AVISO DE ERRO.

        public void vermelho(string message) {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = message;
        }

        // CLEAR TXTs

        public void ClearTXT() {
            txtAnotacoes.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtSite.Text = "";
        }

        // ATUALIZAR LINHAS DA DATAGRID VIEW.

        public void AtualizarLinha(int linha) {

            Modelo.Modelo modelo = new Modelo.Modelo();

            modelo.email = txtEmail.Text;
            modelo.senha = txtSenha.Text;
            modelo.site = txtSite.Text;
            modelo.celular = txtCelular.Text;
            modelo.anotacoes = txtAnotacoes.Text;
            modelo.id = Convert.ToInt32(dtvDados[0, linha].Value);

            this.deuCerto = modelo.Atualizar();

            if(this.deuCerto) {

                CarregarDados();
                verde("Dados atualizados com sucesso!");
                ClearTXT();

            } else {
                vermelho("Ouve um erro ao atualizar os dados.");
            }
        }

        // METODOS DE BOTÕES

        // BOTÃO DE CARREGAR NOVAMENTE OS DADOS NA DATAGRID.

        private void btnCarregarNovamente_Click(object sender, EventArgs e) {
            CarregarDados();
            ClearTXT();
        }

        // BOTÃO DE ATUALIZAR A LINHA SELECIONADA.

        private void button2_Click(object sender, EventArgs e) {
            try {
                this.linha = dtvDados.CurrentRow.Index;
                AtualizarLinha(this.linha);
            } catch(NullReferenceException) {
                MessageBox.Show("Selecione uma linha para atualizar!", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        // INSERIR DADOS NA DATAGRID/BANCO.

        private void button3_Click(object sender, EventArgs e) {

            if(txtAnotacoes.Text != "" && txtCelular.Text != "" && txtEmail.Text != "" && txtSenha.Text != "") {
                Modelo.Modelo modelo = new Modelo.Modelo();
                modelo.email = txtEmail.Text;
                modelo.senha = txtSenha.Text;
                modelo.site = txtSite.Text;
                modelo.celular = txtCelular.Text;
                modelo.anotacoes = txtAnotacoes.Text;
                modelo.id = this._Myid;

                this.deuCerto = modelo.Inserir();

                if(deuCerto) {

                    CarregarDados();
                    verde("Dados adicionados com sucesso!");
                    ClearTXT();

                } else {
                    vermelho("Ouve um erro ao adicionar os dados.");
                }
            }else {
                MessageBox.Show("Os dados devem conter pelo menos 1 caractere.");
            } 
        }

        // PEGANDO A COLUNA DOS BOTÕES DE CRIPTOGRAFAR/DECRIPTOGRAFAR
        // VERIFICANDO SE ELAS FORAM CLICK
        // PEGANDO O INDEX DA LINHA E CRIPTOGRAFANDO

        private void dtvDados_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == 6) {

                this._senhaAES = txtSenhaAES.Text;

                if (this._senhaAES.Length >= 8) {

                    int linha2 = dtvDados.CurrentRow.Index;
                    DataGridViewRow linha = dtvDados.CurrentRow;
                    CriptDecript.CripDecript cripto = new CriptDecript.CripDecript();

                    try {

                        linha.Cells[1].Value = cripto.Encrypt(this._senhaAES, linha.Cells[1].Value.ToString());
                        linha.Cells[2].Value = cripto.Encrypt(this._senhaAES, linha.Cells[2].Value.ToString());
                        linha.Cells[3].Value = cripto.Encrypt(this._senhaAES, linha.Cells[3].Value.ToString());
                        linha.Cells[4].Value = cripto.Encrypt(this._senhaAES, linha.Cells[4].Value.ToString());
                        linha.Cells[5].Value = cripto.Encrypt(this._senhaAES, linha.Cells[5].Value.ToString());

                        CarregarNasTextBox();
                        AtualizarLinha(linha2);

                        verde("Dados criptografados com sucesso!");

                    } catch(CriptDecript.FormatoTextoInvalido) {
                        MessageBox.Show("Formato de texto inválido! Tente novamente!");
                        vermelho("Erro de formato de texto.");
                    }

                } else {
                    vermelho("A senha deve conter no minimo 8 caracteres.");
                    txtSenhaAES.Focus();
                }
            } else if (e.ColumnIndex == 7) {

                this._senhaAES = txtSenhaAES.Text;

                if (this._senhaAES.Length >= 8) {

                    int linha2 = dtvDados.CurrentRow.Index;
                    DataGridViewRow linha = dtvDados.CurrentRow;
                    CriptDecript.CripDecript decrypt = new CriptDecript.CripDecript();

                    try {
                        linha.Cells[1].Value = decrypt.Decrypt(this._senhaAES, linha.Cells[1].Value.ToString());
                        linha.Cells[2].Value = decrypt.Decrypt(this._senhaAES, linha.Cells[2].Value.ToString());
                        linha.Cells[3].Value = decrypt.Decrypt(this._senhaAES, linha.Cells[3].Value.ToString());
                        linha.Cells[4].Value = decrypt.Decrypt(this._senhaAES, linha.Cells[4].Value.ToString());
                        linha.Cells[5].Value = decrypt.Decrypt(this._senhaAES, linha.Cells[5].Value.ToString());

                        CarregarNasTextBox();

                        verde("Dados decriptografados com sucesso!");

                    } catch(CriptDecript.FormatoTextoInvalido) {

                        MessageBox.Show("Formato de texto inválido! Tente novamente!");

                        vermelho("Erro de formato de texto.");

                    } catch(CriptDecript.SenhaIncorreta) {

                        MessageBox.Show("Senha incorreta!");

                        vermelho("Senha de decrypt incorreta.");

                    }

                } else {
                    vermelho("Senha inválida. Minimo de 8 caracteres.");
                    txtSenhaAES.Focus();
                }              
            }
        }

        // BOTÃO PARA JOGAR OS DADOS DA LINHA SELECIONADA NAS TEXTBOX.

        private void dtvDados_CellClick(object sender, DataGridViewCellEventArgs e) {
            CarregarNasTextBox();
        }

        // FECHANDO A FORM DEPOIS DO X OU CTRL + F4.

        private void frmPainel_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        // BTÃO DE DELETAR OS DADOS SELECIONADOS.

        private void btnDeletarDados_Click(object sender, EventArgs e) {

            try {
                this.linha = dtvDados.CurrentRow.Index;
                Modelo.Modelo modelo = new Modelo.Modelo();

                modelo.id = Convert.ToInt32(dtvDados[0, linha].Value);
                this.deuCerto = modelo.Remover();

            } catch(NullReferenceException) {
                MessageBox.Show("Selecione uma linha para deletar!", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                if(this.deuCerto) {

                    CarregarDados();
                    verde("Dados removidos com sucesso!");
                    ClearTXT();

                } else {
                    vermelho("Ouve um erro ao remover os dados.");
                }
            }      
        }

        private void txtSenha_TextChanged(object sender, EventArgs e) {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            frmLogin newLogin = new frmLogin();
            this.Hide();
            newLogin.ShowDialog();
        }

        private void criadorToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process link = new System.Diagnostics.Process();
            link.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.facebook.com/MWStek/");
            link.Start();
        }

        private void btnInformacoes_Click(object sender, EventArgs e) {

        }
    }
}
