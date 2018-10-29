using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace ISET_TCPIP
{
    public class Utilitaires
    {
        public static IPAddress Verifier(string sAdresse)
        {
           IPAddress rep = null;
            if (sAdresse.Trim().Length > 0) // virer les espaces à gauche et ad roite 
            {
                IPAddress[] ipVerifs = Dns.GetHostEntry(sAdresse).AddressList;
                for (int i=0; i < ipVerifs.Length; i++)
                {
                    if (ipVerifs[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        if (ipVerifs[i] != new IPAddress(0x0100007f))
                        {
                            Ping pVerif = new Ping();
                            PingReply pRepon = pVerif.Send(ipVerifs[i]);
                            if (pRepon.Status == IPStatus.Success)
                            {
                                rep = ipVerifs[i];
                                break;
                            }
                        }
                }
            }
            return rep;
        }
    }
}
