using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class secp256k1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("fffffffffffffffffffffffffffffffffffffffffffffffffffffffefffffc2f", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("0000000000000000000000000000000000000000000000000000000000000000", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("0000000000000000000000000000000000000000000000000000000000000007", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("79be667ef9dcbbac55a06295ce870b07029bfcdb2dce28d959f2815b16f81798", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("483ada7726a3c4655da4fbfc0e1108a8fd17b448a68554199c47d08ffb10d4b8", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("fffffffffffffffffffffffffffffffebaaedce6af48a03bbfd25e8cd0364141", NumberStyles.HexNumber);
        BigInteger h = BigInteger.Parse("1", NumberStyles.HexNumber);

        public BigInteger[] getConfig()
        {
            return new BigInteger[] { p, a, b, Gx, Gy, n, h };
        }

        public Hash getHash()
        {
            return new SHA256();
        }
    }
}
