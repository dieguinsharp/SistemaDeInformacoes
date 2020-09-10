using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Data.Validador {
    class Validar {
        public static bool Email(string email) {
            
            if(email.Contains("@") && email.Contains(".com")) {
                return true;
            }

            return false;

        }

        public static bool Senha(string senha) {

            if(senha.Length >= 8) {
                return true;
            }

            return false;
        } 
        public static bool Celular(string celular) {
            decimal numero;
            if(celular.Length >= 9 && decimal.TryParse(celular, out numero)) {
                return true;
            }

            return false;

        }

        public static bool Site(string site) {

            if(site.Contains("www.") && site.Contains(".com")) {
                return true;
            }

            return false;

        }
    }
}
