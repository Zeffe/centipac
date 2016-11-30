﻿using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

			// Add dummy data to the listview
	        seedListView();
        }

	    private void seedListView()
	    {
			//Define
			var data = new[]
	        {
		        new []{"Lollipop", "392", "0.2", "0"},
				new []{"KitKat", "518", "26.0", "7"},
				new []{"Ice cream sandwich", "237", "9.0", "4.3"},
				new []{"Jelly Bean", "375", "0.0", "0.0"},
				new []{"Honeycomb", "408", "3.2", "6.5"}
	        };

			//Add
			foreach (string[] version in data)
			{
				var item = new ListViewItem(version);
				materialListView1.Items.Add(item);
			}
	    }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

	    private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
	        colorSchemeIndex++;
	        if (colorSchemeIndex > 2) colorSchemeIndex = 0;

			//These are just example color schemes
	        switch (colorSchemeIndex)
	        {
				case 0:
					materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			        break;
				case 1:
					materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
			        break;
				case 2:
					materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
					break;
	        }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 10, 100);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            materialProgressBar1.Value = Math.Max(materialProgressBar1.Value - 10, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaterialFlatButton user = new MaterialFlatButton();
            user.BackColor = ((int)Primary.BlueGrey800).ToColor();
            user.ForeColor = Color.White;
            user.useBackColor = true;
            user.useForeColor = true;
            user.Location = new System.Drawing.Point(414, 25);
            user.Text = "Zeffer";
            this.Controls.Add(user);

            materialGroupBox1.Location = new Point(414, 20 + user.Height);
            materialGroupBox1.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
        }

        Point clickPos;

        private void materialProgressBar2_MouseDown(object sender, MouseEventArgs e)
        {
            materialProgressBar2.Offset = this.PointToClient(Cursor.Position).X - materialProgressBar2.Location.X - materialTabControl1.Location.X;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            materialProgressBar2.Value = Math.Min(Math.Max((this.PointToClient(Cursor.Position).X - materialProgressBar2.Location.X - materialTabControl1.Location.X - materialProgressBar2.Offset), 0), materialProgressBar2.Maximum);
        }

        private void materialProgressBar2_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}
