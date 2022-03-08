using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BOServicesAPI.EncryptBO
{
    public class GngTripleDesAutorizador
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();

        private TripleDESCryptoServiceProvider Des;

        public GngTripleDesAutorizador()
        {
            this.Des = new TripleDESCryptoServiceProvider();
            this.Des.KeySize = 192;
            this.Des.Key = TruncateHash("033360223", this.Des.KeySize / 8);
            this.Des.IV = TruncateHash("5194548", this.Des.BlockSize / 8);
        }

        private Byte[] TruncateHash(string key, int length)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            //Hash the key.
            var keyBytes = System.Text.Encoding.Unicode.GetBytes(key);
            // Truncate or pad the hash.
            Byte[] hash = sha1.ComputeHash(keyBytes);
            Array.Resize(ref hash, length);
            return hash;
        }

        public string EncryptData(string plaintext)
        {
            try
            {
                //Convert the plaintext string to a byte array.
                var plaintextBytes = System.Text.Encoding.Unicode.GetBytes(plaintext);
                //Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //Create the encoder to write to the stream.
                CryptoStream encStream = new CryptoStream(ms, this.Des.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                // Use the crypto stream to write the byte array to the stream.
                encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
                encStream.FlushFinalBlock();
                //Convert the encrypted stream to a printable string.
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex, "Err30101: Error on 'EncryptData()' -  plaintext: {0}", plaintext);
            }
            return String.Empty;

        }

        public string DecryptData(string encryptedtext)
        {
            try
            {
                //Convert the encrypted text string to a byte array.
                var encryptedBytes = Convert.FromBase64String(encryptedtext);
                //Create the stream.
                var ms = new System.IO.MemoryStream();
                //Create the decoder to write to the stream.
                var decStream = new CryptoStream(ms, this.Des.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                //Use the crypto stream to write the byte array to the stream.
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                decStream.FlushFinalBlock();
                //Convert the plaintext stream to a string.
                return System.Text.Encoding.Unicode.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex, "Err30100: Error on 'DecryptData()' -  encryptedtext: {0}", encryptedtext);
            }
            return String.Empty;

        }
    }
}
