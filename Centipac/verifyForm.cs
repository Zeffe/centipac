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

        public verifyForm(User active, MaterialSkin.Controls.MaterialForm formToLaunch)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
            launchForm = formToLaunch;
        }

        private void verifyForm_Load(object sender, EventArgs e)
        {
            txtPass.Hint = "Password for: " + activeUser.getUser();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string token = Server.login(activeUser.getUser(), txtPass.Text);

            if (!token.Contains("token"))
            {
                msgbox msg = new msgbox("Invalid password.", "Error", 1);
                msg.Show();
            } else
            {
                activeUser.updateToken(token);
                launchForm.Show();
                this.Close();
            }
        }
    }
}
