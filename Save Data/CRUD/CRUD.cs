using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Save_Data.CRUD {
    class CRUD {

            private Conexao.ConexaoSTRING conexaoSTRING;
            private MySqlConnection ConexaoSQL;

            public CRUD() {

            }

            public bool InserirDados(int id, string email, string senha, string site, string celular, string anotacoes) {

                ConexaoSQL = new MySqlConnection();
                conexaoSTRING = new Conexao.ConexaoSTRING();
                ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

                string query = "INSERT INTO dados (email, senha, site, celular, anotacoes, vinculo) VALUES (@nome, @senha, @site, @celular, @anotacoes, @id)";

            try {

                ConexaoSQL.Open();

                MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                cmd.Parameters.AddWithValue("@nome", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@site", site);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@anotacoes", anotacoes);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;

            } catch(Exception) {

                return false;

            }finally {

                ConexaoSQL.Close();

            }
            }
            public bool AtualizarDados(int id, string email, string senha, string site, string celular, string anotacoes) {

                ConexaoSQL = new MySqlConnection();
                conexaoSTRING = new Conexao.ConexaoSTRING();
                ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

                string query = "UPDATE dados SET email = @email, senha = @senha, site = @site, celular = @celular, anotacoes = @anotacoes WHERE id = @id";
                
                try {
                    ConexaoSQL.Open();

                    MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@site", site);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@anotacoes", anotacoes);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    return true;

                } catch(Exception) {

                    return false;

                } finally {

                    ConexaoSQL.Close();

                }
            }
            public bool RemoverDados(int id) {

                ConexaoSQL = new MySqlConnection();
                conexaoSTRING = new Conexao.ConexaoSTRING();
                ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

                string query = "DELETE FROM dados WHERE id = @id";

                try {

                    ConexaoSQL.Open();

                    MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    return true;
                    
                } catch(Exception) {

                    return false;

                } finally {

                    ConexaoSQL.Close();
                }
            }

        public bool ValidarLogin(string email, string senha) {

            int retorno = -1;

            ConexaoSQL = new MySqlConnection();
            conexaoSTRING = new Conexao.ConexaoSTRING();
            ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

            string query = "SELECT COUNT(*) FROM usuarios WHERE email = @email and senha = @senha";

            try {

                ConexaoSQL.Open();
                MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());

                return retorno > 0;

            } finally {

                ConexaoSQL.Close();

            }
        }

        public bool RegistrarUsuario(string email, string senha, string usuario) {

            int retorno = -1;
            ConexaoSQL = new MySqlConnection();
            conexaoSTRING = new Conexao.ConexaoSTRING();
            ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

            string query = "SELECT COUNT(*) FROM usuarios WHERE email = @email or usuario = @usuario";

            try {
                ConexaoSQL.Open();
                MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());

            } finally {
                ConexaoSQL.Close();
            }

            if(retorno == 0) {

                string query2 = "INSERT INTO usuarios (email, senha, usuario) VALUES (@email, @senha, @usuario)";

                try {

                    ConexaoSQL.Open();
                    MySqlCommand cmd = new MySqlCommand(query2, ConexaoSQL);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return true;

                } finally {

                    ConexaoSQL.Close();

                }
            } else {

                return false;

            }
        }

        public string PegarUsuario(string email) {

            string usuario;

            ConexaoSQL = new MySqlConnection();
            conexaoSTRING = new Conexao.ConexaoSTRING();
            ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

            string query = "SELECT usuario FROM usuarios WHERE email = @email";

            try {

                ConexaoSQL.Open();
                MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                
                usuario = Convert.ToString(cmd.ExecuteScalar());

                return usuario;

            } finally {

                ConexaoSQL.Close();

            }            
        }

        public int PegarId(string email) {

            int id;

            ConexaoSQL = new MySqlConnection();
            conexaoSTRING = new Conexao.ConexaoSTRING();
            ConexaoSQL.ConnectionString = conexaoSTRING.getConnectionString();

            string query = "SELECT id FROM usuarios WHERE email = @email";

            try {

                ConexaoSQL.Open();
                MySqlCommand cmd = new MySqlCommand(query, ConexaoSQL);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();


                id = Convert.ToInt32(cmd.ExecuteScalar());

                return id;

            } finally {
                ConexaoSQL.Close();
            }
        }
    }
}
