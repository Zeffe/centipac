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


        void login()
        {
            // Build the postdata required for login.
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("username", txtUser.Text);
            postData.AppendUrlEncoded("password", txtPass.Text);
            string url = "https://conveyable-wrenches.000webhostapp.com/login.php";

            // Grab result from login.
            string result = Server.postPHP(url, postData.ToString());

            User activeUser = new User();

            if (!result.Contains("token"))
            {
                lblStatus.Text = "Invalid username or password.";
            }
            else
            {
                //  Update the user based on server response.
                activeUser.updateToken(result);

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
    }
}
