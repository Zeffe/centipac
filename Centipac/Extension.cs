using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ExtensionMethods
{
    public static class Extension
    {
        public static void AppendUrlEncoded(this StringBuilder sb, string name, string value)
        {
            if (sb.Length != 0)
                sb.Append("&");
            sb.Append(WebUtility.UrlEncode(name));
            sb.Append("=");
            sb.Append(WebUtility.UrlEncode(value));
        }

        public static long ToUnixTime(this DateTime time)
        {
            var timeSpan = (time.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        public static string getFirstPropertyName(this JObject obj)
        {
            foreach (JProperty prop in obj.Properties())
            {
                return prop.Name;
            }

            return "Fail";
        }

        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
