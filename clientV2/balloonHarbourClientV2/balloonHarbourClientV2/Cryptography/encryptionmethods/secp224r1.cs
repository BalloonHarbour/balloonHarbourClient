using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class secp224r1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("ffffffffffffffffffffffffffffffff000000000000000000000001", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("fffffffffffffffffffffffffffffffefffffffffffffffffffffffe", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("b4050a850c04b3abf54132565044b0b7d7bfd8ba270b39432355ffb4", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("b70e0cbd6bb4bf7f321390b94a03c1d356c21122343280d6115c1d21", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("bd376388b5f723fb4c22dfe6cd4375a05a07476444d5819985007e34", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("ffffffffffffffffffffffffffff16a2e0b8f03e13dd29455c5c2a3d", NumberStyles.HexNumber);
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
