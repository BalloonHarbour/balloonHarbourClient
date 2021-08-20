﻿using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class secp256r1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("ffffffff00000001000000000000000000000000ffffffffffffffffffffffff", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("ffffffff00000001000000000000000000000000fffffffffffffffffffffffc", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("5ac635d8aa3a93e7b3ebbd55769886bc651d06b0cc53b0f63bce3c3e27d2604b", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("6b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c296", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("4fe342e2fe1a7f9b8ee7eb4a7c0f9e162bce33576b315ececbb6406837bf51f5", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("ffffffff00000000ffffffffffffffffbce6faada7179e84f3b9cac2fc632551", NumberStyles.HexNumber);
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
