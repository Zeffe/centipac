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
    /// <summary>
    /// Form used for adding and editing users.
    /// </summary>
    public partial class addForm : MaterialSkin.Controls.MaterialForm
    {
        User activeUser;
        string tempUser, tempName;
        int tempRank;
        bool isEdit = false;

        /// <summary>
        /// Initialization for adding users.
        /// </summary>
        /// <param name="active"></param>
        public addForm(User active)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
        }

        /// <summary>
        /// Overload initialization function for editing users.
        /// </summary>
        /// <param name="active">Currently logged in user.</param>
        /// <param name="user">Username of user to edit.</param>
        /// <param name="name">Name of user to edit.</param>
        /// <param name="rank">Rank of person to edit.</param>
        public addForm(User active, string user, string name, int rank)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
            tempUser = user; tempName = name; tempRank = rank;
            this.Text = "Editing " + user;
            isEdit = true;
        }

        /// <summary>
        /// Validates information before adding users to server.
        /// </summary>
        /// <param name="sender">btnAdd</param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                // Checks availability of username, returns "valid" if available.
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
                            // Attempts to add user to the server.
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
                        // Attempts to edit the user.
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

        /// <summary>
        /// Initializes variables and interface components to prepare for the addition or editing of users.
        /// </summary>
        /// <param name="sender">addForm</param>
        /// <param name="e"></param>
        private void addForm_Load(object sender, EventArgs e)
        {
            // Goes through each existing rank and makes it an option.
            foreach (Rank rank in mainForm.titles)
            {
                comboRank.Items.Add(rank.title);
            }

            if (isEdit)
            {
                // Values for editing a user.
                comboRank.SelectedIndex = tempRank - 1;
                txtUser.Text = tempUser;
                txtName.Text = tempName;
                txtPass.Enabled = false;
                txtPassConfirm.Enabled = false;
                btnAdd.Text = "Confirm Edit";
            }
            else
            {
                // Values for adding a user.
                comboRank.SelectedIndex = comboRank.Items.Count - 1;
            }
        }

        /// <summary>
        /// Nullifies open form when closed to allow another form to be opened.
        /// </summary>
        /// <param name="sender">addForm</param>
        /// <param name="e"></param>
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
