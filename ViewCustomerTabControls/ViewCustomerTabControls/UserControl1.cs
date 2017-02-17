using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centipac;

namespace ViewCustomerTabControls
{
    public partial class UserControl1: UserControl
    {

        public long ToUnixTime(DateTime time)
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        public DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public event EventHandler DeleteClick;
        public event EventHandler SaveClick;
        private Customer customer = null;


        public UserControl1()
        {
            InitializeComponent();
        }

        // LOOK HERE https://msdn.microsoft.com/en-us/library/a6h7e207(v=vs.110).aspx

        public object GetCustomer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = (Customer)Convert.ChangeType(value, typeof(Customer));
                fillControl(customer);
            }
        }

        public string Registrant
        {
            get
            {
                return txtRegistrantEdit.Text;
            }
            set
            {
                txtRegistrantEdit.Text = value;
            }
        }

        public int Adults
        {
            get
            {
                return Convert.ToInt32(nmAdults.Value);
            }
            set
            {
                nmAdults.Value = value;
            }
        }

        public int Children
        {
            get
            {
                return Convert.ToInt32(nmChildren.Value);
            }
            set
            {
                nmChildren.Value = value;
            }
        }

        public string Email
        {
            get
            {
                return txtEmailEdit.Text;
            }
            set
            {
                txtEmailEdit.Text = value;
            }
        }

        public string Phone
        {
            get
            {
                return txtPhoneEdit.Text;
            }
            set
            {
                txtPhoneEdit.Text = value;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.DeleteClick != null)
            {
                this.DeleteClick(this, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.SaveClick != null)
            {
                this.SaveClick(this, e);
            }
        }

        void fillControl(Customer customer)
        {
            DateTime tempDate = UnixTimeStampToDateTime(customer.date);

            txtRegistrantEdit.Text = customer.Registrant;
            txtEmailEdit.Text = customer.email;
            txtPhoneEdit.Text = customer.phone;
            lblDate.Text = tempDate.ToShortDateString();
            lblTime.Text = tempDate.ToShortTimeString();

            foreach (EmployeeDate empDate in customer.employees)
            {
                var tempItem = new[]
                {
                        empDate.employee,
                        UnixTimeStampToDateTime(empDate.date).ToShortTimeString()
                    };

                var item = new ListViewItem(tempItem);

                listEditors.Items.Add(item);
            }
        }
    }
}
