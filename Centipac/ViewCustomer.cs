﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;

namespace Centipac
{
    /// <summary>
    /// User Control used to view and edit customers.
    /// </summary>
    public partial class ViewCustomer : UserControl
    {
        public class ViewCustomerEventArgs : EventArgs
        {
            public Customer customer { get; set; }

            public ViewCustomerEventArgs(Customer cust)
            {
                this.customer = cust;
            }

            public Customer GetCustomer { get { return customer; } }
        }

        public event EventHandler<ViewCustomerEventArgs> DeleteClick;
        public event EventHandler<ViewCustomerEventArgs> SaveClick;
        private Customer customer = null;


        public ViewCustomer()
        {
            InitializeComponent();
        }


        public Customer GetCustomer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
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
                this.DeleteClick(this, new ViewCustomerEventArgs(customer));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.SaveClick != null)
            {
                this.SaveClick(this, new ViewCustomerEventArgs(customer));
            }
        }

        /// <summary>
        /// Fills the ViewCustomer object with a given Customer's data.
        /// </summary>
        /// <param name="customer">Customer to display.</param>
        void fillControl(Customer customer)
        {
            DateTime tempDate = customer.date.UnixTimeStampToDateTime();

            txtRegistrantEdit.Text = customer.registrant;
            txtEmailEdit.Text = customer.email;
            txtPhoneEdit.Text = customer.phone;
            lblDate.Text = tempDate.ToShortDateString();
            lblTime.Text = tempDate.ToShortTimeString();
            nmAdults.Value = customer.adults;
            nmChildren.Value = customer.children;

            foreach (EmployeeDate empDate in customer.employees)
            {
                var tempItem = new[]
                {
                        empDate.employee,
                        empDate.date.UnixTimeStampToDateTime().ToShortTimeString()
                    };

                var item = new ListViewItem(tempItem);

                listEditors.Items.Add(item);
            }
        }
    }
}
