using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace DAL
{
    public class Security
    {
        private string Key;
        public Security()
        {
            this.Key = "d1ea3bc43e2c3fae0b45fc81475e93db";
        }

        public string Encrypt(string text)
        {
            try
            {
                byte[] KeyArray;
                byte[] ArrayEncrypt = UTF8Encoding.UTF8.GetBytes(text);
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                KeyArray = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = KeyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform Ctrans = tdes.CreateEncryptor();
                byte[] result = Ctrans.TransformFinalBlock(ArrayEncrypt, 0, ArrayEncrypt.Length);
                tdes.Clear();

                return Convert.ToBase64String(result, 0, result.Length);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public string Decrypt(string text)
        {
            try
            {
                byte[] KeyArray;
                byte[] ArrayDecrypt = Convert.FromBase64String(text);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                KeyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));
                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = KeyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] ResultArray = cTransform.TransformFinalBlock(ArrayDecrypt, 0, ArrayDecrypt.Length);
                tdes.Clear();

                return UTF8Encoding.UTF8.GetString(ResultArray);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
