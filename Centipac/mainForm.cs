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
        List<ViewCustomer> extraTabs = new List<ViewCustomer>();
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

            Customer[] tempCust = Server.getCustomers(activeUser);

            foreach (Customer cust in tempCust)
            {
                todaysCustomers.Add(cust);
            }

            refreshList();
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
                    else if (num > 100)
                    {
                        msgbox error1 = new msgbox("Number too high, please enter number less than 100.", "Error", 1);
                        error1.Show();   
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
                        new EmployeeDate(activeUser.name, dateCreated.ToUnixTime()));
                    try
                    {
                        string response = Server.addCustomer(activeUser, tempCustomer);
                        tempCustomer.id = Convert.ToInt32(response);
                        todaysCustomers.Add(tempCustomer);
                        addCustomerToList(tempCustomer);
                    } catch
                    {
                        msgbox err = new msgbox("Failed to add customer to server.", "Error", msgbox.Buttons.OKButton);
                        err.Show();
                    }
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

        private void delete_click(object sender, ViewCustomer.ViewCustomerEventArgs e)
        {
            msgbox conf = new msgbox("Are you sure you want to delete " + e.customer.registrant + "?", "Delete?", msgbox.Buttons.YesNoButtons);
            if (conf.ShowDialog() == DialogResult.Yes)
            {
                Server.deleteCustomer(activeUser, e.customer.id);
                ViewCustomer vc = sender as ViewCustomer;
                removeViewCustomer(vc);
                int index = getCustomerIndex(e.customer);
                todaysCustomers.RemoveAt(index);
                tabMain.TabPages.Remove((TabPage)(sender as ViewCustomer).Parent);
                tabMain.SelectedTab = tabPage3;
                refreshList();
            }
        }

        private void save_click(object sender, ViewCustomer.ViewCustomerEventArgs e)
        {
            msgbox conf = new msgbox("Save changes to " + e.customer.registrant + "?", "Save?", msgbox.Buttons.YesNoButtons);
            if (conf.ShowDialog() == DialogResult.Yes)
            {
                int index = getCustomerIndex(e.customer);
                ViewCustomer vc = sender as ViewCustomer;
                removeViewCustomer(vc);
                todaysCustomers[index].registrant = vc.Registrant;
                todaysCustomers[index].email = vc.Email;
                todaysCustomers[index].phone = vc.Phone;
                todaysCustomers[index].adults = vc.Adults + 1;
                todaysCustomers[index].children = vc.Children;
                todaysCustomers[index].amountPaid = (vc.Children * 7) + (vc.Adults * 10) + 10;
                todaysCustomers[index].employees.Add(new EmployeeDate(activeUser.name, DateTime.Now.ToUnixTime()));
                string response = Server.editCustomer(activeUser, todaysCustomers[index]);
                tabMain.TabPages.Remove((TabPage)(sender as ViewCustomer).Parent);
                tabMain.SelectedTab = tabPage3;
                refreshList();

                msgbox finish = new msgbox("Successfully made changes to " + e.customer.registrant + ".", "Success", msgbox.Buttons.OKButton);
                finish.Show();
            }
        }

        void removeViewCustomer(ViewCustomer vc)
        {
            int indexToRemove = -1;

            for (int i = 0; i < extraTabs.Count; i++)
            {
                if (extraTabs[i].GetCustomer == vc.GetCustomer) indexToRemove = i;
            }

            if (indexToRemove != -1)
            {
                extraTabs.RemoveAt(indexToRemove);
            }
        }

        public int getCustomerIndex(Customer cust)
        {
            for (int i = 0; i < todaysCustomers.Count; i++)
            {
                if (todaysCustomers[i].registrant == cust.registrant) return i;
            }

            return -1;
        }

        private void listCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (listCustomers.SelectedIndices[0] > -1)
            {
                bool cancel = false;
                selectedCustomer = todaysCustomers[listCustomers.SelectedIndices[0]];

                foreach (ViewCustomer view in extraTabs)
                {
                    if (view.GetCustomer == selectedCustomer)
                    {
                        tabMain.SelectedTab = (TabPage)view.Parent;
                        cancel = true;
                    }
                }

                if (!cancel)
                {
                    TabPage tempPage = new TabPage(selectedCustomer.registrant);
                    tempPage.ContextMenuStrip = menuTabPage;

                    ViewCustomer vc = new ViewCustomer();
                    vc.GetCustomer = selectedCustomer;
                    tempPage.Controls.Add(vc);
                    vc.DeleteClick += new EventHandler<ViewCustomer.ViewCustomerEventArgs>(delete_click);
                    vc.SaveClick += new EventHandler<ViewCustomer.ViewCustomerEventArgs>(save_click);

                    extraTabs.Add(vc);

                    tabMain.TabPages.Add(tempPage);
                    tabMain.SelectedTab = tempPage;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = (ContextMenuStrip)((sender as ToolStripMenuItem).Owner);
            TabPage page = menu.SourceControl as TabPage;
            foreach (Control ctrl in page.Controls)
            {
                if (ctrl is ViewCustomer) removeViewCustomer(ctrl as ViewCustomer);
            }
            tabMain.TabPages.Remove(menu.SourceControl as TabPage);
            tabMain.SelectedTab = tabPage3;
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

                extraTabs.Clear();
            }
        }

        void refreshList(string filter = "")
        {
            listCustomers.Items.Clear();

            foreach (Customer cust in todaysCustomers)
            {
                if (cust.registrant.ToUpper().Contains(filter.ToUpper()) || filter == "")
                {
                    DateTime custTime = cust.date.UnixTimeStampToDateTime();
                    var tempItem = new[]
                    {
                    cust.registrant,
                    cust.employees[0].employee,
                    custTime.ToShortTimeString(),
                    "$" + cust.amountPaid.ToString()
                    };
                    var item = new ListViewItem(tempItem);

                    listCustomers.Items.Add(item);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            refreshList(txtFilter.Text);
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            refreshList();
        }

        void addCustomerToList(Customer cust)
        {
            DateTime custTime = cust.date.UnixTimeStampToDateTime();
            var tempItem = new[] {
                cust.registrant,                            // registrant
                cust.employees[0].employee,                 // Employee
                custTime.ToShortTimeString(),               // Time
                "$" + cust.amountPaid.ToString() };         // Amount paid
            var item = new ListViewItem(tempItem);

            listCustomers.Items.Add(item);
        }

    }
}
