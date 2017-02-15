using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    public class Customer
    {
        public string Registrant { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public long date { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int amountPaid { get; set; }

        public Customer(string registrant, int adults, int children, long date, string phone, string email, int amountPaid)
        {
            this.Registrant = registrant; this.adults = adults; this.children = children;
            this.date = date; this.phone = phone; this.email = email; this.amountPaid = amountPaid;
        }

    }
}
