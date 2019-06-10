using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;

namespace RSA
{
    class EncryptorDecryptor
    {
        public static List<BigInteger> Encrypt(string forEncryption, BigInteger e, BigInteger n)
        {
            int forEncryptionLength = forEncryption.Length;
            byte[] forEncryptionUnicode;
            List<BigInteger> result = new List<BigInteger>(); // splitting the messsage into 1 character chunks;
            for (int i = 0; i < forEncryptionLength; i++)
            {
                forEncryptionUnicode = Encoding.Unicode.GetBytes($"{forEncryption[i]}");
                result.Add(new BigInteger(forEncryptionUnicode));
                result[i] = result[i].ModPow(e, n);
            }

            return result;
        }

        public static string Decrypt(List<BigInteger> forDecryption, BigInteger d, BigInteger n)
        {
            int forDecryptionLength = forDecryption.Count;
            byte[] decryptedUnicode;
            string result = null;
            for(int i = 0; i < forDecryptionLength; i++) // decrypting 1 charater chunks and putting them back into a string
            {
                decryptedUnicode = forDecryption[i].ModPow(d,n).ToByteArray();
                result += Encoding.Unicode.GetString(decryptedUnicode);
            }

            return result;
        }
    }
}
