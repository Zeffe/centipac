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
            this.Controls.Add(user);


            foreach (KeyValuePair<string, ColorScheme> entry in Settings.colorSchemes)
            {
                comboBox1.Items.Add(entry.Key);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.changeSkin(comboBox1.SelectedItem.ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            MaterialSkin.Controls.MaterialFlatButton userBtn = this.Controls.Find("btnUser", false)[0] as MaterialSkin.Controls.MaterialFlatButton;
            userBtn.BackColor = Settings.colorSchemes[comboBox1.SelectedItem.ToString()].PrimaryColor;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), comboBox2.SelectedItem.ToString(), this);         
        }
    }
}
