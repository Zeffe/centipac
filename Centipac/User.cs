using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Centipac
{
    public class User
    {
        // Token used for authentication any time a request to the server is made.
        public string token { get; set; }

        //  Data contained within the token in format: "SYSTEMTIME_username-permission"
        public string data { get; set; }

        public string name { get; set; }
 
        /// <summary>
        /// Deserializes the json object returned by the server.
        /// </summary>
        /// <param name="json">JSON string returned from server.</param>
        public void updateToken(string json)
        {
            User temp = JsonConvert.DeserializeObject<User>(json);
            this.token = temp.token;
            this.data = temp.data;
        }

        /// <summary>
        /// Updates the name value with name stored in server.
        /// </summary>
        public void updateName()
        {
            name = Server.getName(this);
        }

        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Gets permission level from data.
        /// </summary>
        /// <returns>Permission integer.</returns>
        public int getPerms()
        {
            return Convert.ToInt32(this.data.Split('-')[1]);
        }

        /// <summary>
        /// Gets user name from data.
        /// </summary>
        /// <returns>Username as string.</returns>
        public string getUser()
        {
            return this.data.Split('_')[1].Split('-')[0];
        }
    }
}
