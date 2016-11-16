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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = Settings.colorSchemes["Default"];
        }

        User activeUser = new User();

        void login()
        {
            lblStatus.Text = "Logging in...";
            StringBuilder postData = new StringBuilder();
            postData.AppendUrlEncoded("username", txtUser.Text);
            postData.AppendUrlEncoded("password", txtPass.Text);
            string url = "https://conveyable-wrenches.000webhostapp.com/login.php";

            string result = Server.postPHP(url, postData.ToString());

            if (!result.Contains("token"))
            {
                lblStatus.Text = "Invalid username or password.";
            }
            else
            {
                activeUser.updateToken(result);

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
            login();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
