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
    public partial class scheduleReportForm : MaterialForm
    {
        UserSchedule[] data;

        public scheduleReportForm(UserSchedule[] data)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            this.data = data;
        }

        private void scheduleReportForm_Load(object sender, EventArgs e)
        {
            UserScheduleBindingSource.DataSource = data;
            this.reportViewer1.RefreshReport();
        }

        public void update(UserSchedule[] newData)
        {
            data = newData;
            UserScheduleBindingSource.DataSource = data;
            this.reportViewer1.RefreshReport();
        }

        private void scheduleReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            managerForm.scheduleView = null;
        }
    }
}
