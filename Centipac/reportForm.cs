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
using ExtensionMethods;

namespace Centipac
{
    /// <summary>
    /// Form used for displaying an enlarged report of customers for a given time period.
    /// </summary>
    public partial class reportForm : MaterialSkin.Controls.MaterialForm
    {

        User activeUser;

        public reportForm(User activeUser)
        {
            InitializeComponent();

            this.activeUser = activeUser;

            var materialSkinManager = Settings.changeSkin(Properties.Settings.Default["COLORSCHEME"].ToString(), Properties.Settings.Default["THEME"].ToString(), this);
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            dtEnd.MinDate = DateTime.Today;
            dtEnd.MaxDate = DateTime.Today.AddDays(1);
            dtEnd.Value = DateTime.Today.AddDays(1);
            dtStart.MaxDate = DateTime.Today;
            dtStart.Value = DateTime.Today;
        }

        private void reportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            managerForm.report = null;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameterCollection rpc = new Microsoft.Reporting.WinForms.ReportParameterCollection();
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("StartDate", dtStart.Value.ToShortDateString()));
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("EndDate", dtEnd.Value.ToShortDateString()));
            CustomerBindingSource.DataSource = Server.getCustomers(activeUser, dtStart.Value.ToUnixTime(), dtEnd.Value.ToUnixTime());
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DisplayName = "Report" + dtStart.Value.ToString("yyyyMMdd");
            reportViewer1.RefreshReport();
        }
    }
}
