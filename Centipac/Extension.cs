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
        /// <summary>
        /// Appends a UrlEncoded string onto a string using StringBuilder.
        /// Used when posting information to the server.
        /// </summary>
        /// <param name="sb">StringBuilder used for building string.</param> 
        /// <param name="name">Name of value posting to PHP. (?name=value)</param> 
        /// <param name="value">Value posting to PHP.</param>
        public static void AppendUrlEncoded(this StringBuilder sb, string name, string value)
        {
            if (sb.Length != 0)
                sb.Append("&");
            sb.Append(WebUtility.UrlEncode(name));
            sb.Append("=");
            sb.Append(WebUtility.UrlEncode(value));
        }

        /// <summary>
        /// Converts a DateTime value to a unix time stamp.
        /// </summary>
        /// <param name="time">DateTime value to be converted.</param>
        /// <returns>Unix time stamp as a long.</returns>
        public static long ToUnixTime(this DateTime time)
        {
            var timeSpan = (time.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        /// <summary>
        /// Gets the name of the first property in a JSON Object.
        /// </summary>
        /// <param name="obj">JSON Object</param>
        /// <returns>First property in JObject as a string.</returns>
        public static string getFirstPropertyName(this JObject obj)
        {
            foreach (JProperty prop in obj.Properties())
            {
                return prop.Name;
            }

            return "Fail";
        }

        /// <summary>
        /// Converts a unix time stamp to a DateTime value.
        /// </summary>
        /// <param name="unixTimeStamp">Unix time stamp as a long.</param>
        /// <returns>DateTime Object.</returns>
        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
