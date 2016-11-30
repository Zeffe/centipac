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
    public partial class managerForm : MaterialSkin.Controls.MaterialForm
    {
        User activeUser;

        public managerForm(User active)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            activeUser = active;
        }

        private void managerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.manage = null;
        }

        private void materialProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            materialProgressBar1.Offset = this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X - materialTabControl1.Location.X;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            materialProgressBar1.Value = Math.Min(Math.Max((this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X - materialTabControl1.Location.X - materialProgressBar1.Offset), materialProgressBar1.Minimum), materialProgressBar1.Maximum);
        }

        private void materialProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}
