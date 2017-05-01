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
    /// Form used for displaying an enlarged report of schedule for the week.
    /// </summary>
    public partial class scheduleReportForm : MaterialForm
    {
        UserSchedule[] data;
        DateTime startDate, endDate;

        public scheduleReportForm(UserSchedule[] data, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);

            this.startDate = startDate;
            this.endDate = endDate;

            this.data = data;
        }

        private void scheduleReportForm_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameterCollection rpc = new Microsoft.Reporting.WinForms.ReportParameterCollection();
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("StartDate", startDate.ToShortDateString()));
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("EndDate", endDate.ToShortDateString()));
            UserScheduleBindingSource.DataSource = data;
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DisplayName = "Schedule" + startDate.ToString("yyyyMMdd");        
            this.reportViewer1.RefreshReport();
        }

        public void update(UserSchedule[] newData)
        {
            data = newData;
            Microsoft.Reporting.WinForms.ReportParameterCollection rpc = new Microsoft.Reporting.WinForms.ReportParameterCollection();
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("StartDate", startDate.ToShortDateString()));
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("EndDate", endDate.ToShortDateString()));
            UserScheduleBindingSource.DataSource = data;
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DisplayName = "Schedule" + startDate.ToString("yyyyMMdd");
            this.reportViewer1.RefreshReport();
        }

        private void scheduleReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            managerForm.scheduleView = null;
        }
    }
}
