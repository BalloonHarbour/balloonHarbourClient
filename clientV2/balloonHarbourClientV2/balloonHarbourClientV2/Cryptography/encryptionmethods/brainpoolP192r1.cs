﻿using balloonHarbourClientV2.Cryptography.hashes;
using System.Globalization;
using System.Numerics;

namespace balloonHarbourClientV2.Cryptography.methods
{
    class brainpoolP192r1 : EncryptionMethod
    {

        BigInteger p = BigInteger.Parse("c302f41d932a36cda7a3463093d18db78fce476de1a86297", NumberStyles.HexNumber);
        BigInteger a = BigInteger.Parse("6a91174076b1e0e19c39c031fe8685c1cae040e5c69a28ef", NumberStyles.HexNumber);
        BigInteger b = BigInteger.Parse("469a28ef7c28cca3dc721d044f4496bcca7ef4146fbf25c9", NumberStyles.HexNumber);
        BigInteger Gx = BigInteger.Parse("c0a0647eaab6a48753b033c56cb0f0900a2f5c4853375fd6", NumberStyles.HexNumber);
        BigInteger Gy = BigInteger.Parse("14b690866abd5bb88b5f4828c1490002e6773fa2fa299b8f", NumberStyles.HexNumber);
        BigInteger n = BigInteger.Parse("c302f41d932a36cda7a3462f9e9e916b5be8f1029ac4acc1", NumberStyles.HexNumber);
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
