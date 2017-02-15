using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using ExtensionMethods;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Centipac
{
    public partial class mainForm : MaterialSkin.Controls.MaterialForm
    {
        public static Rank[] titles;
        List<Customer> todaysCustomers = new List<Customer>();
        TabPage tabCustomerView = new TabPage();
        Customer selectedCustomer;
        User activeUser;
        DateTime dateCreated;
        bool logout = false;
        bool exit = true;
        int adults = 0, children = 0; int price = 0;

        public mainForm(User user)
        {
            InitializeComponent();

            activeUser = user;

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        void hideManager()
        {
            groupUserOptions.Height = 99;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logout && exit)
            {
                msgbox confirm = new msgbox("Are you sure you wish to exit Centipac?",
                "Are you sure?", 2);
                if (confirm.ShowDialog() == DialogResult.Yes)
                {
                    exit = false;
                    Application.Exit();                
                } else
                {
                    e.Cancel = true;
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (activeUser.getPerms() > 1)
            {
                hideManager();
            }

            panel1.BringToFront();

            titles = Server.getRanks(activeUser);

            MaterialSkin.Controls.MaterialFlatButton user = new MaterialSkin.Controls.MaterialFlatButton();
            user.BackColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
            user.ForeColor = Color.White;
            user.Text = activeUser.name;
            user.Name = "btnUser";
            user.useBackColor = true;
            user.useForeColor = true;
            user.ForeColor = Color.White;
            user.Location = new System.Drawing.Point(this.Size.Width - user.Size.Width - 1, 26);
            user.Click += new EventHandler(this.onUserClick);       
            this.Controls.Add(user);

            cmbChildren.AccentColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
            cmbAdults.AccentColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
            cmbChildren.SelectedIndex = 0;
            cmbAdults.SelectedIndex = 0;

            btnClock.BackColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
            btnClock.Location = new Point(user.Location.X - 30, user.Location.Y + 5);

            groupUserOptions.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            groupUserOptions.Location = new Point(this.Width - groupUserOptions.Width - 3, user.Location.Y + user.Size.Height);
            groupUserOptions.DiamondPos = user.Location.X - groupUserOptions.Location.X + (user.Width / 2) - 9;
            groupUserOptions.BringToFront();
        }

        private void onUserClick(object sender, EventArgs e)
        {
            groupUserOptions.Visible = !groupUserOptions.Visible;
            if (groupUserOptions.Visible)
            {
                groupUserOptions.Focus();
            }
        }

        private void groupUserOptions_Leave(object sender, EventArgs e)
        {
            groupUserOptions.Hide();
        }

        private void materialTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            groupUserOptions.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm logOut = new loginForm();
            logOut.Show();
            logout = true;
            if (settings != null)
            {
                settings.Close();
                settings = null;
            }
            this.Close();
        }

        public static settingsForm settings = null;

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new settingsForm();
                settings.Show();
                timerUI.Start();
            } else
            {
                settings.BringToFront();
            }

            groupUserOptions.Hide();
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            if (groupUserOptions.BackColor != MaterialSkinManager.Instance.ColorScheme.PrimaryColor)
            {
                MaterialSkin.Controls.MaterialFlatButton userBtn = this.Controls.Find("btnUser", false)[0] as MaterialSkin.Controls.MaterialFlatButton;
                userBtn.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
                groupUserOptions.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
                btnClock.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
                cmbAdults.AccentColor = cmbChildren.AccentColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            } else if (settings == null)
            {
                timerUI.Stop();
            }                
        }

        public static managerForm manage = null;

        private void btnManager_Click(object sender, EventArgs e)
        {
            if (manage == null)
            {
                manage = new Centipac.managerForm(activeUser);
                verifyForm verify = new verifyForm(activeUser, manage, 1);
                verify.Show();
            } else
            {
                manage.BringToFront();
            }
            groupUserOptions.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Server.test());
        }

        private void btnClock_MouseEnter(object sender, EventArgs e)
        {
            btnClock.Image = Properties.Resources.clockU;
        }

        private void btnClock_MouseLeave(object sender, EventArgs e)
        {
            btnClock.Image = Properties.Resources.clock;
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            if (loginForm.timeclockForm == null)
            {
                loginForm.timeclockForm = new clockForm();
                loginForm.timeclockForm.Show();
            } else
            {
                loginForm.timeclockForm.BringToFront();
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            panel1.SendToBack(); panel1.BackColor = Color.White;

            txtRegistrant.Clear(); txtEmail.Clear(); txtPhone.Clear();

            cmbAdults.SelectedIndex = 0; cmbChildren.SelectedIndex = 0;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            dateCreated = DateTime.Now;
            lblAdults.Text = "Adults ($10): 1";
            adults = 1; children = 0;
            price = (children * 7 + adults * 10);
            lblPrice.Text = "Price: $" + price.ToString();
        }

        private void cmbAdults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdults.Text == "10+")
            {
                msgbox input = new msgbox("Enter the amount of adults: ", "Adults", 3);
                int num;

                if (input.ShowDialog(this) == DialogResult.OK && int.TryParse(input.txtInput.Text, out num))
                {
                    if (num < 10 && num > 0)
                    {
                        cmbAdults.SelectedIndex = num - 1;
                    }
                    else if (num < 1)
                    {
                        cmbAdults.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbAdults.Items.Add(input.txtInput.Text);
                        cmbAdults.SelectedIndex = cmbAdults.Items.Count - 1;                       
                    }
                } else if (!int.TryParse(input.txtInput.Text, out num) && input.txtInput.Text != "")
                {
                    msgbox error = new msgbox("Please enter a numeric value.", "Error", 1);
                    cmbAdults.SelectedIndex = 0;
                    error.Show();
                } else
                {
                    cmbAdults.SelectedIndex = 0;
                }

                input.Dispose();
            }

            lblAdults.Text = "Adults ($10): " + (Convert.ToInt32(cmbAdults.SelectedItem) + 1).ToString();
            adults = Convert.ToInt32(cmbAdults.SelectedItem) + 1;
            price = (children * 7 + adults * 10);
            lblPrice.Text = "Price: $" + price.ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtRegistrant.Text != "") { 
                msgbox conf = new msgbox("Are you sure you want to add " + txtRegistrant.Text + "?", txtRegistrant.Text, 2);
                if (conf.ShowDialog() == DialogResult.Yes)
                {
                    // DO ADD CUSTOMER STUFF HERE
                    panel1.BackColor = Color.LightGray;
                    panel1.BringToFront();

                    Customer tempCustomer = new Customer(
                        txtRegistrant.Text,
                        adults,
                        children,
                        dateCreated.ToUnixTime(),
                        txtPhone.Text,
                        txtEmail.Text,
                        price,
                        activeUser.name);

                    todaysCustomers.Add(tempCustomer);
                    addCustomerToList(tempCustomer);
                }
            } else
            {
                msgbox err = new msgbox("You must enter a registrant in order to continue.", "Error", 1);
                err.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            msgbox conf = new msgbox("Are you sure you wish to cancel, all data will be erased.", "Are You Sure?", 2);
            if (conf.ShowDialog() == DialogResult.Yes)
            {
                panel1.BackColor = Color.LightGray;
                panel1.BringToFront();
            }
        }

        private void cmbChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChildren.Text == "10+")
            {
                msgbox input = new msgbox("Enter the amount of children: ", "Children", 3);
                int num;

                if (input.ShowDialog(this) == DialogResult.OK && int.TryParse(input.txtInput.Text, out num))
                {
                    if (num < 10 && num > 0)
                    {
                        cmbChildren.SelectedIndex = num - 1;
                    }
                    else if (num < 1)
                    {
                        cmbChildren.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbChildren.Items.Add(input.txtInput.Text);
                        cmbChildren.SelectedIndex = cmbChildren.Items.Count - 1;                        
                    }
                }
                else if (!int.TryParse(input.txtInput.Text, out num) && input.txtInput.Text != "")
                {
                    msgbox error = new msgbox("Please enter a numeric value.", "Error", 1);
                    cmbChildren.SelectedIndex = 0;
                    error.Show();
                }
                else
                {
                    cmbChildren.SelectedIndex = 0;
                }

                input.Dispose();
            }
            lblChildren.Text = "Children ($7): " + cmbChildren.Text;
            children = Convert.ToInt32(cmbChildren.Text);
            price = (children * 7 + adults * 10);
            lblPrice.Text = "Price: $" + price.ToString();
        }

        private void listCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (listCustomers.SelectedIndices[0] > -1)
            {
                selectedCustomer = todaysCustomers[listCustomers.SelectedIndices[0]];
                TabPage tempPage = new TabPage(selectedCustomer.Registrant);
                tempPage.ContextMenuStrip = menuTabPage;
                int count = 0;
                foreach (Control ctrl in tabMain.TabPages[0].Controls)
                {
                    if (count == 1) break;
                    count++;
                    Control tempControl = (Control)Activator.CreateInstance(ctrl.GetType());          // http://stackoverflow.com/questions/17305249/how-can-i-duplicate-tabpage-in-c

                    PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(ctrl);

                    foreach (PropertyDescriptor entry in pdc)
                    {
                        object val = entry.GetValue(ctrl);
                        entry.SetValue(tempControl, val);
                    }


                    tempControl.Visible = false;
                    tempPage.Controls.Add(tempControl);
                }

                tabMain.TabPages.Add(tempPage);
                tabMain.SelectedTab = tempPage;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = (ContextMenuStrip)((sender as ToolStripMenuItem).Owner);
            tabMain.TabPages.Remove(menu.SourceControl as TabPage);
        }

        private void closeExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgbox conf = new msgbox("Are you sure you want to exit all extra tabs?", "Close Extra?", msgbox.Buttons.YesNoButtons);
            if (conf.ShowDialog() == DialogResult.Yes)
            {
                for (int i = tabMain.TabPages.Count - 1; i > 1; i--)
                {
                    tabMain.SelectedTab = tabMain.TabPages[i];
                    tabMain.TabPages.RemoveAt(i);
                }
            }
        }

        void addCustomerToList(Customer cust)
        {
            DateTime custTime = cust.date.UnixTimeStampToDateTime();
            var tempItem = new[] {
                cust.Registrant,                            // Registrant
                cust.employee,                              // Employee
                custTime.ToShortTimeString(),               // Time
                "$" + cust.amountPaid.ToString() };         // Amount paid
            var item = new ListViewItem(tempItem);

            listCustomers.Items.Add(item);
        }

    }
}
