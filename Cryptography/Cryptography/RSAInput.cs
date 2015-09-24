using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Cryptography
{
    class RSAInput
    {
        public RSAInput()
        {
            load_list();
            randPQ();
            randE();
            makeD();
        }


        //variables
        public BigInteger N, P, Q, E, D, phiN;
        private Random rand = new Random();
        private List<BigInteger> small, large;        

        //main work
        public string encrypt(string text)
        {
            BigInteger M, m, C;
            List<BigInteger> MList = new List<BigInteger>();

            //message to integer            
            M = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                m = (M << 8) + (int)text[i];
                if (m >= N)
                {
                    MList.Add(M);
                    m = (int)text[i];
                }
                M = m;
            }
            if(!M.IsZero) MList.Add(M);

            string res = "";
            for (int i = 0; i < MList.Count; ++i)
            {
                //encrypt data
                C = BigInteger.ModPow(MList[i], E, N);

                //convert to string
                while (!C.IsZero)
                {
                    res += (char)((C & 0x7F) + 33);
                    C >>= 7;
                }
                res += '\r';
            }

            return res;
        }
        public string decrypt(string data)
        {
            string res = "";
            foreach (string text in data.Split(new char[] { '\r' }))
            {
                //convert back to integer
                BigInteger C = 0;
                for (int i = text.Length - 1; i >= 0; --i)
                {
                    C <<= 7;
                    C |=  (int)text[i] - 33;
                }

                //decrypt data
                BigInteger M = BigInteger.ModPow(C, D, N);

                //extract message
                string tmp = "";
                while (!M.IsZero)
                {
                    tmp += (char)(M & 0xFF);
                    M >>= 8;
                }
                for(int i = tmp.Length - 1; i >= 0; --i)
                {
                    res += tmp[i];
                }
            }

            return res;
        }

        //work func
        private void load_list()
        {
            small = new List<BigInteger>();
            large = new List<BigInteger>();

            string data = Cryptography.Properties.Resources.SmallPrimes;
            foreach (string d in data.Split(new char[] { '\n' }))
            {
                if (string.IsNullOrEmpty(d)) continue;
                small.Add(BigInteger.Parse(d));
            }

            data = Cryptography.Properties.Resources.LargePrimes;
            foreach (string d in data.Split(new char[] { '\n' }))
            {
                if (string.IsNullOrEmpty(d)) continue;
                large.Add(BigInteger.Parse(d));
            }
        }

        public void makeN()
        {
            N = P * Q;
            phiN = (P - 1) * (Q - 1);
        }
        public void randPQ()
        {
            P = large[rand.Next(large.Count)];
            Q = large[rand.Next(large.Count)];
            makeN();
        }
        public void randE()
        {
            E = small[rand.Next(small.Count)];
        }

        public void makeD()
        {
            BigInteger a = E, b = phiN;

            //mod inverse of a by b            
            BigInteger x0 = 0, x1 = 1, t, q;
            while (a > 1)
            {
                q = a / b;
                t = b; b = a % b; a = t;
                t = x0; x0 = x1 - q * x0; x1 = t;
            }
            if (x1 < 0) x1 += phiN;

            //set result
            D = x1;
        }

        public void checkValidity()
        {
            if (P * Q != N)
            {
                throw new Exception("Modulus Error. P * Q != N .");
            }

            if (BigInteger.GreatestCommonDivisor(phiN, E) != 1)
            {
                throw new Exception("Public Key Error. GCD(E, φ(n)) != 1.");
            }

            if (BigInteger.Remainder(E * D, phiN) != 1)
            {
                throw new Exception("Private Key Error. (E * D) mod φ(n) != 1.");
            }
        }

        //getters
        public string getN()
        {
            return N.ToString();
        }
        public string getP()
        {
            return P.ToString();
        }
        public string getQ()
        {
            return Q.ToString();
        }
        public string getE()
        {
            return E.ToString();
        }
        public string getD()
        {
            return D.ToString();
        }

        //setters
        public void setN(string text)
        {
            N = BigInteger.Parse(text);
        }
        public void setP(string text)
        {
            P = BigInteger.Parse(text);
        }
        public void setQ(string text)
        {
            Q = BigInteger.Parse(text);
        }

        public void setE(string text)
        {
            E = BigInteger.Parse(text);
        }
        public void setD(string text)
        {
            D = BigInteger.Parse(text);
        }


    }
}
