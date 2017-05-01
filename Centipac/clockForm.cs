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
    // TODO: add time clock functionality.

    /// <summary>
    /// AS OF RIGHT NOW COMPLETELY OBSOLETE.
    /// AS OF RIGHT NOW COMPLETELY OBSOLETE.
    /// AS OF RIGHT NOW COMPLETELY OBSOLETE.
    /// AS OF RIGHT NOW COMPLETELY OBSOLETE.
    /// </summary>
    public partial class clockForm : MaterialSkin.Controls.MaterialForm
    {
        public clockForm()
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

        }

        private void clockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.timeclockForm = null;
        }

        private void clockForm_Load(object sender, EventArgs e)
        {
            btnLogIn.Parent = this;
            pnlTime.Visible = false;
            btnLogIn.Location = new Point(btnLogIn.Location.X, txtUser.Location.Y + btnLogIn.Height + 10);          
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogIn.Visible = false;
            pnlTime.Visible = true;
            txtUser.Enabled = false;
        }

        private void btnIn_MouseEnter(object sender, EventArgs e)
        {
            btnIn.BackColor = Color.LightGray;
        }

        private void btnIn_MouseLeave(object sender, EventArgs e)
        {
            btnIn.BackColor = Color.White;
        }

        private void btnOut_MouseEnter(object sender, EventArgs e)
        {
            btnOut.BackColor = Color.LightGray;
        }

        private void btnOut_MouseLeave(object sender, EventArgs e)
        {
            btnOut.BackColor = Color.White;
        }
    }
}
