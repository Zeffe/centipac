using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewCustomerTabControls
{
    public partial class UserControl1: UserControl
    {
        public event EventHandler DeleteClick;
        public event EventHandler SaveClick;


        public UserControl1()
        {
            InitializeComponent();
        }

        // LOOK HERE https://msdn.microsoft.com/en-us/library/a6h7e207(v=vs.110).aspx

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
    }
}
