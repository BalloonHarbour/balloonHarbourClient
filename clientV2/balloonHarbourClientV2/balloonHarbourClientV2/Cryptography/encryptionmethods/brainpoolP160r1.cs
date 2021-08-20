using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class brainpoolP160r1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("e95e4a5f737059dc60dfc7ad95b3d8139515620f", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("340e7be2a280eb74e2be61bada745d97e8f7c300", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("1e589a8595423412134faa2dbdec95c8d8675e58", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("bed5af16ea3f6a4f62938c4631eb5af7bdbcdbc3", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("1667cb477a1a8ec338f94741669c976316da6321", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("e95e4a5f737059dc60df5991d45029409e60fc09", NumberStyles.HexNumber);
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
