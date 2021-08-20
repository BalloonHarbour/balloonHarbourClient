using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class secp192r1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("fffffffffffffffffffffffffffffffeffffffffffffffff", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("fffffffffffffffffffffffffffffffefffffffffffffffc", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("64210519e59c80e70fa7e9ab72243049feb8deecc146b9b1", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("188da80eb03090f67cbf20eb43a18800f4ff0afd82ff1012", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("07192b95ffc8da78631011ed6b24cdd573f977a11e794811", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("ffffffffffffffffffffffff99def836146bc9b1b4d22831", NumberStyles.HexNumber);
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
