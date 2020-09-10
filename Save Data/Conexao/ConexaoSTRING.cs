using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Save_Data.Conexao {
    class ConexaoSTRING {
        private string stringDeConexao;

        public string getConnectionString() {
            stringDeConexao = ConfigurationManager.ConnectionStrings["Save_Data.Properties.Settings.ConexaoSQL"].ConnectionString;
            return stringDeConexao;
        }
    }
}
