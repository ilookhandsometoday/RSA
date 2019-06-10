using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;

namespace RSA
{
    public class KeyGenerator
    {
        public KeyGenerator()
        {
            BigInteger lastCheck = BigInteger.Zero;
            do
            {
                Random rNG = new Random();
                BigInteger p = BigInteger.ProbablePrime(512, rNG);
                BigInteger q = BigInteger.ProbablePrime(512, rNG);
                this.N = p.Multiply(q);
                BigInteger pMinusOne = p.Subtract(BigInteger.One);
                BigInteger qMinusOne = q.Subtract(BigInteger.One);
                BigInteger nEulersFunction = pMinusOne.Multiply(qMinusOne);
                do
                {
                    this.E = BigInteger.ProbablePrime(512, rNG);
                }
                while (this.E.CompareTo(this.N) >= 0);
                this.D = this.E.ModInverse(nEulersFunction);
                BigInteger dMultE = this.D.Multiply(this.E);
                lastCheck = dMultE.Mod(nEulersFunction);
            }
            while (lastCheck.CompareTo(BigInteger.One) != 0); // checking if D is the modular inverse of E, just in case
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
    }
}
