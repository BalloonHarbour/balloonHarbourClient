using System;
using System.Text;
using System.Windows;

namespace balloonHarbourClientV2.Cryptography.hashes
{
    class SHA512 : Hash
    {
        public byte[] getSHA(string input)
        {
            System.Security.Cryptography.SHA512 sha512 = System.Security.Cryptography.SHA512.Create();
            return sha512.ComputeHash(Encoding.ASCII.GetBytes(input));
        }

        public string hash(string msg)
        {
            try
            {
                return BitConverter.ToString(getSHA(msg)).Replace("-", "").ToLower();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return null;
        }
    }
}
