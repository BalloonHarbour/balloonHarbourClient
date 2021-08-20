using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class brainpoolP256r1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("a9fb57dba1eea9bc3e660a909d838d726e3bf623d52620282013481d1f6e5377", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("7d5a0975fc2c3057eef67530417affe7fb8055c126dc5c6ce94a4b44f330b5d9", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("26dc5c6ce94a4b44f330b5d9bbd77cbf958416295cf7e1ce6bccdc18ff8c07b6", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("8bd2aeb9cb7e57cb2c4b482ffc81b7afb9de27e1e3bd23c23a4453bd9ace3262", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("547ef835c3dac4fd97f8461a14611dc9c27745132ded8e545c1d54c72f046997", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("a9fb57dba1eea9bc3e660a909d838d718c397aa3b561a6f7901e0e82974856a7", NumberStyles.HexNumber);
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
