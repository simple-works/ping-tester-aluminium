using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public static class PingTestManager
    {
        public static string Host
        {
            get
            {
                return Settings.Default.Host;
            }
            set
            {
                Settings.Default.Host = value;
                Settings.Default.Save();
            }
        }
        public static int Interval
        {
            get
            {
                return Settings.Default.Interval;
            }
            set
            {
                if (value < 100) value = 100;
                Settings.Default.Interval = value;
                Settings.Default.Save();
            }
        }
        public static int Timeout
        {
            get
            {
                return Settings.Default.Timeout;
            }
            set
            {
                if (value < 0) value = 0;
                Settings.Default.Timeout = value;
                Settings.Default.Save();
            }
        }
        public static int BufferLength
        {
            get
            {
                return Settings.Default.BufferLength;
            }
            set
            {
                if (value < 0) value = 0;
                if (value > 65500) value = 65500;
                Settings.Default.BufferLength = value;
                Settings.Default.Save();
            }
        }
        public static int Ttl
        {
            get
            {
                return Settings.Default.Ttl;
            }
            set
            {
                if (value < 0) value = 0;
                if (value > 255) value = 255;
                Settings.Default.Ttl = value;
                Settings.Default.Save();
            }
        }
        public static bool DontFragment
        {
            get
            {
                return Settings.Default.DontFragment;
            }
            set
            {
                Settings.Default.DontFragment = value;
                Settings.Default.Save();
            }
        }

        public static PingResult RunPingTest()
        {
            return PingTest.Run(
                host: Host,
                timeout: Timeout,
                bufferLength: BufferLength,
                ttl: Ttl,
                dontFragment: DontFragment
            );
        }
    }
}
