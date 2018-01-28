using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace RSAclear
{

    static class Operations
    {
        static Random random = new Random((int)DateTime.Now.Ticks);
        public static BigInteger getPrime(int size)
        {
            BigInteger num = Random(size);
            if (num.IsEven)
                num++;
            if (num < 0)
                num *= -1;
            while (!MillerRabinTest(num, (int)Math.Log(size, 2)))
            {
                num += 2;
            }
            return num;
        }

        private static BigInteger Random(int size)
        {
            byte[] temp = new byte[size / 8];
            random.NextBytes(temp);
            return new BigInteger(temp);
        }
        public static BigInteger modInverse(BigInteger e, BigInteger fhi) //улучшенный алгоритм Евклида
        {
            BigInteger i = fhi, v = 0, d = 1;
            while (e > 0)
            {
                BigInteger t = i / e, x = e;
                e = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= fhi;
            if (v < 0) v = (v + fhi) % fhi;
            return v;
        }
        public static void  Print1(BigInteger a,BigInteger b,BigInteger v,BigInteger u)
        {
            BigInteger azaza = Operations.modInverse(a, b);
            BigInteger gcd = BigInteger.Multiply(a, azaza) + BigInteger.Multiply(b, v);
            Start.evkl.tbResult.Text = a + "*" + azaza + "+" + b + "*" + v + "=" + gcd;

        }
        public static void Print2(BigInteger a, BigInteger b, BigInteger v, BigInteger u)
        {
            BigInteger gcd1 = Operations.GCD(a, b);
            u = (gcd1 - BigInteger.Multiply(b, v)) / a;
            Start.evkl.tbResult.Text = a + "*" + u + "+" + b + "*" + v + "=" + gcd1;
        }
        public static  BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }
        public static void EGCD(BigInteger a, BigInteger b, ref BigInteger u, ref BigInteger v)
        {
            u = 1;
            v = 0;
            BigInteger g = a;
            BigInteger u1 = 0;
            BigInteger v1 = 1;
            BigInteger g1 = b;
            while (g1 != 0)
            {
                BigInteger q = g / g1;
                BigInteger t1 = u - q * u1;
                BigInteger t2 = v - q * v1;
                BigInteger t3 = g - q * g1;
                u = u1; v = v1; g = g1;
                u1 = t1; v1 = t2; g1 = t3;
            }
            if (g != 1)
            {
                u = 0;
            }
        }
        public static bool MillerRabinTest(BigInteger prime, BigInteger k)
        {
            if (prime <= 1)
                return false;
            if (prime == 2)
                return true;
            if (prime % 2 == 0)
                return false;
            int s = 0;
            BigInteger d = prime - 1;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }
            for (int i = 0; i < k; i++)
            {
                BigInteger a = Random(2, prime - 1);
                BigInteger x = BigInteger.ModPow(a, d, prime);
                if (x == 1 || x == prime - 1)
                    continue;
                for (int j = 0; j < s - 1; j++)
                {
                    x = (x * x) % prime;
                    if (x == 1)
                        return false;
                    if (x == prime - 1)
                        break;
                }
                if (x != prime - 1)
                    return false;
            }
            return true;
        }
        private static BigInteger Random(BigInteger min, BigInteger max)
        {
            byte[] data = max.ToByteArray();
            byte[] temp = new byte[data.Length];
            random.NextBytes(temp);
            BigInteger result = new BigInteger(temp);
            while (result <= min || result >= max)
            {
                random.NextBytes(temp);
                result = new BigInteger(temp);
            }
            return result;
        }
        public static BigInteger modExp(BigInteger b, BigInteger e, BigInteger m)// быстрое возведение в степень
        {

            BigInteger lb = b;
            BigInteger le = e;
            BigInteger lm = m;

            BigInteger result = 1;

            while (le > 0)
            {
                if ((le & 1) == 1)
                    result = ((result % lm) * (lb % lm)) % lm;
                le = le >> 1;
                lb = ((lb % lm) * (lb % lm)) % lm;
            }

            return result;
        }
    }
}
