using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Centipac
{
    public class EmployeeDate
    {
        public string employee { get; set; }
        public long date { get; set; }

        public EmployeeDate(string employee, long date)
        {
            this.employee = employee;
            this.date = date;
        }
    }

    public class Customer
    {        
        public int id { get; set; }
        public string registrant { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public long date { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int amountPaid { get; set; }
        public List<EmployeeDate> employees = new List<EmployeeDate>();

        public Customer(string registrant, int adults, int children, long date, string phone, string email, int amountPaid, EmployeeDate employeeDate)
        {
            this.registrant = registrant; this.adults = adults; this.children = children;
            this.date = date; this.phone = phone; this.email = email; this.amountPaid = amountPaid;
            this.employees.Add(employeeDate);
        }

        public Customer(JObject jsonObj)
        {
            this.id = jsonObj["id"].Value<int>();
            this.registrant = jsonObj["registrant"].Value<string>();
            this.adults = jsonObj["adults"].Value<int>();
            this.children = jsonObj["children"].Value<int>();
            this.date = jsonObj["date"].Value<long>();
            this.phone = jsonObj["phone"].Value<string>();
            this.email = jsonObj["email"].Value<string>();
            this.amountPaid = jsonObj["amountPaid"].Value<int>();
            this.employees = JsonConvert.DeserializeObject<EmployeeDate[]>(jsonObj["employees"].Value<string>()).ToList();
        }

    }
}
