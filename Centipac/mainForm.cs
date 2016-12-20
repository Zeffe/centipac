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

namespace Centipac
{
    public partial class mainForm : MaterialSkin.Controls.MaterialForm
    {
        public static Rank[] titles;
        User activeUser;
        bool logout = false;


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
            if (!logout)
            {
                Application.Exit();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (activeUser.getPerms() > 2)
            {
                hideManager();
            }

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

            groupUserOptions.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            groupUserOptions.Location = new Point(this.Width - groupUserOptions.Width - 3, user.Location.Y + user.Size.Height);
            groupUserOptions.DiamondPos = user.Location.X - groupUserOptions.Location.X + (user.Width / 2) - 9;
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
                verifyForm verify = new verifyForm(activeUser, manage);
                verify.Show();
            } else
            {
                manage.BringToFront();
            }
            groupUserOptions.Hide();
        }
    }
}
