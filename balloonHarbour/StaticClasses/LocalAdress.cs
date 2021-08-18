using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace balloonHarbour.StaticClasses {
    public static class LocalAdress {
        public static string GetIPV4() {
            string ipV4 = "-";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    if (ip != IPAddress.None) {
                        ipV4 = ip.ToString();
                    }
                }
            }
            return ipV4;
        }
    }
}
