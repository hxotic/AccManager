using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccManagerV69
{
    public class Crypto
    {

        public static string Enc(string text, string key)
        {
            if (text == "")
            {
                return "Password Empty!";
            }
            string result;
            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(text);
                using (Aes aes = Aes.Create())
                {
                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, new byte[]
                    {
                        73,
                        118,
                        97,
                        110,
                        32,
                        77,
                        101,
                        100,
                        118,
                        101,
                        100,
                        101,
                        118
                    });
                    aes.Key = rfc2898DeriveBytes.GetBytes(32);
                    aes.IV = rfc2898DeriveBytes.GetBytes(16);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(bytes, 0, bytes.Length);
                            cryptoStream.Close();
                        }
                        text = Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                result = text;
            }
            catch
            {
                result = "Error Encrypting!";
            }
            return result;
        }

        public static string Dec(string text, string key)
        {
            if (text == "")
            {
                return "Password Empty!";
            }
            string result;
            try
            {
                text = text.Replace(" ", "+");
                byte[] array = Convert.FromBase64String(text);
                using (Aes aes = Aes.Create())
                {
                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, new byte[]
                    {
                        73,
                        118,
                        97,
                        110,
                        32,
                        77,
                        101,
                        100,
                        118,
                        101,
                        100,
                        101,
                        118
                    });
                    aes.Key = rfc2898DeriveBytes.GetBytes(32);
                    aes.IV = rfc2898DeriveBytes.GetBytes(16);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(array, 0, array.Length);
                            cryptoStream.Close();
                        }
                        text = Encoding.Unicode.GetString(memoryStream.ToArray());
                    }
                }
                result = text;
            }
            catch
            {
                result = "Error Decrypting!";
            }
            return result;
        }

    }
}
