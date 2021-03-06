﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Collections;
using Newtonsoft.Json;
using ExtensionMethods;
using Newtonsoft.Json.Linq;

namespace Centipac
{
    public partial class managerForm : MaterialSkin.Controls.MaterialForm
    {
        User activeUser;
        bool slider = true;
        string previousSelect = "Monday";                   // Stores the previously selected day on schedule page for saving purposes.
        List<EmployeeSchedule> listEmployeeSchedules = new List<EmployeeSchedule>();
        Employee[] employees;
        TabPage scheduleTab;                                // Used to store the scheuleTab to refresh it back to default.
        DateTime startDate, endDate;

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


        TimePicker[] timepickers;   // Array of TimePickers used on schedule tab.

        private void managerForm_Load(object sender, EventArgs e)
        {
            scheduleTab = tabMain.TabPages[2];

            // Gets list of employees from server.
            employees = Server.getEmployees(activeUser);

            // Initializes a TimePicker for every employee.
            timepickers = new TimePicker[employees.Length];

            // Sets DatePicker values relative to today.
            dtDay.MaxDate = DateTime.Today;
            dtDay.Value = DateTime.Today;
            dtEnd.MinDate = DateTime.Today;
            dtEnd.MaxDate = DateTime.Today.AddDays(1);
            dtEnd.Value = DateTime.Today.AddDays(1);
            dtStart.MaxDate = DateTime.Today;
            dtStart.Value = DateTime.Today;

            lblSlider.Click += new System.EventHandler(scheduleSlider);
            lblTable.Click += new System.EventHandler(scheduleTable);
            pnlSliderSelect.Click += new System.EventHandler(scheduleSlider);
            pnlTableSelect.Click += new System.EventHandler(scheduleTable);

            lblHeader.Font = MaterialSkinManager.Instance.ROBOTO_MEDIUM_12;
            lblHeader.ForeColor = MaterialSkinManager.Instance.GetSecondaryTextColor();
            lblName.ForeColor = MaterialSkinManager.Instance.GetPrimaryTextColor();
            lblUsername.ForeColor = MaterialSkinManager.Instance.GetPrimaryTextColor();
            lblTitle.ForeColor = MaterialSkinManager.Instance.GetPrimaryTextColor();

            DateTime today = DateTime.Today;
            int daysSinceMonday = (int)today.DayOfWeek - 1;
            today = today.AddDays(-daysSinceMonday);

            startDate = today;
            endDate = today.AddDays(6);
            lblStartDate.Text = today.ToShortDateString() + " - ";
            lblEndDate.Text = (today.AddDays(6)).ToShortDateString();

            // Displays all ranks in listRanks table.
            for (int i = 0; i < mainForm.titles.Length; i++)
            {
                var tempItem = new[] { mainForm.titles[i].rank.ToString(), mainForm.titles[i].title };
                var item = new ListViewItem(tempItem);
                listRanks.Items.Add(item);
            }

            // Displays list of employees on listEmployees and creates TimePicker object for each employee.
            for (int i = 0; i < employees.Length; i++)
            {
                var tempItem = new[] { employees[i].name, employees[i].username, employees[i].perm };
                var item = new ListViewItem(tempItem);
                listEmployees.Items.Add(item);

                listEmployeeSchedules.Add(new EmployeeSchedule(employees[i].name));
                
                // Creates TimePickers and places them on schedule tab.
                timepickers[i] = new TimePicker();

                tabPage3.Controls.Add(timepickers[i].CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + (60 * (i + 1))), materialRuler1.Width, this));
                tabPage3.Controls.Add(timepickers[i].CreateNameLabel(employees[i].name));
                tabPage3.Controls.Add(timepickers[i].CreateTimeLabel());
            }

            updateTimePickersSchedule();

