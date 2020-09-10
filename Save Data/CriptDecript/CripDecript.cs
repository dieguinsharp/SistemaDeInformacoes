using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Save_Data.CriptDecript {
    class CripDecript {
        private byte[] DataToDecrypt;
        public string Decrypt(dynamic pass, string text) {

            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(pass));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            try {
                this.DataToDecrypt = Convert.FromBase64String(text);
            } catch(FormatException) {
                throw new FormatoTextoInvalido();
            } finally {
                try {
                    ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                    Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
                    text = UTF8.GetString(Results);
                } catch(CryptographicException) {

                    throw new SenhaIncorreta();

                } catch(NullReferenceException) {

                } finally {
                    TDESAlgorithm.Clear();
                    HashProvider.Clear();
                }
            }
            return text;
        }

        public string Encrypt(dynamic pass, string text) {

            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(pass));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(text);

            try {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
                text = Convert.ToBase64String(Results);
            } catch(CryptographicException) {
                throw new FormatoTextoInvalido();
            } finally {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            return text;
        }
    }
}
