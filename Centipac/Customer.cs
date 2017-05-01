using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Centipac
{
    /// <summary>
    /// Used primarily for serialization, keeps track of employees that have edited
    /// specific customers as well as the date that they edited them.
    /// </summary>
    public class EmployeeDate
    {
        public string employee { get; set; }        // Represents the username of the employee that edited.
        public long date { get; set; }              // Date is represented as a unix time stamp.

        public EmployeeDate(string employee, long date)
        {
            this.employee = employee;
            this.date = date;
        }
    }

    /// <summary>
    /// Primary customer object.
    /// </summary>
    public class Customer
    {        
        public int id { get; set; }
        public string registrant { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public long date { get; set; }              // Date is represented as a unix time stamp.
        public string phone { get; set; }           // Phone number is represented as a string and never validated.
        public string email { get; set; }
        public int amountPaid { get; set; }
        public List<EmployeeDate> employees = new List<EmployeeDate>();     // List of employees that have edited a customer.

        /// <summary>
        /// Initializer used in program.
        /// </summary>
        /// <param name="registrant">Name of registrant.</param>
        /// <param name="adults">Number of adults in party.</param>
        /// <param name="children">Number of children in party.</param>
        /// <param name="date">Date represented as a unix time stamp.</param>
        /// <param name="phone">Phone number represented as a string.</param>
        /// <param name="email">Email of registrant.</param>
        /// <param name="amountPaid">Amount paid as an integer.</param>
        /// <param name="employeeDate">Employee that created the object (see EmployeeDate).</param>
        public Customer(string registrant, int adults, int children, long date, string phone, string email, int amountPaid, EmployeeDate employeeDate)
        {
            this.registrant = registrant; this.adults = adults; this.children = children;
            this.date = date; this.phone = phone; this.email = email; this.amountPaid = amountPaid;
            this.employees.Add(employeeDate);
        }

        /// <summary>
        /// Initializer used by server, converts JSON object to a customer object.
        /// </summary>
        /// <param name="jsonObj">JSON received from server.</param>
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
