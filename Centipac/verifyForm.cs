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

namespace Centipac
{
    public partial class verifyForm : MaterialSkin.Controls.MaterialForm
    {
        User activeUser;
        MaterialSkin.Controls.MaterialForm launchForm;
        private const int adminPerm = 1;
        int permReq = 1;

        public verifyForm(User active, MaterialSkin.Controls.MaterialForm formToLaunch, int permLevel)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
            launchForm = formToLaunch;
            permReq = 1;
        }

        private void verifyForm_Load(object sender, EventArgs e)
        {
            txtPass.Hint = "Password for: " + activeUser.getUser();
            if (activeUser.getPerms() < permReq)
            {
                msgbox msg = new msgbox("Access Denied", "Error", 1);
                msg.Show();
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submit();
        }

        void submit()
        {
            string token = Server.login(activeUser.getUser(), txtPass.Text);

            if (!token.Contains("token"))
            {
                msgbox msg = new msgbox("Invalid password.", "Error", 1);
                msg.Show();
            }
            else
            {
                MessageBox.Show(activeUser.getPerms().ToString());
                if (permReq < activeUser.getPerms()) 
                {
                    msgbox msg = new msgbox("Access Denied.", "Error", 1);
                    msg.Show();
                }
                else
                {
                    activeUser.updateToken(token);
                    launchForm.Show();
                    this.Close();
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit();
            }
        }
    }
}
