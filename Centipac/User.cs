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

        //  Deserializes the json object returned by the server.
        public void updateToken(string json)
        {
            User temp = JsonConvert.DeserializeObject<User>(json);
            this.token = temp.token;
            this.data = temp.data;
        }

        public int getPerms()
        {
            return Convert.ToInt32(this.data.Split('-')[1]);
        }

        public string getUser()
        {
            return this.data.Split('_')[1].Split('-')[0];
        }
    }
}
