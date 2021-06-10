using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PingTesterAluminium
{
    public static class StringExtension
    {
        public static bool GetIsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool GetIsValidHost(this string str)
        {
            return Uri.CheckHostName(str) != UriHostNameType.Unknown;
        }

        public static string ToTitleCase(this string str)
        {
            Regex regex = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])|(?<=[A-Za-z])(?=[^A-Za-z])");
            return regex.Replace(str, " ");
        }
    }
}
