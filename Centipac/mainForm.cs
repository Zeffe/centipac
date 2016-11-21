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
    public partial class mainForm : MaterialSkin.Controls.MaterialForm
    {

        User activeUser;
        public mainForm(User user)
        {
            InitializeComponent();

            activeUser = user;

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }



        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string username = activeUser.data.Split('_')[1].Split('-')[0];

            MaterialSkin.Controls.MaterialFlatButton user = new MaterialSkin.Controls.MaterialFlatButton();
            user.BackColor = Settings.colorSchemes[Properties.Settings.Default["COLORSCHEME"].ToString()].PrimaryColor;
            user.ForeColor = Color.White;
            user.Text = username;
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
            btnLogOut.Width = btnSettings.Width;

            foreach (KeyValuePair<string, ColorScheme> entry in Settings.colorSchemes)
            {
                comboBox1.Items.Add(entry.Key);
            }
        }

        private void onUserClick(object sender, EventArgs e)
        {
            groupUserOptions.Visible = !groupUserOptions.Visible;
            if (groupUserOptions.Visible)
            {
                groupUserOptions.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.changeSkin(comboBox1.SelectedItem.ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            MaterialSkin.Controls.MaterialFlatButton userBtn = this.Controls.Find("btnUser", false)[0] as MaterialSkin.Controls.MaterialFlatButton;
            userBtn.BackColor = Settings.colorSchemes[comboBox1.SelectedItem.ToString()].PrimaryColor;
            groupUserOptions.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), comboBox2.SelectedItem.ToString(), this);  
               
        }

        private void groupUserOptions_Leave(object sender, EventArgs e)
        {
            groupUserOptions.Visible = false;
        }

        private void materialTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            groupUserOptions.Visible = false;
        }
    }
}
