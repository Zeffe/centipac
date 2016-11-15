using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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
    }
}
