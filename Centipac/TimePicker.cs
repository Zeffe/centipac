using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Drawing;
using Newtonsoft.Json;

namespace Centipac
{
    /// <summary>
    /// Object used for selecting periods of time for specific days of the week.
    /// </summary>
    class TimePicker
    {
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar;
        private Form parentForm;
        private Timer timer = new Timer();
        private Label timeLabel = new Label();
        private ToolTip tempDisplay = new ToolTip();
        private MaterialSkin.Controls.MaterialContextMenuStrip menu = new MaterialSkin.Controls.MaterialContextMenuStrip();
        private Label name = new Label();
        private UserSchedule schedule;        

        Dictionary<string, DayValue> dayData = new Dictionary<string, DayValue>();

        /// <summary>
        /// Saves DayValue for a given day in dayData dictionary.
        /// </summary>
        /// <param name="key">Given day of the week as string.</param>
        public void Save(string key)
        {
            if (materialProgressBar.Value != 0 && materialProgressBar.Offset != 0 && labelText != null)
            {
                schedule.setValueSuccess(key, labelText);
                if (!dayData.ContainsKey(key))
                {
                    dayData.Add(key, new DayValue(materialProgressBar.Offset, materialProgressBar.Value, labelText));
                }
                else
                {
                    dayData[key] = new DayValue(materialProgressBar.Offset, materialProgressBar.Value, labelText);
                }
            }
        }

        /// <summary>
        /// Deletes the TimePicker object.
        /// </summary>
        public void Delete()
        {
            materialProgressBar.Visible = false;
            timeLabel.Visible = false;
        }

        /// <summary>
        /// Used to get the name value the TimePicker is associated with.
        /// </summary>
        /// <returns>Name as string.</returns>
        public string getName()
        {
            return name.Text;
        }

        /// <summary>
        /// Populates the TimePicker with given data.
        /// </summary>
        /// <param name="data">Dictionary of days of week to DayValues.</param>
        public void populateData(Dictionary<string, DayValue> data)
        {
            foreach (KeyValuePair<string, DayValue> nd in data)
            {
                schedule.setValueSuccess(nd.Key, nd.Value.text);
            }
            dayData = data;
        }

        /// <summary>
        /// Used to get the UserSchedule object for a TimePicker.
        /// </summary>
        /// <returns>UserSchedule object.</returns>
        public UserSchedule getSchedule()
        {
            return schedule;
        }

        /// <summary>
        /// Used to get JSON data of a TimePicker.
        /// </summary>
        /// <returns>JSON String of information in TimePicker.</returns>
        public string getJsonData()
        {
            Dictionary<string, Dictionary<string, DayValue>> jsonFormat = new Dictionary<string, Dictionary<string, DayValue>>();
            jsonFormat.Add(name.Text, dayData);
            return JsonConvert.SerializeObject(jsonFormat);
        }

        /// <summary>
        /// Used to get JSON object before it is converted to JSON.
        /// </summary>
        /// <returns>Dictionary values ready to be converted to JSON.</returns>
        public object getJsonObj()
        {
            Dictionary<string, Dictionary<string, DayValue>> jsonFormat = new Dictionary<string, Dictionary<string, DayValue>>();
            jsonFormat.Add(name.Text, dayData);
            return jsonFormat;
        }

        public TimePicker()
        {
            timeLabel.Visible = false;
        }

        /// <summary>
        /// Loads the correct values for a given day.
        /// </summary>
        /// <param name="key">Given day of week as string.</param>
        public void Load(string key)
        {
            try
            {
                materialProgressBar.Value = dayData[key].value;
                materialProgressBar.Offset = dayData[key].offset;
                labelPosX = materialProgressBar.Location.X + materialProgressBar.Offset + (materialProgressBar.Value / 2) - (toolTipWidth / 2);
                labelPosY = materialProgressBar.Location.Y - 25 + materialProgressBar.Parent.Parent.Location.Y;
                if (materialProgressBar.Value != 0)
                {
                    timeLabel.Visible = true;
                    timeLabel.Text = dayData[key].text;
                    timeLabel.Location = new Point(getXValue(), getYValue());
                }
            }
            catch { }
        }

        public int getXValue()
        {
            return materialProgressBar.Location.X + materialProgressBar.Offset + (materialProgressBar.Value / 2) - (timeLabel.Width / 2);
        }

        public int getYValue()
        {
            return materialProgressBar.Location.Y - timeLabel.Height - 5;
        }

        public void Clear()
        {
            materialProgressBar.Value = 0;
            materialProgressBar.Offset = 0;
            timeLabel.Visible = false;
        }

