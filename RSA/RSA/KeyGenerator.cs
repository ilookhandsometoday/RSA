using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace RSA
{
    public class KeyGenerator
    {
        private static RNGCryptoServiceProvider rNG = new RNGCryptoServiceProvider();

        public KeyGenerator()
        {
            BigInteger lastCheck = 0;
            do
            {
                BigInteger p = this.BigPrimeGenerator();
                BigInteger q = this.BigPrimeGenerator();
                this.N = p * q;
                BigInteger nEulersFunction = (p - 1) * (q - 1);
                do
                {
                    this.E = this.BigPrimeGenerator();
                }
                while (this.E >= this.N);
                BigInteger y = 0; //// variable needed for executing the ExtendedEuclidianAlgorithm();
                BigInteger d = this.D;
                this.ExtendedEuclideanAlgorithm(this.E, nEulersFunction, ref d, ref y);
                this.D = BigInteger.Abs(d);
                lastCheck = BigInteger.ModPow(this.D * this.E, 1, nEulersFunction);
            }
            while (lastCheck != 1);
        }

        public BigInteger N
        {
            get;
        }

        public BigInteger E
        {
            get;
        }

        public BigInteger D
        {
            get;
        }

        private BigInteger ExtendedEuclideanAlgorithm(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            BigInteger x1 = 1, y1 = 1;
            BigInteger d = this.ExtendedEuclideanAlgorithm(b % a, a, ref x1, ref y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private BigInteger BigNumberGenerator()
        {
            byte[] bigNumber = new byte[32];
            rNG.GetBytes(bigNumber);
            BigInteger result = new BigInteger(bigNumber);
            return BigInteger.Abs(result);
        }

        private BigInteger BigPrimeGenerator()
        {
            BigInteger result = 0;
            do
            {
                result = this.BigNumberGenerator();
            }
            while (!this.IsPrime(result));
            return BigInteger.Abs(result);
        }

        private bool MillerRabin(BigInteger valueForTest)
        {
            BigInteger s = valueForTest - 1;
            while (s % 2 == 0)
            {
                s /= 2;
            }

            BigInteger a = 0;
            do
            {
                a = this.BigNumberGenerator();
            }
            while (valueForTest - 1 < a);

            for (int i = 0; i < 11; i++)
            {
                if (BigInteger.ModPow(a, s, valueForTest) != 1)
                    return false;
            }

            return true;
        }

        private bool IsPrime(BigInteger valueForCheck)
        {
            if (valueForCheck == 2 || valueForCheck == 3)
                return true;
            if (valueForCheck < 2 || valueForCheck % 2 == 0)
                return false;
            return this.MillerRabin(valueForCheck);
        }
    }
}
