using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Data.Modelo {
    class Modelo {
        private string _email { get; set; }
        private string _senha { get; set; }
        private string _celular { get; set; }
        private string _site { get; set; }
        private string _anotacoes { get; set; }
        private int _id { get; set; }

        private CRUD.CRUD crud;

        public string email {
            get {
                return _email;
            }
            set {
                _email = value;
            }
        }
        public string senha {
            get {
                return _senha;
            }
            set {
                _senha = value;
            }
        }
        public string celular {
            get {
                return _celular;
            }
            set {
                _celular = value;
            }
        }
        public string site {
            get {
                return _site;
            }
            set {
                _site = value;
            }
        }
        public string anotacoes {
            get {
                return _anotacoes;
            }
            set {
                _anotacoes = value;
            }
        }

        public int id {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }

        public bool Inserir() {
            crud = new CRUD.CRUD();
            bool deuCerto = crud.InserirDados(this.id, this.email, this.senha, this.site, this.celular, this.anotacoes);
            return deuCerto;
        }
        public bool Atualizar() {
            crud = new CRUD.CRUD();
            bool deuCerto = crud.AtualizarDados(id, email, senha, site, celular, anotacoes);
            return deuCerto;
        }
        public bool Remover() {
            crud = new CRUD.CRUD();
            bool deuCerto = crud.RemoverDados(id);
            return deuCerto;
        }

    }
}
