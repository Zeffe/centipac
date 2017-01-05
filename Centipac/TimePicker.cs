using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Drawing;

namespace Centipac
{
    class TimePicker
    {
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar;
        private Form parentForm;
        private Timer timer = new Timer();
        private ToolTip label = new ToolTip();
        private ToolTip tempDisplay = new ToolTip();
        private ContextMenuStrip menu = new ContextMenuStrip();
        private Label name = new Label();

        Dictionary<string, KeyValuePair<int, int>> dayTimes = new Dictionary<string, KeyValuePair<int, int>>();
        Dictionary<string, string> dayTexts = new Dictionary<string, string>();

        public void Save(string key)
        {
            if (!dayTexts.ContainsKey(key))
            {
                dayTimes.Add(key, new KeyValuePair<int, int>(materialProgressBar.Value, materialProgressBar.Offset));
                dayTexts.Add(key, labelText);
            } else
            {
                dayTimes[key] = new KeyValuePair<int, int>(materialProgressBar.Value, materialProgressBar.Offset);
                dayTexts[key] = labelText;
            }
        }

        public void Load(string key)
        {
            try
            {
                materialProgressBar.Value = dayTimes[key].Key;
                materialProgressBar.Offset = dayTimes[key].Value;
                labelPosX = materialProgressBar.Location.X + materialProgressBar.Offset + (materialProgressBar.Value / 2) - (toolTipWidth / 2);
                labelPosY = materialProgressBar.Location.Y - 25 + materialProgressBar.Parent.Parent.Location.Y;
                if (materialProgressBar.Value != 0)
                {
                    label.Show(dayTexts[key],
                        parentForm,
                        labelPosX,
                        labelPosY);
                }
            }
            catch { }
        }

        public void Clear()
        {
            materialProgressBar.Value = 0;
            materialProgressBar.Offset = 0;
            label.Hide(parentForm);
        }

        public string beginTime()
        {
            return initTime;
        }

        public string endTime()
        {
            return finalTime;
        }

        public Label getLabel()
        {
            return name;
        }

        public void showToolTip()
        {
            label.Show(labelText, parentForm, labelPosX, labelPosY);
        }

        public void hideToolTip()
        {
            label.Hide(parentForm);
        }

        public MaterialSkin.Controls.MaterialProgressBar getBar()
        {
            return materialProgressBar;
        }

        public Label CreateLabel(string _name)
        {
            name.Location = new Point(materialProgressBar.Location.X - 75, materialProgressBar.Location.Y - materialProgressBar.Height);
            name.Text = _name;
            return name;
        }

        public MaterialSkin.Controls.MaterialProgressBar CreateBar(Point location, int width, Form parent)
        {
            menu.Items.Add("Delete", null, menuDelete);
            materialProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            materialProgressBar.Location = location;
            materialProgressBar.Width = width;
            materialProgressBar.Maximum = width;
            materialProgressBar.Cursor = Cursors.SizeWE;
            materialProgressBar.ContextMenuStrip = menu;
            parentForm = parent;
            materialProgressBar.MouseMove += new MouseEventHandler(mouseMove);
            materialProgressBar.MouseLeave += new EventHandler(mouseLeave);
            materialProgressBar.MouseDown += new MouseEventHandler(mouseDown);
            materialProgressBar.MouseUp += new MouseEventHandler(mouseUp);
            timer.Tick += new EventHandler(timerTick);
            label.Popup += new PopupEventHandler(popUp);
            tempDisplay.Popup += new PopupEventHandler(popUpTemp);
            
            return materialProgressBar;
        }

        private void menuDelete(object sender, EventArgs e)
        {
            materialProgressBar.Value = 0;
            label.Hide(parentForm);
        }

        private int tempOffset = 0, tempValue = 0;
        private bool fromLeft = false, selecting = false;
        private string initTime, finalTime;

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (!selecting)
            {
                tempDisplay.Show(progressBarTime(materialProgressBar.Width, parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X), // (this.PointToClient(Cursor.Position).X - materialProgressBar1.Location.X).ToString()
                    parentForm,
                    parentForm.PointToClient(Cursor.Position).X - (toolTipWidthTemp / 2),
                    materialProgressBar.Location.Y - 25 + materialProgressBar.Parent.Parent.Location.Y);
            }

