﻿using System;
using System.Text;
using System.Windows;

namespace balloonHarbourClientV2.Cryptography.hashes
{
    class SHA384 : Hash
    {
        public byte[] getSHA(string input)
        {
            System.Security.Cryptography.SHA384 sha384 = System.Security.Cryptography.SHA384.Create();
            return sha384.ComputeHash(Encoding.ASCII.GetBytes(input));
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
