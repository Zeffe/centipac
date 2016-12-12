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

        TimePicker[] timepickers;
       

        private void managerForm_Load(object sender, EventArgs e)
        {
            Employee[] employees = Server.getEmployees(activeUser);
            timepickers = new TimePicker[employees.Length];

            for (int i = 0; i < employees.Length; i++)
            {
                var tempItem = new[] { employees[i].name, employees[i].username, employees[i].perm };
                var item = new ListViewItem(tempItem);
                materialListView1.Items.Add(item);

                timepickers[i] = new TimePicker();

                tabPage3.Controls.Add(timepickers[i].CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + (60 * i)), materialRuler1.Width, this));
                tabPage3.Controls.Add(timepickers[i].CreateLabel(employees[i].name));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialTabControl1.SelectedIndex)
            {
                case 1: 
                    foreach (TimePicker timepicker in timepickers)
                    {
                        timepicker.getDisplay().Hide(this);
                    }
                    break;
            }
        }
    }
}
