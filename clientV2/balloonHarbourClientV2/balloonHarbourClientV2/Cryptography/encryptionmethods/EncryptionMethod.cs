using balloonHarbourClientV2.Cryptography.hashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.Cryptography
{
    interface EncryptionMethod
    {
        BigInteger[] getConfig();

        Hash getHash();
    }
}
