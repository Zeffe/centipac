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
using ExtensionMethods;

namespace Centipac
{
    public partial class registerForm : MaterialSkin.Controls.MaterialForm
    {
        public registerForm(User user)
        {
            InitializeComponent();

            activeUser = user;

            Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        User activeUser;
        bool closing = true;

        private void registerForm_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "We require that you register a new\naccount to maintain security. After\nthis account is registered the 'admin'\naccount will be deleted.";
        }

        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closing)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass2.Text && txtUser.Text.Length > 4 && txtPass.Text.Length > 4)
            {
                string result = Server.addUser(activeUser, txtUser.Text, txtPass.Text, "1");

                if (result.Contains("token"))
                {                   
                    Server.deleteUser(activeUser, "admin");
                    activeUser.updateToken(result);
                    loginForm newLogin = new loginForm();
                    newLogin.Show();
                    closing = false;
                    this.Close();
                }
                else
                {
                    msgbox msg = new Centipac.msgbox(result, "Error", 1);
                    msg.Show();
                }
            } else if (txtPass.Text != txtPass2.Text)
            {
                msgbox msg = new Centipac.msgbox("Passwords not matching.", "Error", 1);
                msg.Show();
            } else
            {
                msgbox msg = new Centipac.msgbox("Username and password must be greater than 4 characters.", "Error", 1);
                msg.Show();
            }
        }
    }
}
