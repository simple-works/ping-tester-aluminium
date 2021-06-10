using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net;

namespace PingTesterAluminium
{
    public class PingResult
    {
        public IPAddress Address { get; private set; }
        public Byte[] Buffer { get; private set; }
        public long Time { get; private set; }
        public IPStatus Status { get; private set; }
        public int Ttl { get; set; }
        public bool DontFragment { get; private set; }
        public PingRating Rating { get; private set; }
        public Color RatingColor { get; private set; }
        public Color StatusColor { get; private set; }
        public string ErrorMessage { get; private set; }
        public bool HasError { get; private set; }

        public PingResult(PingReply reply = null)
        {
            if (reply == null)
            {
                this.Time = -1;
                this.Status = IPStatus.Unknown;
            }
            else
            {
                this.Address = reply.Address;
                this.Buffer = reply.Buffer;
                this.Time = reply.RoundtripTime;
                this.Status = reply.Status;
                this.Ttl = reply.Options.Ttl;
                this.DontFragment = reply.Options.DontFragment;
            }
            this.Rating = GetRating(this.Time);
            this.RatingColor = GetRatingColor(this.Time);
            this.StatusColor = GetStatusColor(this.Status);
        }

        public PingResult(string errorMessage)
            : this()
        {
            this.ErrorMessage = errorMessage;
            this.HasError = true;
        }

        public static PingRating GetRating(long time = -1)
        {
            if (time < 0) return PingRating.Unknown;
            if (time < 30) return PingRating.Amazing;
            if (time < 60) return PingRating.Excellent;
            if (time < 100) return PingRating.Good;
            if (time < 150) return PingRating.NotBad;
            if (time < 200) return PingRating.Bad;
            if (time < 250) return PingRating.Mediocre;
            if (time < 300) return PingRating.Poor;
            return PingRating.Terrible;
        }

        public static Color GetRatingColor(long time = -1)
        {
            if (time < 0) return Color.Gray;
            if (time <= 100) return Color.Green;
            if (time <= 150) return Color.Yellow;
            return Color.Red;
        }

        public static Color GetStatusColor(IPStatus status = IPStatus.Unknown)
        {
            if (status == IPStatus.Unknown) return Color.Gray;
            if (status == IPStatus.Success) return Color.Blue;
            else return Color.DarkRed;
        }
    }
}
