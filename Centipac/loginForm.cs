using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using ExtensionMethods;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace Centipac
{
    public partial class loginForm : MaterialSkin.Controls.MaterialForm
    {
        public loginForm()
        {
            InitializeComponent();

            //  Apply user interface presets.
            Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        public static clockForm timeclockForm = null;

        void login()
        {
            string result = Server.login(txtUser.Text, txtPass.Text);

            User activeUser = new User();

            if (!result.Contains("token"))
            {
                lblStatus.Text = "Invalid username or password.";
            }
            else
            {
                //  Update the user based on server response.
                activeUser.updateToken(result);
                activeUser.updateName();

                //  Require user to create new account if it is the first time logging in.
                if (txtUser.Text == "admin")
                {
                    registerForm register = new registerForm(activeUser);
                    register.Show();
                }
                else
                {
                    mainForm main = new mainForm(activeUser);
                    main.Show();
                }

                this.Hide();
            }

            if (result == "Couldn't connect to server.")
            {
                lblStatus.Text = result;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Logging in...";
            login();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblStatus.Text = "Logging in...";
                login();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            btnClock.BackColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
            btnHelp.BackColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
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
            if (timeclockForm == null)
            {
                timeclockForm = new clockForm();
                timeclockForm.Show();
            } else
            {
                timeclockForm.BringToFront();
            }
        }

        private void btnHelp_MouseEnter(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.questionU;
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.question;
        }

        public static helpForm help = null;

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (help == null)
            {
                help = new helpForm();
                help.Show();
            } else
            {
                help.BringToFront();
            }
        }
    }
}
