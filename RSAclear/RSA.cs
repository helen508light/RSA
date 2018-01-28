using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace RSAclear
{
   public class RSA
    {
        public  BigInteger p;
        public BigInteger q;
        public BigInteger e;
        public BigInteger d;
        public BigInteger N;
        bool check = false;

     public RSA(int length)
        {
            p = Operations.getPrime(length);
            q = Operations.getPrime(length);
            N = p * q;
            BigInteger fi = (p - 1) * (q - 1);
            e = N;
            while (fi % e == 0 || e >= N || e == p || e == q)
                e = Operations.getPrime(2 * length / 3); //длина e = длина N/3
            d = Operations.modInverse(e, fi);
        }
       
       
        public BigInteger[] Encrypt(string message)
        {
            BigInteger[] chipher;
            byte[] s = System.Text.Encoding.ASCII.GetBytes(message);
            BigInteger msg = new BigInteger(s);
            if (N.ToString().Length > msg.ToString().Length)
            {
                chipher = new BigInteger[1];
                BigInteger ll = 0;
                chipher[0] = Operations.modExp(msg, e, N);
            }
            else
            {
                int kol =1;
                int l = msg.ToString().Length;
                check = true;
                while (N.ToString().Length < l)
                {
                    l = l / 2;
                    kol = kol * 2;
                }
              
                int numArrayBlock = (message.Length/kol) + 1;
                chipher = new BigInteger[numArrayBlock];
                string[] arrayString = new string[numArrayBlock];

                for (int i = 0; i < arrayString.Length; i++)
                {
                    if (numArrayBlock - i == 1)
                        arrayString[i] = message.Substring(i * kol, message.Length - i * kol);
                    else
                        arrayString[i] = message.Substring(i * kol, kol);

                    byte[] ss = System.Text.Encoding.UTF8.GetBytes(arrayString[i]);
                    chipher[i] = Operations.modExp(new BigInteger(ss), e, N);
                }       
            }
            return chipher;
        }
        public string Decrypt(BigInteger[] cipher)
        {
            string s = ""; 
            if (check)
            {        
                for (int i = 0; i < cipher.Length; i++)
                {
                    s += System.Text.Encoding.UTF8.GetString
                        (Operations.modExp(cipher[i], d, N).ToByteArray());
                }
            }
            else
            { 
            BigInteger msg = Operations.modExp(cipher[0], d, N);
            s = System.Text.Encoding.ASCII.GetString(msg.ToByteArray());
        }
            return s;
        }
    }
}
