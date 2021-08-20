using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Windows;

namespace balloonHarbourClientV2.Cryptography
{
    class ECC
    {

        BigInteger p, a, b, Gx, Gy, n, h;

        public ECC(EncryptionMethod m)
        {
            BigInteger[] cnfg = m.getConfig();
            p = cnfg[0];
            a = cnfg[1];
            b = cnfg[2];
            Gx = cnfg[3];
            Gy = cnfg[4];
            n = cnfg[5];
            h = cnfg[6];
        }

        public BigInteger[] genKeys(String pk)
        {
            BigInteger[] output = new BigInteger[3];

            //output[0] = genPrivateKey();
            output[0] = BigInteger.Parse("1" + pk, System.Globalization.NumberStyles.HexNumber);

            //MessageBox.Show("Gx: " + Gx + "\nGy: " + Gy);

            BigInteger[] P = point_mult(output[0], new BigInteger[] { Gx, Gy });

            output[1] = P[0];
            output[2] = P[1];

            return output;
        }

        private BigInteger genPrivateKey()
        {
            Random r = new Random();
            BigInteger max = n;
            BigInteger min = BigInteger.Parse("2");
            BigInteger range = max - min;
            int len = (int) max.GetBitLength();
            byte[] data = new byte[len];
            r.NextBytes(data);
            BigInteger output = new BigInteger(data);

            if (output.CompareTo(min) < 0)
            {
                output = BigInteger.Add(output, min);
            } else if (output.CompareTo(range) >= 0)
            {
                output = BigInteger.Add(BigInteger.ModPow(output, 1, range), min);
            }            
            return output;
        }

        public BigInteger[] point_mult(BigInteger private_key, BigInteger[] G)
        {             
            BigInteger[] res = null;
            List<int> i = new List<int>();
            var bytes = private_key.ToByteArray();
            char[] s = Convert.ToString(bytes[bytes.Length - 1], 2).ToCharArray();

            for (int j = 0; j < s.Length; j++)
            {
                i.Add(int.Parse(s[j].ToString()));
            }
            
            foreach (int bit in i)
            {
                res = point_add(res, res);

                if (bit == 1)
                {
                    res = point_add(res, G);
                }
                //MessageBox.Show("i = " + i.Count + "\nGx: " + res[0] + "\nGy: " + res[1]);
            }

            /*foreach (BigInteger b in res)
            {
                if (b.Sign == -1)
                {

                }
            }*/

            return res;
        }

        private BigInteger[] point_add(BigInteger[] P1, BigInteger[] P2)
        {

            if (P1 == null)
            {
                return P2;
            }

            if (P2 == null)
            {
                return P1;
            }

            BigInteger P1x = P1[0];
            BigInteger P1y = P1[1];
            BigInteger P2x = P2[0];
            BigInteger P2y = P2[1];

            if (P1x.CompareTo(P2x) == 0 && P1y.CompareTo(P2y) != 0)
            {
                return null;
            }

            BigInteger s;
            if (P1x.CompareTo(P2x) == 0)
            {
                //s = (3 * P1x ^ 2 + a) * mod_inv(2 * P1y, p)[1];
                /*BigInteger modinv = mod_inv(BigInteger.Multiply(P1y, BigInteger.Parse("2")), p)[1];

                if (modinv.Sign == -1)
                {
                    modinv = BigInteger.ModPow(BigInteger.Add(BigInteger.ModPow(modinv, 1, p), p), 1, p);
                }*/
                s = BigInteger.ModPow(BigInteger.Multiply(BigInteger.Add(BigInteger.Multiply(BigInteger.Pow(P1x, 2), BigInteger.Parse("3")), a), mod_inv(BigInteger.Multiply(P1y, BigInteger.Parse("2")), p)[1]), 1, p);
            } else
            {
                //s = (P1y - P2y) * mod_inv(P1x - P2x, p)[1];
                /*BigInteger modinv = mod_inv(BigInteger.Subtract(P1x, P2x), p)[1];

                if (modinv.Sign == -1)
                {
                    modinv = BigInteger.ModPow(BigInteger.Add(BigInteger.ModPow(modinv, 1, p), p), 1, p);
                }*/
                s = BigInteger.ModPow(BigInteger.Multiply(BigInteger.Subtract(P1y, P2y), mod_inv(BigInteger.Subtract(P1x, P2x), p)[1]), 1, p);
            }
            
            BigInteger[] output = new BigInteger[2];

            s = BigInteger.ModPow(BigInteger.Add(BigInteger.ModPow(s, 1, p), p), 1, p);

            //output[0] = s;
            //output[1] = s;

            //output[0] = (s ^ 2 - P1x - P2x) % p;
            output[0] = BigInteger.ModPow(BigInteger.Subtract(BigInteger.Subtract(BigInteger.Pow(s, 2), P1x), P2x), 1, p);
            //output[1] = - (s * (output[0] - P1x) + P1y) % p;
            output[1] = BigInteger.ModPow(BigInteger.Negate(BigInteger.Add(BigInteger.Multiply(s, BigInteger.Subtract(output[0], P1x)), P1y)), 1, p);
            
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i].Sign == -1)
                {
                    output[i] = BigInteger.ModPow(BigInteger.Add(BigInteger.ModPow(output[i], 1, p), p), 1, p);
                }
            }       
            return output;
        }

        private BigInteger[] mod_inv(BigInteger x, BigInteger y)
        {

            if (y.CompareTo(BigInteger.Zero) == 0) return new BigInteger[]
            {
                x, BigInteger.One, BigInteger.Zero
            };

            //BigInteger[] vals = mod_inv(b, a % b);
            BigInteger[] vals = mod_inv(y, BigInteger.ModPow(x, 1, y));
            BigInteger d = vals[0];
            BigInteger p1 = vals[2];
            //BigInteger q = vals[1] - a / b * vals[2];
            BigInteger q = BigInteger.Subtract(vals[1], BigInteger.Multiply(BigInteger.Divide(x, y), vals[2]));

            return new BigInteger[]
            {
                d, p1, q
            };
        }
    }
}