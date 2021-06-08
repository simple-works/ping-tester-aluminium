using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace PingTesterAluminium
{
    public static class PingTest
    {
        public static PingResult Ping(string host)
        {
            if (host.IsEmpty() || !host.IsValidHost())
            {
                host = "google.com";
            }
            PingReply pingReply = null;
            try
            {
                pingReply = new Ping().Send(host);
            }
            catch (Exception exception) 
            {
                return new PingResult(-1, "Error", Color.DarkRed, exception.Message, host);

            }
            if (pingReply.Status != IPStatus.Success)
            {
                return new PingResult((int)pingReply.RoundtripTime, "No Response",
                    Color.Gray, pingReply.Status.ToString(), host);
            }
            else
            {
                return new PingResult((int)pingReply.RoundtripTime, GetRating(pingReply.RoundtripTime),
                    GetColor(pingReply.RoundtripTime), pingReply.Status.ToString(), host);
            }
        }

        public static string GetRating(long time)
        {
            if (time <= 30)     return "Amazing";
            if (time <= 60)     return "Excellent";
            if (time <= 100)    return "Good";
            if (time <= 150)    return "Not Bad";
            if (time <= 200)    return "Bad";
            if (time <= 250)    return "Mediocre";
            if (time <= 300)    return "Poor";
                                return "Terrible";
        }

        private static Color GetColor(long time)
        {
            if (time <= 100)    return Color.Green;
            if (time <= 150)    return Color.Yellow;
                                return Color.Red;
        }
    }
}
