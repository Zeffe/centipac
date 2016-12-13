using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Centipac
{
    public class Server
    {
        //  Used to post data to the PHP and returns response.
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

        public static string login(string user, string pass)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("username", user);
            postData.AppendUrlEncoded("password", pass);
            string url = "https://conveyable-wrenches.000webhostapp.com/login.php";

            return Server.postPHP(url, postData.ToString());
        }

        public static Employee[] getEmployees(User currentUser)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            string url = "https://conveyable-wrenches.000webhostapp.com/getEmployees.php";
            string jsonData = Server.postPHP(url, postData.ToString());

            return JsonConvert.DeserializeObject<Employee[]>(jsonData);
        }

        public static string getName(User currentUser)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            string url = "https://conveyable-wrenches.000webhostapp.com/getName.php";

            return Server.postPHP(url, postData.ToString());
        }

        //  With proper authentication, adds a user to the user database.
        public static string addUser(User currentUser, string newUser, string newPass, string newPerm)
        {
            string url = "https://conveyable-wrenches.000webhostapp.com/add.php";
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("newUser", newUser);
            postData.AppendUrlEncoded("newPass", newPass);
            postData.AppendUrlEncoded("newPerm", newPerm);

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


        //  With proper authentication, delets a user from the user database.
        public static string deleteUser(User currentUser, string userToDelete) 
        {
            string url = "https://conveyable-wrenches.000webhostapp.com/delete.php";
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("deleteUser", userToDelete);

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
