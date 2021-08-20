using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.Cryptography.hashes
{
    interface Hash
    {
        public String hash(String msg);

        public byte[] getSHA(string input);
    }
}
