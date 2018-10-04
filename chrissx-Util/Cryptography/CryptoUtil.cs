using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using chrissx_Util.Conversion;

namespace chrissx_Util.Cryptography
{
    public static class CryptoUtil
    {
        public static string Encrypt(string value, string password, int keysize)
        {
            return Encrypt<AesManaged>(value, password, keysize);
        }

        public static string Encrypt<T>(string value, string password, int keysize) where T : SymmetricAlgorithm, new()
        {
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);

            byte[] encrypted;
            using (T cipher = new T())
            {
                PasswordDeriveBytes _passwordBytes = new PasswordDeriveBytes(password, Encoding.ASCII.GetBytes("aselrias38490a32"), "SHA1", 2);
                byte[] keyBytes = _passwordBytes.GetBytes(keysize / 8);

                cipher.Mode = CipherMode.CBC;

                using (ICryptoTransform encryptor = cipher.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes("8947az34awl34kjq")))
                    using (MemoryStream to = new MemoryStream())
                        using (CryptoStream writer = new CryptoStream(to, encryptor, CryptoStreamMode.Write))
                        {
                            writer.Write(valueBytes, 0, valueBytes.Length);
                            writer.FlushFinalBlock();
                            encrypted = to.ToArray();
                        }
                cipher.Clear();
            }
            return encrypted.ToBase64();
        }

        public static string Decrypt(string value, string password, int keysize)
        {
            return Decrypt<AesManaged>(value, password, keysize);
        }

        public static string Decrypt<T>(string value, string password, int keysize) where T : SymmetricAlgorithm, new()
        {
            byte[] valueBytes = Convert.FromBase64String(value);

            byte[] decrypted;

            int lenght = 0;

            using (T cipher = new T())
            {
                var _passwordBytes = new PasswordDeriveBytes(password, Encoding.ASCII.GetBytes("aselrias38490a32"), "SHA1", 2);
                var keyBytes = _passwordBytes.GetBytes(keysize / 8);

                cipher.Mode = CipherMode.CBC;

                using (var decryptor = cipher.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes("8947az34awl34kjq")))
                    using (var reader = new CryptoStream(new MemoryStream(valueBytes), decryptor, CryptoStreamMode.Read))
                    {
                        decrypted = new byte[valueBytes.Length];
                        lenght = reader.Read(decrypted, 0, decrypted.Length);
                    }

                cipher.Clear();
            }
            return Encoding.UTF8.GetString(decrypted, 0, lenght);
        }
    }
}
