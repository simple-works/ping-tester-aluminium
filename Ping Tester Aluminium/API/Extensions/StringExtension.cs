using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingTesterAluminium
{
    public static class StringExtension
    {
        public static bool IsEmpty(this string str)
        {
            return str == string.Empty;
        }
        public static bool IsValidHost(this string str)
        {
            //try
            //{
            //    IPHostEntry ipHost = Dns.GetHostEntry(host);
            //    return true;
            //}
            //catch (SocketException)
            //{
            //    return false;
            //}
            return Uri.CheckHostName(str) != UriHostNameType.Unknown;
        }
    }
}