            if (materialProgressBar.Value > 0)
            {
                if (parentForm.PointToClient(Cursor.Position).X > materialProgressBar.Location.X + materialProgressBar.Offset + materialProgressBar.Parent.Parent.Location.X &&
                    parentForm.PointToClient(Cursor.Position).X < materialProgressBar.Location.X + materialProgressBar.Offset + materialProgressBar.Parent.Parent.Location.X + materialProgressBar.Value)
                {
                    materialProgressBar.Cursor = Cursors.SizeWE;
                }
                else
                {
                    materialProgressBar.Cursor = Cursors.Default;
                }
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (!selecting)
            {
                tempDisplay.Hide(parentForm);
            }
        }        

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (materialProgressBar.Value > 0)
                {
                    if (parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Offset >
                        materialProgressBar.Value / 2)
                    {
                        materialProgressBar.Value = parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Offset - materialProgressBar.Parent.Parent.Location.X;
                    }
                    else
                    {
                        tempOffset = materialProgressBar.Offset; tempValue = materialProgressBar.Value;
                        materialProgressBar.Offset = parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X;
                        fromLeft = true;
                    }
                }
                else
                {
                    materialProgressBar.Offset = parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Parent.Parent.Location.X;
                }

                timer.Start();
                tempDisplay.Hide(parentForm);
                selecting = true;
                if (fromLeft)
                {
                    initTime = progressBarTime(materialProgressBar.Width, materialProgressBar.Value + tempOffset);
                }
                else if (materialProgressBar.Value > 0)
                {
                    initTime = progressBarTime(materialProgressBar.Width, materialProgressBar.Offset);
                }
                else
                {
                    initTime = progressBarTime(materialProgressBar.Width, parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X);
                }
                label.Show(initTime, parentForm, parentForm.PointToClient(Cursor.Position).X - 10, materialProgressBar.Location.Y + 10);
            }
        }

        private string progressBarTime(int progressBarWidth, int value)
        {
            string _temp = "";
            float pixelsPerHour = progressBarWidth / 24;
            float militaryTime = value / pixelsPerHour;
            int amountToAdd = 0;

            if ((int)(militaryTime % 12) == 0)
            {
                amountToAdd = 12;
            }

            switch (militaryTime > 12 && militaryTime > 0)
            {
                case false:
                    _temp = TimeSpan.FromHours(Math.Round((militaryTime + amountToAdd) * 12) / 12).ToString("h\\:mm") + " A.M.";
                    break;
                case true: _temp = TimeSpan.FromHours(Math.Round((militaryTime - 12 + amountToAdd) * 12) / 12).ToString("h\\:mm") + " P.M."; break;
            }

            return _temp;
        }

        private int labelPosX, labelPosY;
        private int toolTipWidth = 0, toolTipWidthTemp = 0;
        private string labelText;

        private void popUp(object sender, PopupEventArgs e)
        {
            toolTipWidth = e.ToolTipSize.Width;
        }

        private void popUpTemp(object sender, PopupEventArgs e)
        {
            toolTipWidthTemp = e.ToolTipSize.Width;            
        }

        private void timerTick(object sender, EventArgs e)
        {
            finalTime = progressBarTime(materialProgressBar.Width, parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X);
            labelPosX = materialProgressBar.Location.X + materialProgressBar.Offset + (materialProgressBar.Value / 2) - (toolTipWidth / 2);
            labelPosY = materialProgressBar.Location.Y - 25 + materialProgressBar.Parent.Parent.Location.Y;
            if (fromLeft)
            {
                materialProgressBar.Offset = Math.Min(Math.Max(parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Parent.Parent.Location.X, materialProgressBar.Minimum), materialProgressBar.Maximum);
                materialProgressBar.Value = Math.Min(Math.Max(tempValue + (tempOffset - materialProgressBar.Offset), materialProgressBar.Minimum), materialProgressBar.Maximum);
                label.Show(finalTime + " - " + initTime,
                    parentForm,
                    labelPosX,
                    labelPosY);
                labelText = finalTime + " - " + initTime;
            }
            else
            {
                materialProgressBar.Value = Math.Min(Math.Max((parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Parent.Parent.Location.X - materialProgressBar.Offset), materialProgressBar.Minimum), materialProgressBar.Maximum);

                label.Show(initTime + " - " + finalTime,
                parentForm,
                labelPosX,
                labelPosY);
                labelText = initTime + " - " + finalTime;
            }
        }

        private void mouseUp(object sender, EventArgs e)
        {
            fromLeft = false;
            timer.Stop();
            selecting = false;
        }
    }
}
