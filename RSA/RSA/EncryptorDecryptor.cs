using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RSA
{
    class EncryptorDecryptor
    {
        public static BigInteger Encrypt(string forEncryption, BigInteger e, BigInteger n)
        {
            byte[] forEncryptionUTF8 = Encoding.Default.GetBytes(forEncryption);
            BigInteger result = new BigInteger(forEncryptionUTF8);
            result = BigInteger.ModPow(result, e, n);
            return result;
        }

        public static string Decrypt(BigInteger forDecryption, BigInteger d, BigInteger n)
        {
            BigInteger decrypted = BigInteger.ModPow(forDecryption, d, n);
            byte[] forDecryptionUTF8 = decrypted.ToByteArray();
            string result = Encoding.Default.GetString(forDecryptionUTF8);
            return result;
        }
    }
}
