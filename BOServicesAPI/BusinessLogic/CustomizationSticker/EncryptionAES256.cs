using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic
{
    public class EncryptionAES256
    {

        private string keyExterno,keyGosmo;

        public EncryptionAES256(string _keyExterno, string _keyGosmo) {
            keyExterno = _keyExterno;
            keyGosmo = _keyGosmo;
        }
        private byte[] KeyByte(int opc)
        {
           
            if (String.IsNullOrEmpty(keyExterno) && String.IsNullOrEmpty(keyGosmo))
            {
                throw new InvalidOperationException("No se encontraron las  Keys");
            }
            UnicodeEncoding UE = new UnicodeEncoding();
            switch (opc)
            {
                case 1://opcion para encriptar la generacion de SID
                    return UE.GetBytes(keyExterno);                        
                break;
                case 2://opcion para encriptar datos sensibles de la gestion de Stickers
                    return UE.GetBytes(keyGosmo);
                break;
            }
            return null;
        }


        public string Encryption(string plainText,int opc)
        {
            byte[] _key = KeyByte(opc);
            if (_key == null)
            {
                return string.Empty;
            }
            byte[] Key = SHA256Managed.Create().ComputeHash(_key);
            byte[] IV = MD5.Create().ComputeHash(_key);
            byte[] textoByte;
            string hex = String.Empty;

            // Create an AesManaged object
            // with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        textoByte = msEncrypt.ToArray();
                    }
                }

            }
            return BitConverter.ToString(textoByte).Replace("-", string.Empty);

        }

        public string Decryption(string textEcrip,int opc)
        {
            byte[] _key = KeyByte(opc);
            if (_key == null)
            {
                return string.Empty;
            }
            byte[] Key = SHA256Managed.Create().ComputeHash(_key);
            byte[] IV = MD5.Create().ComputeHash(_key);
            byte[] cipherText = ConversorStringHexABytes(textEcrip);

            string textoPlano = String.Empty;

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            textoPlano = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return textoPlano;

        }

        private string CoversionBytesAStringHex(byte[] textoEncriptadoByte)
        {

            return BitConverter.ToString(textoEncriptadoByte).Replace("-", string.Empty);
        }

        private byte[] ConversorStringHexABytes(string textoStringHex)
        {

            if (textoStringHex.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", textoStringHex));
            }

            byte[] data = new byte[textoStringHex.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = textoStringHex.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return data;
        }

       


    }

}
