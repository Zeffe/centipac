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

namespace Centipac
{
    public partial class managerForm : MaterialSkin.Controls.MaterialForm
    {
        User activeUser;
        bool slider = true;
        string previousSelect = "Monday";                   // Stores the previously selected day on schedule page for saving purposes.
        List<EmployeeSchedule> listEmployeeSchedules = new List<EmployeeSchedule>();
        Employee[] employees;

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
            employees = Server.getEmployees(activeUser);

            timepickers = new TimePicker[employees.Length];

            dtDay.MaxDate = DateTime.Today;

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
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextMonday = today.AddDays(daysUntilMonday);

            lblStartDate.Text = today.ToShortDateString() + " - ";
            lblEndDate.Text = (today.AddDays(6)).ToShortDateString();

            for (int i = 0; i < mainForm.titles.Length; i++)
            {
                var tempItem = new[] { mainForm.titles[i].permission.ToString(), mainForm.titles[i].title };
                var item = new ListViewItem(tempItem);
                listRanks.Items.Add(item);
            }

            for (int i = 0; i < employees.Length; i++)
            {
                var tempItem = new[] { employees[i].name, employees[i].username, employees[i].perm };
                var item = new ListViewItem(tempItem);
                listEmployees.Items.Add(item);

                listEmployeeSchedules.Add(new EmployeeSchedule(employees[i].name));

                timepickers[i] = new TimePicker();

                tabPage3.Controls.Add(timepickers[i].CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + (60 * (i + 1))), materialRuler1.Width, this));
                tabPage3.Controls.Add(timepickers[i].CreateLabel(employees[i].name));
            }

            employeeScheduleToTable(listEmployeeSchedules.ToArray());
        }

        #region Schedule
        private void scheduleTable(object sender, EventArgs e)
        {
            if (slider)
            {
                updateSchedules();
                pnlTableSelect.BackColor = Color.DodgerBlue;
                pnlSliderSelect.BackColor = Color.Transparent;
                pnlTable.Visible = true;
                pnlTable.BringToFront();
                foreach (TimePicker timepicker in timepickers)
                {
                    Dictionary<string, Dictionary<string, DayValue>> tempData = new Dictionary<string, Dictionary<string, DayValue>>();
                    tempData = timepicker.getJsonObj() as Dictionary<string, Dictionary<string, DayValue>>;

                    foreach (var item in tempData)
                    {
                        int index = getEmployeeIndex(item.Key);
                        if (index == -1) break;
                        foreach (var item2 in item.Value)
                        {
                            switch(item2.Key)
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

                    timepicker.hideToolTip();
                }
                employeeScheduleToTable(listEmployeeSchedules.ToArray());
                slider = !slider;
            }
        }
        int getEmployeeIndex(string name)
        {
            for (int i = 0; i < listEmployeeSchedules.Count; i++)
            {
                if (listEmployeeSchedules[i].name == name) return i;
            }
            return -1;
        }
        private void scheduleSlider(object sender, EventArgs e)
        {
            if (!slider)
            {
                pnlSliderSelect.BackColor = Color.DodgerBlue;
                pnlTableSelect.BackColor = Color.Transparent;
                pnlTable.Visible = false;
                foreach (TimePicker timepicker in timepickers)
                {
                    timepicker.showToolTip();
                }
                slider = !slider;
            }
        }

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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            List<string> times = new List<string>();
            foreach (TimePicker timepicker in timepickers)
            {
                times.Add(timepicker.getJsonData());
            }
            MessageBox.Show(JsonConvert.SerializeObject(times));
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSchedules();
            previousSelect = cmbDay.SelectedItem.ToString();
        }

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

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialTabControl1.SelectedIndex)
            {
                case 2: 
                    foreach (TimePicker timepicker in timepickers)
                    {
                        timepicker.showToolTip();
                    }
                    break;
                default:
                    foreach (TimePicker timepicker in timepickers)
                    {
                        timepicker.hideToolTip();
                    }
                    break;
            }
        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userToDelete = listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].SubItems[1].Text;
            msgbox confirm = new msgbox("Are you sure you want to delete the user '" + userToDelete + "'. This cannot be undone.",
                "Are you sure?", 2);
            if (confirm.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show(Server.deleteUser(activeUser, userToDelete));
                listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].Remove();
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
            Employee[] employees = Server.getEmployees(activeUser);

            for (int i = 0; i < employees.Length; i++)
            {
                var tempItem = new[] { employees[i].name, employees[i].username, employees[i].perm };
                var item = new ListViewItem(tempItem);
                listEmployees.Items.Add(item);
            }
        }

        public static addForm edit = null;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedUser = listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].SubItems[1].Text;
            Employee employeeToEdit = null;

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

        private void updateList()
        {
            listEmployees.Items.Clear();

            foreach (Employee emp in employees)
            {
                var tempItem = new[] { emp.name, emp.username, emp.perm };
                var item = new ListViewItem(tempItem);
                listEmployees.Items.Add(item);
            }
        }

        private void timerAdd_Tick(object sender, EventArgs e)
        {
            if (add == null)
            {
                employees = Server.getEmployees(activeUser);
                timerAdd.Stop();
                updateList();
            } 
        }

        private void timerEdit_Tick(object sender, EventArgs e)
        {
            if (edit == null)
            {
                employees = Server.getEmployees(activeUser);
                timerEdit.Stop();
                updateList();
            } 
        }
    }
}
