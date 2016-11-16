using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centipac
{
    public class Server
    {
        public static string postPHP(string url, string postData)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                Stream reqStream = request.GetRequestStream();
                byte[] postBytes = ASCIIEncoding.ASCII.GetBytes(postData);
                reqStream.Write(postBytes, 0, postBytes.Length);
                reqStream.Close();
                StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream());
                return sr.ReadToEnd();
            }
            catch (Exception e)
            {
                return "Couldn't connect to server.";
            }
        }

        public static string addUser(User currentUser, StringBuilder postData)
        {
            string url = "https://conveyable-wrenches.000webhostapp.com/add.php";

            string result = Server.postPHP(url, postData.ToString());

            if (result.Contains("token"))
            {
                return result;
            } else if (result == "fail")
            {
                return "Access Denied";
            } else
            {
                return "User already exists.";
            }
        }

        public static string deleteUser(User currentUser, StringBuilder postData)
        {
            string url = "https://conveyable-wrenches.000webhostapp.com/delete.php";

            string result = Server.postPHP(url, postData.ToString());

            if (result.Contains("token"))
            {
                return result;
            } else
            {
                return result;
            }
        }

    }
}
