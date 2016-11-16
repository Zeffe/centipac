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
        public string token { get; set; }
        public string data { get; set; }

        public void updateToken(string json)
        {
            User temp = JsonConvert.DeserializeObject<User>(json);
            this.token = temp.token;
            this.data = temp.data;
        }
    }
}
