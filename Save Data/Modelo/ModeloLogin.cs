using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Data.Modelo {
    class ModeloLogin {
        private string _email, _senha, _usuario;

        public string email { get {
                return _email;
            } set {
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
        public string usuario {
            get {
                return _usuario;
            }
            set {
                _usuario = value;
            }
        }

        private CRUD.CRUD crud;
        public bool ValidarLogin() {

            crud = new CRUD.CRUD();
            bool Logado = crud.ValidarLogin(this._email, this._senha);

            return Logado;
        }

        public bool RegistrarUsuario() {

            crud = new CRUD.CRUD();
            bool Registrado = crud.RegistrarUsuario(email, senha, usuario);

            return Registrado;
        }

        public string getUsuario() {

            crud = new CRUD.CRUD();
            string usuario = crud.PegarUsuario(email);

            return usuario;
        }

        public int getId() {

            crud = new CRUD.CRUD();
            int id = crud.PegarId(email);

            return id;
        }
    }
}
