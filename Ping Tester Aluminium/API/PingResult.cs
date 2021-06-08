using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace PingTesterAluminium
{
    public class PingResult
    {
        public long Time { get; set; }
        public string Rating { get; set; }
        public Color Color { get; set; }
        public string Message { get; set; }
        public string Host { get; set; }

        public PingResult(int time, string rating, Color color, string message, string host)
        {
            this.Time = time;
            this.Rating = rating;
            this.Color = color;
            this.Message = message;
            this.Host = host;
        }
    }
}
