using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ServiceLogic
{
    public class Encriptacion
    {
        private const string _Key = "TPFINAL";

        public static string Encrypt(string PassACifrar, string key)
        {
            try
            {
                string KeyEncriptacion = string.IsNullOrEmpty(key) ? _Key : key;
                byte[] clearBytes = Encoding.Unicode.GetBytes(PassACifrar);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(KeyEncriptacion, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        PassACifrar = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return PassACifrar;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public static string Decrypt(string PassADescifrar, string key)
        {
            try
            {
                string EncryptionKey = string.IsNullOrEmpty(key) ? _Key : key;
                byte[] cipherBytes = Convert.FromBase64String(PassADescifrar);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        PassADescifrar = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return PassADescifrar;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
