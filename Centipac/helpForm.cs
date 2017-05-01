using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Centipac
{
    /// <summary>
    /// Help Form used only for displaying help information.
    /// </summary>
    public partial class helpForm : MaterialForm
    {
        public helpForm()
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        private void helpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.help = null;
        }
    }
}
