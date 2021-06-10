using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace PingTesterAluminium
{
    public static class PingTest
    {
        public static PingResult Run(string host, int timeout = 5000,
            int bufferLength = 32, int ttl = 128, bool dontFragment = false)
        {
            try
            {
                if (timeout < 0) timeout = 0;

                if (bufferLength < 0) bufferLength = 0;
                if (bufferLength > 65500) bufferLength = 65500;

                if (ttl < 0) ttl = 0;
                if (ttl > 255) ttl = 255;

                PingReply reply = new Ping().Send(host, timeout, new byte[bufferLength],
                    new PingOptions(ttl, dontFragment));
                return new PingResult(reply);
            }
            catch (Exception exception)
            {
                return new PingResult(exception.Message);
            }
        }
    }
}