            employeeScheduleToTable(listEmployeeSchedules.ToArray());
        }

        #region Schedule
        /// <summary>
        /// Shows the current TimePicker values in a table.
        /// </summary>
        /// <param name="sender">pnlTable</param>
        /// <param name="e"></param>
        private void scheduleTable(object sender, EventArgs e)
        {
            if (slider)
            {
                updateSchedules();
                pnlTableSelect.BackColor = Color.DodgerBlue;
                pnlSliderSelect.BackColor = Color.Transparent;
                pnlTable.Visible = true;
                pnlTable.BringToFront();

                listEmployeeSchedules.Clear();

                // Gets TimePicker values and puts them on a table.
                foreach (TimePicker timepicker in timepickers)
                {
                    Dictionary<string, Dictionary<string, DayValue>> tempData = new Dictionary<string, Dictionary<string, DayValue>>();
                    tempData = timepicker.getJsonObj() as Dictionary<string, Dictionary<string, DayValue>>;

                    listEmployeeSchedules.Add(new EmployeeSchedule(timepicker.getName()));

                    foreach (var item in tempData)
                    {
                        int index = getEmployeeIndex(item.Key);
                        if (index == -1) break;
                        foreach (var item2 in item.Value)
                        {
                            switch (item2.Key)
                            {
                                case "Monday": listEmployeeSchedules[index].Monday = item2.Value.text; break;
                                case "Tuesday": listEmployeeSchedules[index].Tuesday = item2.Value.text; break;
                                case "Wednesday": listEmployeeSchedules[index].Wednesday = item2.Value.text; break;
                                case "Thursday": listEmployeeSchedules[index].Thursday = item2.Value.text; break;
                                case "Friday": listEmployeeSchedules[index].Friday = item2.Value.text; break;
                                case "Saturday": listEmployeeSchedules[index].Saturday = item2.Value.text; break;
                                case "Sunday": listEmployeeSchedules[index].Sunday = item2.Value.text; break;
                            }
                        }
                    }
                }
                employeeScheduleToTable(listEmployeeSchedules.ToArray());
                slider = !slider;
            }
        }

        /// <summary>
        /// Gets an employees index in listEmployeeSchedules based off name.
        /// </summary>
        /// <param name="name">Name of employee to get index of.</param>
        /// <returns>Index in listEmployeeSchedules as an integer.</returns>
        int getEmployeeIndex(string name)
        {
            for (int i = 0; i < listEmployeeSchedules.Count; i++)
            {
                if (listEmployeeSchedules[i].name == name) return i;
            }
            return -1;
        }

        /// <summary>
        /// Changes from table to view with TimePickers on it.
        /// </summary>
        /// <param name="sender">pnlSlider</param>
        /// <param name="e"></param>
        private void scheduleSlider(object sender, EventArgs e)
        {
            if (!slider)
            {
                pnlSliderSelect.BackColor = Color.DodgerBlue;
                pnlTableSelect.BackColor = Color.Transparent;
                pnlTable.Visible = false;
                slider = !slider;
            }
        }

        /// <summary>
        /// Object used for displaying TimePicker information on table.
        /// </summary>
        public class EmployeeSchedule
        {
            public string name;
            public string Monday = "";
            public string Tuesday = "";
            public string Wednesday = "";
            public string Thursday = "";
            public string Friday = "";
            public string Saturday = "";
            public string Sunday = "";

            public EmployeeSchedule(string _name)
            {
                this.name = _name;
            }
        }

        /// <summary>
        /// Converts an EmployeeSchedule object to an item in listSchedule.
        /// </summary>
        /// <param name="employeeSchedules">Array of EmployeeSchedules to add.</param>
        void employeeScheduleToTable(EmployeeSchedule[] employeeSchedules)
        {
            listSchedule.Items.Clear();
            foreach (EmployeeSchedule emp in employeeSchedules)
            {
                var tempItem = new[] { emp.name, emp.Monday, emp.Tuesday, emp.Wednesday, emp.Thursday, emp.Friday, emp.Saturday, emp.Sunday };
                var item = new ListViewItem(tempItem);
                listSchedule.Items.Add(item);
            }
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSchedules();
            previousSelect = cmbDay.SelectedItem.ToString();
        }

        /// <summary>
        /// Saves TimePicker value for a given day and loads the value for another day.
        /// </summary>
        void updateSchedules()
        {
            foreach (TimePicker tp in timepickers)
            {
                tp.Save(previousSelect);
                tp.Clear();
                tp.Load(cmbDay.SelectedItem.ToString());
            }
        }
        #endregion

        /// <summary>
        /// Used for sorting items in a listView.
        /// </summary>
        class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;

            public ListViewItemComparer()
            {
                col = 0;
            }

            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                    ((ListViewItem)y).SubItems[col].Text);
                if (order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }
                return returnVal;
            }
        }

        private int sortColumn = -1;
        private int employeeDisplay;

        private void listEmployees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                listEmployees.Sorting = SortOrder.Ascending;
            } else
            {
                if (listEmployees.Sorting == SortOrder.Ascending)
                {
                    listEmployees.Sorting = SortOrder.Descending;
                } else
                {
                    listEmployees.Sorting = SortOrder.Ascending;
                }
            }

            listEmployees.Sort();

            listEmployees.ListViewItemSorter = new ListViewItemComparer(e.Column, listEmployees.Sorting);

        }

        private void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listEmployees.SelectedIndices.Count)
            {
                case 0: btnDelete.Enabled = false; btnEdit.Enabled = false; break;
                default: btnDelete.Enabled = true; btnEdit.Enabled = true; break;
            }

            btnNext.Enabled = (listEmployees.SelectedItems.Count > 1);
            employeeDisplay = 0;
            displayEmployeeInfo(employeeDisplay);
        }

        void displayEmployeeInfo(int count)
        {
            try
            {
                lblName.Text = "Full Name: " + listEmployees.SelectedItems[count].SubItems[0].Text;
                lblUsername.Text = "Username: " + listEmployees.SelectedItems[count].SubItems[1].Text;
                lblTitle.Text = "Title: " + listEmployees.SelectedItems[count].SubItems[2].Text;
            }
            catch { }
        }

        /// <summary>
        /// Attempts to delete an employee from server.
        /// </summary>
        /// <param name="sender">btnDelete</param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Gets the selected employee's username.
            string userToDelete = listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].SubItems[1].Text;
            msgbox confirm = new msgbox("Are you sure you want to delete the user '" + userToDelete + "'. This cannot be undone.",
                "Are you sure?", 2);
            if (confirm.ShowDialog() == DialogResult.Yes)
            {
                Server.deleteUser(activeUser, userToDelete);
                listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].Remove();
                updateList();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            employeeDisplay++;
            displayEmployeeInfo(employeeDisplay % listEmployees.SelectedItems.Count);
        }

        public static addForm add = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (add == null)
            {
                add = new addForm(activeUser);
                add.Show();
                timerAdd.Start();
            } else
            {
                add.BringToFront();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listEmployees.Items.Clear();
            
            for (int i = 0; i < employees.Length; i++)
            {
                var tempItem = new[] { employees[i].name, employees[i].username, employees[i].perm };
                var item = new ListViewItem(tempItem);
                listEmployees.Items.Add(item);               
            }
        }

        public static addForm edit = null;

        /// <summary>
        /// Opens the addForm with selected employee's edit information.
        /// </summary>
        /// <param name="sender">btnEdit</param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedUser = listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].SubItems[1].Text;
            Employee employeeToEdit = null;

            // Gets the Employee object from username to edit.
            foreach (Employee employee in employees)
            {
                if (employee.username == selectedUser) employeeToEdit = employee;
            }

            if (edit == null && employeeToEdit != null)
            {
                edit = new addForm(activeUser, employeeToEdit.username, employeeToEdit.name, Convert.ToInt32(employeeToEdit.perm));
                edit.Show();
                timerEdit.Start();
            } else if (employeeToEdit != null)
            {
                edit.BringToFront();
            }
        }

        /// <summary>
        /// Updates the list of Employees with information from server.
        /// Also updates TimePickers.
        /// </summary>
        private void updateList()
        {
            tabMain.TabPages[2] = scheduleTab;

            listEmployees.Items.Clear();

            Employee[] employees = Server.getEmployees(activeUser);

            timepickers = new TimePicker[employees.Length];

            for (int i = 0; i < employees.Length; i++)
            {
                var tempItem = new[] { employees[i].name, employees[i].username, employees[i].perm };
                var item = new ListViewItem(tempItem);
                listEmployees.Items.Add(item);

                timepickers[i] = new TimePicker();

                tabMain.TabPages[2].Controls.Add(timepickers[i].CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + (60 * (i + 1))), materialRuler1.Width, this));
                tabMain.TabPages[2].Controls.Add(timepickers[i].CreateNameLabel(employees[i].name));
                tabMain.TabPages[2].Controls.Add(timepickers[i].CreateTimeLabel());
            }
        }

        /// <summary>
        /// Updates list after an employee is added.
        /// </summary>
        /// <param name="sender">timerAdd</param>
        /// <param name="e"></param>
        private void timerAdd_Tick(object sender, EventArgs e)
        {
            if (add == null)
            {
                employees = Server.getEmployees(activeUser);
                timerAdd.Stop();
                updateList();
            }
        }

        /// <summary>
        /// Updates list after an employee is edited.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEdit_Tick(object sender, EventArgs e)
        {
            if (edit == null)
            {
                employees = Server.getEmployees(activeUser);
                timerEdit.Stop();
                updateList();
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtEnd.MinDate = dtStart.Value;
        }

        public static reportForm report = null;

        private void btnEnlarge_Click(object sender, EventArgs e)
        {
            if (report == null)
            {
                report = new reportForm(activeUser);
                report.Show();
            } else
            {
                report.BringToFront();
            }
        }

        /// <summary>
        /// Creates the schedule report.
        /// </summary>
        /// <param name="sender">btnScheduleReport</param>
        /// <param name="e"></param>
        private void btnScheduleReport_Click(object sender, EventArgs e)
        {            
            Microsoft.Reporting.WinForms.ReportParameterCollection rpc = new Microsoft.Reporting.WinForms.ReportParameterCollection();
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("StartDate", startDate.ToShortDateString()));
            rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("EndDate", endDate.ToShortDateString()));

            List<UserSchedule> schedules = new List<UserSchedule>();
            foreach (TimePicker tp in timepickers)
            {
                schedules.Add(tp.getSchedule());
            }
            UserScheduleBindingSource.DataSource = schedules;
            reportViewer2.LocalReport.SetParameters(rpc);
            reportViewer2.LocalReport.DisplayName = "Schedule" + startDate.ToString("yyyyMMdd");
            reportViewer2.RefreshReport();
            tabMain.SelectedIndex = tabMain.TabCount - 1;
        }

        public static scheduleReportForm scheduleView = null;

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            List<UserSchedule> schedules = new List<UserSchedule>();
            foreach (TimePicker tp in timepickers)
            {
                schedules.Add(tp.getSchedule());
            }

            if (scheduleView == null)
            {
                scheduleView = new scheduleReportForm(schedules.ToArray(), startDate, endDate);
                scheduleView.Show();
            } else
            {
                scheduleView.update(schedules.ToArray());
            }
        }

        /// <summary>
        /// Populates the listCustomers table with an array of Customer objects.
        /// </summary>
        /// <param name="customers">Array of customers to display in table.</param>
        /// <param name="filter">Used to filter out certain registrant names.</param>
        void populateTable(Customer[] customers, string filter)
        {
            listCustomers.Items.Clear();

            foreach (Customer cust in customers)
            {
                if (cust.registrant.ToUpper().Contains(filter.ToUpper()) || filter == "")
                {
                    DateTime custTime = cust.date.UnixTimeStampToDateTime();
                    var tempItem = new[]
                    {
                       custTime.ToShortTimeString(),
                        cust.registrant,
                        cust.employees[0].employee
                    };
                    var item = new ListViewItem(tempItem);

                    listCustomers.Items.Add(item);
                }
            }
        }

        Customer[] loadedCustomers;

        /// <summary>
        /// Generates a report of customers from a given time period.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sends changes to TimePickers to server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            msgbox conf = new msgbox("Save changes to schedule?", "Save?", msgbox.Buttons.YesNoButtons);

            if (conf.ShowDialog() == DialogResult.Yes)
            {
                List<object> times = new List<object>();
                foreach (TimePicker timepicker in timepickers)
                {
                    timepicker.Save(previousSelect);
                    times.Add(timepicker.getJsonObj());
                }

                string jsonData = JsonConvert.SerializeObject(times);
                Server.saveSchedule(activeUser, startDate.Date.ToUnixTime(), jsonData);
            }
        }

        /// <summary>
        /// Updates the TimePicker values with values from the server.
        /// </summary>
        void updateTimePickersSchedule()
        {
            try {
                List<NameDayValue> ndvs = new List<NameDayValue>();
                string scheduleJson = Server.getSchedule(activeUser, startDate.Date.ToUnixTime());

                JArray schedules = JArray.Parse(scheduleJson);

                foreach (JObject obj in schedules)
                {
                    ndvs.Add(new NameDayValue(obj.getFirstPropertyName(), JsonConvert.DeserializeObject<Dictionary<string, DayValue>>(obj.First.First.ToString(Formatting.None))));
                }

                for (int i = 0; i < timepickers.Length; i++)
                {
                    foreach (NameDayValue ndv in ndvs)
                    {
                        if (timepickers[i].getName() == ndv.name)
                        {
                            timepickers[i].HardClear();
                            timepickers[i].populateData(ndv.scheduleData);
                            timepickers[i].Load(previousSelect);
                            continue;
                        }
                    }
                }
            } catch
            {
                msgbox err = new msgbox("Failed to update schedule information.", "Error", msgbox.Buttons.OKButton);
                err.Show();
            }
        }

        /// <summary>
        /// Deletes any changes to TimePickers and loads info from server.
        /// </summary>
        /// <param name="sender">btnReload</param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e) {
            msgbox conf = new msgbox("Reload schedule and delete any changes?", "Reload?", msgbox.Buttons.YesNoButtons);
            if (conf.ShowDialog() == DialogResult.Yes)
            {
                updateTimePickersSchedule();
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == tabMain.TabCount - 1)
            {
                Microsoft.Reporting.WinForms.ReportParameterCollection rpc = new Microsoft.Reporting.WinForms.ReportParameterCollection();
                rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("StartDate", startDate.ToShortDateString()));
                rpc.Add(new Microsoft.Reporting.WinForms.ReportParameter("EndDate", endDate.ToShortDateString()));

                List<UserSchedule> schedules = new List<UserSchedule>();
                foreach (TimePicker tp in timepickers)
                {
                    schedules.Add(tp.getSchedule());
                }
                UserScheduleBindingSource.DataSource = schedules;
                reportViewer2.LocalReport.SetParameters(rpc);
                reportViewer2.LocalReport.DisplayName = "Schedule" + startDate.ToString("yyyyMMdd");
                reportViewer2.RefreshReport();
                tabMain.SelectedIndex = tabMain.TabCount - 1;
            }
        }

        private void dtDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime value = dtDay.Value;
            long startDate = value.ToUnixTime();
            long endDate = startDate + 86400;

            loadedCustomers = Server.getCustomers(activeUser, startDate, endDate);

            populateTable(loadedCustomers, "");               
        }
    }
}
