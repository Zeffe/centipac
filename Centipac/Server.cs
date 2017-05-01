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
using Newtonsoft.Json.Linq;

namespace Centipac
{
    public class Server
    {
        private const string baseUrl = "http://centipacapp.azurewebsites.net/Centipac/";    // Base URL where all PHP files are stored.

        /// <summary>
        /// Used to post information to server.
        /// </summary>
        /// <param name="url">URL to post postData to.</param>
        /// <param name="postData">Data to post to given url.</param>
        /// <returns>Returns string response from server.</returns>
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

        /// <summary>
        /// Function to access login.php on server.
        /// </summary>
        /// <param name="user">Username to attempt to login with.</param>
        /// <param name="pass">Password for given username.</param>
        /// <returns>Returns a User object in JSON form if successful.</returns>
        public static string login(string user, string pass)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("username", user);
            postData.AppendUrlEncoded("password", pass);
            string url = baseUrl + "login.php";

            return Server.postPHP(url, postData.ToString());
        }

        /// <summary>
        /// Gets a list of employees from server.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <returns>Array of Employee objects from server.</returns>
        public static Employee[] getEmployees(User currentUser)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            string url = baseUrl + "getEmployees.php";
            string jsonData = Server.postPHP(url, postData.ToString());

            return JsonConvert.DeserializeObject<Employee[]>(jsonData);
        }

        /// <summary>
        /// Gets a list of ranks from server.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <returns>Array of Rank objects from server.</returns>
        public static Rank[] getRanks(User currentUser)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            string url = baseUrl + "getRanks.php";
            string jsonData = Server.postPHP(url, postData.ToString());

            return JsonConvert.DeserializeObject<Rank[]>(jsonData);
        }

        /// <summary>
        /// Checks to see if a given username is already in use.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="userToCheck">Usename to check availability of.</param>
        /// <returns>"valid" as a string if the username is not in use.</returns>
        public static string checkUser(User currentUser, string userToCheck)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("userToCheck", userToCheck);
            string url = baseUrl + "checkUser.php";

            return Server.postPHP(url, postData.ToString());
        }

        /// <summary>
        /// Gets the name of the currentUser object.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <returns></returns>
        public static string getName(User currentUser)
        {
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            string url = baseUrl + "getName.php";

            return Server.postPHP(url, postData.ToString());
        }


        /// <summary>
        /// Adds a user to the database.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="newUser">Username of new account.</param>
        /// <param name="newPass">Password of new account.</param>
        /// <param name="newPerm">Permission level of new account.</param>
        /// <param name="newName">Name of new account.</param>
        /// <returns>Returns an updated token if successful, otherwise returns "fail".</returns>
        public static string addUser(User currentUser, string newUser, string newPass, string newPerm, string newName)
        {
            string url = baseUrl + "add.php";
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("newUser", newUser);
            postData.AppendUrlEncoded("newPass", newPass);
            postData.AppendUrlEncoded("newPerm", newPerm);
            postData.AppendUrlEncoded("newName", newName);

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

        /// <summary>
        /// Adds a customer to the database.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="customer">Customer object to be added.</param>
        /// <returns>Returns an updated token if successful.</returns>
        public static string addCustomer(User currentUser, Customer customer)
        {
            string url = baseUrl + "addCustomer.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("registrant", customer.registrant);
            postData.AppendUrlEncoded("adults", customer.adults.ToString());
            postData.AppendUrlEncoded("children", customer.children.ToString());
            postData.AppendUrlEncoded("date", customer.date.ToString());
            postData.AppendUrlEncoded("phone", customer.phone);
            postData.AppendUrlEncoded("email", customer.email);
            postData.AppendUrlEncoded("amountPaid", customer.amountPaid.ToString());
            postData.AppendUrlEncoded("employees", JsonConvert.SerializeObject(customer.employees));

            return Server.postPHP(url, postData.ToString());
        }

        /// <summary>
        /// Gets array of Customers from past 24 hours.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <returns>An array of Customers only from past 24 hours.</returns>
        public static Customer[] getCustomers(User currentUser)
        {
            string url = baseUrl + "getCustomers.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);

            List<Customer> returnCusts = new List<Customer>();
        
            string jsonResult = Server.postPHP(url, postData.ToString());

            JArray result = JArray.Parse(jsonResult);

            foreach(JObject json in result)
            {
                returnCusts.Add(new Customer(json));
            }

            return returnCusts.ToArray();
        }

        /// <summary>
        /// Gets array of Customers from a given time period.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="startTime">Unix time stamp that represents beginning time.</param>
        /// <param name="endTime">Unix time stamp that represents end time.</param>
        /// <returns>An array of customers from startTime to endTime periods.</returns>
        public static Customer[] getCustomers(User currentUser, long startTime, long endTime)
        {
            string url = baseUrl + "getCustomers.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("start", startTime.ToString());
            postData.AppendUrlEncoded("end", endTime.ToString());

            List<Customer> returnCusts = new List<Customer>();

            string jsonResult = Server.postPHP(url, postData.ToString());

            if (jsonResult != "Couldn't connect to server.")
            {
                JArray result = JArray.Parse(jsonResult);

                foreach (JObject json in result)
                {
                    returnCusts.Add(new Customer(json));
                }
            }

            return returnCusts.ToArray();
        }

        /// <summary>
        /// Used to edit customer.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="editedCustomer">Customer object after being edited.</param>
        /// <returns>Updated token if successful.</returns>
        public static string editCustomer(User currentUser, Customer editedCustomer)
        {
            string url = baseUrl + "editCustomer.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("registrant", editedCustomer.registrant);
            postData.AppendUrlEncoded("adults", editedCustomer.adults.ToString());
            postData.AppendUrlEncoded("children", editedCustomer.children.ToString());
            postData.AppendUrlEncoded("id", editedCustomer.id.ToString());
            postData.AppendUrlEncoded("phone", editedCustomer.phone);
            postData.AppendUrlEncoded("email", editedCustomer.email);
            postData.AppendUrlEncoded("amountPaid", editedCustomer.amountPaid.ToString());
            postData.AppendUrlEncoded("employees", JsonConvert.SerializeObject(editedCustomer.employees));

            return Server.postPHP(url, postData.ToString());
        }

        /// <summary>
        /// Deletes a customer from the database.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="customerId">ID of the customer to delete.</param>
        /// <returns>Updated token if successful.</returns>
        public static string deleteCustomer(User currentUser, int customerId)
        {
            string url = baseUrl + "deleteCustomer.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("id", customerId.ToString());

            return Server.postPHP(url, postData.ToString());
        }

        /// <summary>
        /// Saves schedule information for the week.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="startDate">Unix time stamp of first day of week, for identifying in database.</param>
        /// <param name="scheduleData">Schedule data in JSON form.</param>
        /// <returns>Updated token if successful.</returns>
        public static string saveSchedule(User currentUser, long startDate, string scheduleData)
        {
            string url = baseUrl + "saveSchedule.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("startDate", startDate.ToString());
            postData.AppendUrlEncoded("scheduleData", scheduleData);

            return Server.postPHP(url, postData.ToString());
        }

        /// <summary>
        /// Gets schedule information from database.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="startDate">Unix time stamp of first day of week to get.</param>
        /// <returns>JSON string with all schedule information for the week.</returns>
        public static string getSchedule(User currentUser, long startDate)
        {
            string url = baseUrl + "getSchedule.php";

            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("startDate", startDate.ToString());

            string result = Server.postPHP(url, postData.ToString());

            if (result == "fail")
            {
                return "Failed to retrieve schedule.";
            } else
            {
                return result;
            }
        }

        /// <summary>
        /// Function for editing user in server.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="oldUser">Original username of edited user.</param>
        /// <param name="newUser">New username of edited user.</param>
        /// <param name="newName">New Name of edited user.</param>
        /// <param name="newPerm">New Permission of edited user.</param>
        /// <returns>Updated token if successful.</returns>
        public static string editUser(User currentUser, string oldUser, string newUser, string newName, string newPerm)
        {
            string url = baseUrl + "edit.php";
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("oldUser", oldUser);
            postData.AppendUrlEncoded("newUser", newUser);
            postData.AppendUrlEncoded("newName", newName);
            postData.AppendUrlEncoded("newPerm", newPerm);

            string result = Server.postPHP(url, postData.ToString());

            if (result.Contains("token"))
            {
                return result;
            }
            else if (result == "fail")
            {
                return "Access Denied";
            }
            else
            {
                return "User already exists.";
            }
        }


        /// <summary>
        /// Deletes a user from the database.
        /// </summary>
        /// <param name="currentUser">User object used for authentication purposes.</param>
        /// <param name="userToDelete">Username of the user to be deleted.</param>
        /// <returns>Updated token if successful.</returns>
        public static string deleteUser(User currentUser, string userToDelete) 
        {
            string url = baseUrl + "delete.php";
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("token", currentUser.token);
            postData.AppendUrlEncoded("data", currentUser.data);
            postData.AppendUrlEncoded("deleteUser", userToDelete);

            string result = Server.postPHP(url, postData.ToString());

            return result;
        }

    }
}