        public void HardClear()
        {
            materialProgressBar.Value = 0;
            materialProgressBar.Offset = 0;
            timeLabel.Visible = false;
            dayData.Clear();
            schedule = new UserSchedule(name.Text);
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

        public void showTime()
        {
            timeLabel.Visible = true;
        }

        public void hideTime()
        {
            timeLabel.Visible = false;
        }

        public MaterialSkin.Controls.MaterialProgressBar getBar()
        {
            return materialProgressBar;
        }

        /// <summary>
        /// Creates the label that displays the time selected.
        /// </summary>
        /// <returns>Label.</returns>
        public Label CreateTimeLabel()
        {
            timeLabel.AutoSize = true;
            return timeLabel;
        }

        /// <summary>
        /// Creates the label that displays name next to TimePicker.
        /// </summary>
        /// <param name="_name">Name to display.</param>
        /// <returns>Label.</returns>
        public Label CreateNameLabel(string _name)
        {
            name.Location = new Point(materialProgressBar.Location.X - 75, materialProgressBar.Location.Y - materialProgressBar.Height);
            name.Text = _name;
            schedule = new Centipac.UserSchedule(_name);
            return name;
        }

        /// <summary>
        /// Used to create the MaterialProgressBar object that displays on form.
        /// </summary>
        /// <param name="location">Point where the progress bar will be created.</param>
        /// <param name="width">Width of progress bar.</param>
        /// <param name="parent">Form to create the TimePicker in.</param>
        /// <returns>MaterialProgressBar.</returns>
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
            tempDisplay.Popup += new PopupEventHandler(popUpTemp);
            
            return materialProgressBar;
        }

        private void menuDelete(object sender, EventArgs e)
        {
            materialProgressBar.Value = 0;
            timeLabel.Visible = false;
        }

        private int tempOffset = 0, tempValue = 0;
        private bool fromLeft = false, selecting = false;
        private string initTime, finalTime;

        /// <summary>
        /// Displays time on label as TimePicker is moused over.
        /// </summary>
        /// <param name="sender">materialProgressBar</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Selects time period when mouse is down.
        /// </summary>
        /// <param name="sender">materialProgressBar</param>
        /// <param name="e"></param>
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
                timeLabel.Visible = true;
                timeLabel.Text = initTime;
                timeLabel.Location = new Point(
                    parentForm.PointToClient(Cursor.Position).X - 10,
                    getYValue());
                //label.Show(initTime, parentForm, parentForm.PointToClient(Cursor.Position).X - 10, materialProgressBar.Location.Y + 10);
            }
        }

        /// <summary>
        /// Converts a progressbar value and width to 12 hour time format.
        /// </summary>
        /// <param name="progressBarWidth">Width of the progress bar.</param>
        /// <param name="value">Value of the progress bar.</param>
        /// <returns>Returns a string that tells what time is based as a percent out of 24.</returns>
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

        /// <summary>
        /// Timer used for showing time as you select it.
        /// </summary>
        /// <param name="sender">timer</param>
        /// <param name="e"></param>
        private void timerTick(object sender, EventArgs e)
        {
            finalTime = progressBarTime(materialProgressBar.Width, parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X);
            labelPosX = materialProgressBar.Location.X + materialProgressBar.Offset + (materialProgressBar.Value / 2) - (toolTipWidth / 2);
            labelPosY = materialProgressBar.Location.Y - 25 + materialProgressBar.Parent.Parent.Location.Y;
            if (fromLeft)
            {
                materialProgressBar.Offset = Math.Min(Math.Max(parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Parent.Parent.Location.X, materialProgressBar.Minimum), materialProgressBar.Maximum);
                materialProgressBar.Value = Math.Min(Math.Max(tempValue + (tempOffset - materialProgressBar.Offset), materialProgressBar.Minimum), materialProgressBar.Maximum);
                timeLabel.Visible = true;
                timeLabel.Text = finalTime + " - " + initTime;
                timeLabel.Location = new Point(getXValue(), getYValue());
                labelText = finalTime + " - " + initTime;
            }
            else
            {
                materialProgressBar.Value = Math.Min(Math.Max((parentForm.PointToClient(Cursor.Position).X - materialProgressBar.Location.X - materialProgressBar.Parent.Parent.Location.X - materialProgressBar.Offset), materialProgressBar.Minimum), materialProgressBar.Maximum);
                timeLabel.Visible = true;
                timeLabel.Text = initTime + " - " + finalTime;
                timeLabel.Location = new Point(getXValue(), getYValue());
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
