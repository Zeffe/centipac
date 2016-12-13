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
                listEmployees.Items.Add(item);

                timepickers[i] = new TimePicker();

                tabPage3.Controls.Add(timepickers[i].CreateBar(new Point(materialRuler1.Location.X, materialRuler1.Location.Y + (60 * i)), materialRuler1.Width, this));
                tabPage3.Controls.Add(timepickers[i].CreateLabel(employees[i].name));
            }
        }

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
                case 0: btnDelete.Enabled = false; break;
                default: btnDelete.Enabled = true; break;
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
                Server.deleteUser(activeUser, userToDelete);
                listEmployees.SelectedItems[employeeDisplay % listEmployees.SelectedItems.Count].Remove();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            employeeDisplay++;
            displayEmployeeInfo(employeeDisplay % listEmployees.SelectedItems.Count);
        }
    }
}
