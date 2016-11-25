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
    public partial class managerForm : MaterialSkin.Controls.MaterialForm;
    {
        public managerForm()
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }
    }
}
