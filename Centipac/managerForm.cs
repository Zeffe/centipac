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

        TimePicker a = new TimePicker();
        TimePicker b = new TimePicker();
        TimePicker c = new TimePicker();
       

        private void managerForm_Load(object sender, EventArgs e)
        {
            tabPage3.Controls.Add(a.CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + 60), materialRuler1.Width, this));
            tabPage3.Controls.Add(a.CreateLabel("Seth", "Dixon"));
            tabPage3.Controls.Add(b.CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + 120), materialRuler1.Width, this));
            tabPage3.Controls.Add(b.CreateLabel("Donald", "Trump"));
            tabPage3.Controls.Add(c.CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + 180), materialRuler1.Width, this));
            tabPage3.Controls.Add(c.CreateLabel("Kanye", "West"));
        }
    }
}
