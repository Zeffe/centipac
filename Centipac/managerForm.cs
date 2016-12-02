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

        Point clickPos;
        int toolTipWidth = 0;
        bool selecting = false;

        private void materialProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            materialProgressBar1.Offset = this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X - materialTabControl1.Location.X;
            timer1.Start();
            selecting = true;
            toolTipTime.Show(materialProgressBar1.Value.ToString(), this, this.PointToClient(Cursor.Position).X - 10, materialProgressBar1.Location.Y + 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            materialProgressBar1.Value = Math.Min(Math.Max((this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X - materialTabControl1.Location.X - materialProgressBar1.Offset), materialProgressBar1.Minimum), materialProgressBar1.Maximum);
            toolTipTime.Show((materialProgressBar1.Value + materialProgressBar1.Offset).ToString(), 
                this, 
                materialProgressBar1.Location.X + materialProgressBar1.Offset + (materialProgressBar1.Value / 2) - (toolTipWidth / 2), // ToolTip X
                materialProgressBar1.Location.Y - 25 + materialTabControl1.Location.Y);                                                // ToolTip Y
        }

        private void materialProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            toolTipTime.Hide(this);
            selecting = false;
        }

        private void managerForm_Load(object sender, EventArgs e)
        {
            materialProgressBar1.Maximum = materialProgressBar1.Width;
        }

        private void toolTipTime_Popup(object sender, PopupEventArgs e)
        {
            toolTipWidth = e.ToolTipSize.Width;
        }

        private string progressBarTime(int progressBarWidth, int value)
        {
            string _temp = "";
            float pixelsPerHour = progressBarWidth / 24;
            float militaryTime = value / pixelsPerHour;

            switch (militaryTime > 12)
            {
                case false: _temp = TimeSpan.FromHours(militaryTime).ToString("h\\:mm") + " A.M.";
                    break;
                case true: _temp = TimeSpan.FromHours(militaryTime - 12).ToString("h\\:mm") + " P.M."; break;
            }

            return _temp;
        }

        private void materialProgressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!selecting)
            {
                toolTipTime.Show(progressBarTime(materialProgressBar1.Width, this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X), // (this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X).ToString()
                    this,
                    this.PointToClient(Cursor.Position).X - (toolTipWidth / 2),
                    materialProgressBar1.Location.Y - 25 + materialTabControl1.Location.Y);
            }
        }

        private void materialProgressBar1_MouseLeave(object sender, EventArgs e)
        {
            if (!selecting)
            {
                toolTipTime.Hide(this);
            }
        }
    }
}
