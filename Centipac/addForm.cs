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
    public partial class addForm : MaterialSkin.Controls.MaterialForm
    {
        User activeUser;
        string tempUser, tempName;
        int tempRank;
        bool isEdit = false;

        public addForm(User active)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
        }

        public addForm(User active, string user, string name, int rank)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
            tempUser = user; tempName = name; tempRank = rank;
            this.Text = "Editing " + user;
            isEdit = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                string availability = Server.checkUser(activeUser, txtUser.Text);
                if (!availability.Contains("valid"))
                {
                    msgbox msg = new msgbox(availability, "Error", 1);
                    msg.Show();
                }
                else if (txtPass.Text == txtPassConfirm.Text)
                {
                    if ((txtUser.Text.Length > 3 || txtPass.Text.Length > 3) && txtName.Text != String.Empty && comboRank.SelectedIndex != -1)
                    {
                        msgbox conf = new msgbox("Are you sure you want to add " + txtUser.Text + "?", "Confirmation", 2);
                        if (conf.ShowDialog() == DialogResult.Yes)
                        {
                            string result = Server.addUser(activeUser, txtUser.Text, txtPass.Text, (comboRank.SelectedIndex + 1).ToString(), txtName.Text);
                            if (!result.Contains("token"))
                            {
                                msgbox msg = new msgbox(result, "Error", 1);
                                msg.Show();
                            }
                            else
                            {
                                msgbox msg = new msgbox("Successfully added.", "Success", 1);
                                msg.Show();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                         msgbox msg = new msgbox("Username and password must be longer than 3 characters.", "Error", 1);
                        msg.Show();
                    }
                }
                else
                {
                    msgbox msg = new msgbox("Passwords don't match.", "Error", 1);
                    msg.Show();
                }
            } else
            {
                if (txtUser.Text.Length > 3 && !String.IsNullOrWhiteSpace(txtName.Text))
                {
                    msgbox conf = new msgbox("Are you sure you want to edit " + tempUser + "?", "Confirmation", 2);
                    if (conf.ShowDialog() == DialogResult.Yes)
                    {
                        string result = Server.editUser(activeUser, tempUser, txtUser.Text, txtName.Text, (comboRank.SelectedIndex + 1).ToString());
                        if (!result.Contains("token"))
                        {
                            msgbox msg = new msgbox(result, "Error", 1);
                            msg.Show();
                        } else
                        {
                            msgbox msg = new msgbox("Successfully edited.", "Success", 1);
                            msg.Show();
                            this.Close();
                        }
                    }
                }
                else
                {
                    msgbox msg = new msgbox("Username must be longer than 3 characters.", "Error", msgbox.Buttons.OKButton);
                    msg.Show();
                }
            }
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            foreach (Rank rank in mainForm.titles)
            {
                comboRank.Items.Add(rank.title);
            }

            if (isEdit)
            {
                comboRank.SelectedIndex = tempRank - 1;
                txtUser.Text = tempUser;
                txtName.Text = tempName;
                txtPass.Enabled = false;
                txtPassConfirm.Enabled = false;
                btnAdd.Text = "Confirm Edit";
            }
            else
            {
                comboRank.SelectedIndex = comboRank.Items.Count - 1;
            }
        }

        private void addForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdit)
            {
                managerForm.edit = null;
            }
            else {
                managerForm.add = null;
            }
        }
    }
}
