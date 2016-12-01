/*=======================================================================
  Copyright (C) Lyquidity Solutions Limited.  All rights reserved.
 
  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
  PARTICULAR PURPOSE.

  LYQUIDITY SOLUTIONS LIMITED DOES NOT IMPOSE ANY LIMITATION ON THE
  USE OF THIS CODE AND IT AN BE USED IN COMMERCIAL APPLICATIONS.  LYQUIDIY
  ACCEPTS NO RESPONSIBLY FOR ANY LIABILTY WHATEVER AND WILL NOT PROVIDE
  ANY SUPPORT TO USER OR THEIR CLIENTS.
=======================================================================*/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Lyquidity.UtilityLibrary.Controls;

namespace Ruler
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmRulerDemo : System.Windows.Forms.Form
	{
		private Lyquidity.UtilityLibrary.Controls.RulerControl hrulerControl;
		private System.Windows.Forms.GroupBox fraWord;
		private Lyquidity.UtilityLibrary.Controls.RulerControl rulerControl3;
		private System.Windows.Forms.Label label3;
		private Lyquidity.UtilityLibrary.Controls.RulerControl rulerControl2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox fraEvents;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblMousePositionUnitsValue;
		private System.Windows.Forms.Label lblMousePositionUnits;
		private System.Windows.Forms.Label lblMousePositionValue;
		private System.Windows.Forms.Label lblMousePosition;
		private System.Windows.Forms.GroupBox fraProperties;
		private System.Windows.Forms.PropertyGrid propertyGrid;
		private System.Windows.Forms.GroupBox fraVert;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private Lyquidity.UtilityLibrary.Controls.RulerControl rulerWord;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRulerDemo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.propertyGrid.SelectedObject = this.hrulerControl;
			this.propertyGrid.CollapseAllGridItems();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.hrulerControl = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.fraWord = new System.Windows.Forms.GroupBox();
			this.rulerWord = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.label3 = new System.Windows.Forms.Label();
			this.rulerControl3 = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.fraVert = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rulerControl2 = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.fraEvents = new System.Windows.Forms.GroupBox();
			this.lblMousePositionUnitsValue = new System.Windows.Forms.Label();
			this.lblMousePositionUnits = new System.Windows.Forms.Label();
			this.lblMousePositionValue = new System.Windows.Forms.Label();
			this.lblMousePosition = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.fraProperties = new System.Windows.Forms.GroupBox();
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.fraWord.SuspendLayout();
			this.fraVert.SuspendLayout();
			this.fraEvents.SuspendLayout();
			this.fraProperties.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// hrulerControl
			// 
			this.hrulerControl.ActualSize = true;
			this.hrulerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.hrulerControl.BackColor = System.Drawing.Color.Khaki;
			this.hrulerControl.DivisionMarkFactor = 5;
			this.hrulerControl.Divisions = 10;
			this.hrulerControl.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hrulerControl.Location = new System.Drawing.Point(112, 16);
			this.hrulerControl.MajorInterval = 1;
			this.hrulerControl.MiddleMarkFactor = 3;
			this.hrulerControl.MouseTrackingOn = true;
			this.hrulerControl.Name = "hrulerControl";
			this.hrulerControl.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orHorizontal;
			this.hrulerControl.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raBottomOrRight;
			this.hrulerControl.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smCentimetres;
			this.hrulerControl.Size = new System.Drawing.Size(488, 32);
			this.hrulerControl.StartValue = 0;
			this.hrulerControl.TabIndex = 0;
			this.hrulerControl.VerticalNumbers = false;
			this.hrulerControl.ZoomFactor = 1;
			this.hrulerControl.HooverValue += new Lyquidity.UtilityLibrary.Controls.RulerControl.HooverValueEvent(this.hrulerControl_HooverValue);
			// 
			// fraWord
			// 
			this.fraWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fraWord.Controls.Add(this.rulerWord);
			this.fraWord.Controls.Add(this.label3);
			this.fraWord.Controls.Add(this.rulerControl3);
			this.fraWord.Location = new System.Drawing.Point(112, 296);
			this.fraWord.Name = "fraWord";
			this.fraWord.Size = new System.Drawing.Size(488, 88);
			this.fraWord.TabIndex = 21;
			this.fraWord.TabStop = false;
			this.fraWord.Text = "Word ruler style";
			// 
			// rulerWord
			// 
			this.rulerWord.ActualSize = true;
			this.rulerWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.rulerWord.DivisionMarkFactor = 10;
			this.rulerWord.Divisions = 5;
			this.rulerWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rulerWord.ForeColor = System.Drawing.Color.Black;
			this.rulerWord.Location = new System.Drawing.Point(8, 56);
			this.rulerWord.MajorInterval = 36;
			this.rulerWord.MiddleMarkFactor = 8;
			this.rulerWord.MouseTrackingOn = true;
			this.rulerWord.Name = "rulerWord";
			this.rulerWord.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orHorizontal;
			this.rulerWord.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raMiddle;
			this.rulerWord.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
			this.rulerWord.Size = new System.Drawing.Size(472, 20);
			this.rulerWord.StartValue = -72;
			this.rulerWord.TabIndex = 12;
			this.rulerWord.Text = "rulerControl1";
			this.rulerWord.VerticalNumbers = false;
			this.rulerWord.ZoomFactor = 1;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(464, 32);
			this.label3.TabIndex = 11;
			this.label3.Text = "You can create rulers in many styles by using the properties.  This one is pretty" +
				" close to the ruler in the Word ruler bar (set the Word scale option to Points t" +
				"o compare)";
			// 
			// rulerControl3
			// 
			this.rulerControl3.ActualSize = true;
			this.rulerControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.rulerControl3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rulerControl3.DivisionMarkFactor = 10;
			this.rulerControl3.Divisions = 5;
			this.rulerControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rulerControl3.ForeColor = System.Drawing.Color.Black;
			this.rulerControl3.Location = new System.Drawing.Point(16, 128);
			this.rulerControl3.MajorInterval = 36;
			this.rulerControl3.MiddleMarkFactor = 10;
			this.rulerControl3.MouseTrackingOn = true;
			this.rulerControl3.Name = "rulerControl3";
			this.rulerControl3.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orHorizontal;
			this.rulerControl3.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raMiddle;
			this.rulerControl3.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
			this.rulerControl3.Size = new System.Drawing.Size(968, 32);
			this.rulerControl3.StartValue = 0;
			this.rulerControl3.TabIndex = 10;
			this.rulerControl3.VerticalNumbers = false;
			this.rulerControl3.ZoomFactor = 2;
			// 
			// fraVert
			// 
			this.fraVert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fraVert.Controls.Add(this.label5);
			this.fraVert.Controls.Add(this.rulerControl2);
			this.fraVert.Location = new System.Drawing.Point(8, 8);
			this.fraVert.Name = "fraVert";
			this.fraVert.Size = new System.Drawing.Size(96, 376);
			this.fraVert.TabIndex = 24;
			this.fraVert.TabStop = false;
			this.fraVert.Text = "Vertical";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(8, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 40);
			this.label5.TabIndex = 12;
			this.label5.Text = "They can be horizontal and any width";
			// 
			// rulerControl2
			// 
			this.rulerControl2.ActualSize = true;
			this.rulerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.rulerControl2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.rulerControl2.DivisionMarkFactor = 5;
			this.rulerControl2.Divisions = 10;
			this.rulerControl2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rulerControl2.Location = new System.Drawing.Point(8, 24);
			this.rulerControl2.MajorInterval = 1;
			this.rulerControl2.MiddleMarkFactor = 3;
			this.rulerControl2.MouseTrackingOn = false;
			this.rulerControl2.Name = "rulerControl2";
			this.rulerControl2.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orVertical;
			this.rulerControl2.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raTopOrLeft;
			this.rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smInches;
			this.rulerControl2.Size = new System.Drawing.Size(80, 280);
			this.rulerControl2.StartValue = 0;
			this.rulerControl2.TabIndex = 11;
			this.rulerControl2.VerticalNumbers = false;
			this.rulerControl2.ZoomFactor = 1;
			// 
			// fraEvents
			// 
			this.fraEvents.Controls.Add(this.lblMousePositionUnitsValue);
			this.fraEvents.Controls.Add(this.lblMousePositionUnits);
			this.fraEvents.Controls.Add(this.lblMousePositionValue);
			this.fraEvents.Controls.Add(this.lblMousePosition);
			this.fraEvents.Controls.Add(this.label6);
			this.fraEvents.Location = new System.Drawing.Point(112, 56);
			this.fraEvents.Name = "fraEvents";
			this.fraEvents.Size = new System.Drawing.Size(192, 144);
			this.fraEvents.TabIndex = 25;
			this.fraEvents.TabStop = false;
			this.fraEvents.Text = "Events";
			// 
			// lblMousePositionUnitsValue
			// 
			this.lblMousePositionUnitsValue.Location = new System.Drawing.Point(136, 112);
			this.lblMousePositionUnitsValue.Name = "lblMousePositionUnitsValue";
			this.lblMousePositionUnitsValue.Size = new System.Drawing.Size(40, 16);
			this.lblMousePositionUnitsValue.TabIndex = 9;
			this.lblMousePositionUnitsValue.Text = "0";
			this.lblMousePositionUnitsValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblMousePositionUnits
			// 
			this.lblMousePositionUnits.Location = new System.Drawing.Point(8, 112);
			this.lblMousePositionUnits.Name = "lblMousePositionUnits";
			this.lblMousePositionUnits.Size = new System.Drawing.Size(128, 16);
			this.lblMousePositionUnits.TabIndex = 8;
			this.lblMousePositionUnits.Text = "Mouse Position (Units):";
			// 
			// lblMousePositionValue
			// 
			this.lblMousePositionValue.Location = new System.Drawing.Point(136, 88);
			this.lblMousePositionValue.Name = "lblMousePositionValue";
			this.lblMousePositionValue.Size = new System.Drawing.Size(40, 16);
			this.lblMousePositionValue.TabIndex = 7;
			this.lblMousePositionValue.Text = "0";
			this.lblMousePositionValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblMousePosition
			// 
			this.lblMousePosition.Location = new System.Drawing.Point(8, 88);
			this.lblMousePosition.Name = "lblMousePosition";
			this.lblMousePosition.Size = new System.Drawing.Size(128, 16);
			this.lblMousePosition.TabIndex = 6;
			this.lblMousePosition.Text = "Mouse Position (Pixels):";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 56);
			this.label6.TabIndex = 0;
			this.label6.Text = "An event is fired as the mouse moves.  You can retrieve the mouse position in pix" +
				"els or in units of the scale being used";
			// 
			// fraProperties
			// 
			this.fraProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fraProperties.Controls.Add(this.propertyGrid);
			this.fraProperties.Location = new System.Drawing.Point(312, 56);
			this.fraProperties.Name = "fraProperties";
			this.fraProperties.Size = new System.Drawing.Size(288, 240);
			this.fraProperties.TabIndex = 27;
			this.fraProperties.TabStop = false;
			this.fraProperties.Text = "Property Grid";
			// 
			// propertyGrid
			// 
			this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid.CommandsVisibleIfAvailable = true;
			this.propertyGrid.LargeButtons = false;
			this.propertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid.Location = new System.Drawing.Point(8, 24);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size(272, 208);
			this.propertyGrid.TabIndex = 0;
			this.propertyGrid.Text = "propertyGrid1";
			this.propertyGrid.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(112, 208);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 80);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Properties";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "See the Ruler category for a list of all the exposed properties and to examine th" +
				"eir effects. -->";
			// 
			// frmRulerDemo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 390);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.fraProperties);
			this.Controls.Add(this.fraEvents);
			this.Controls.Add(this.fraVert);
			this.Controls.Add(this.fraWord);
			this.Controls.Add(this.hrulerControl);
			this.Name = "frmRulerDemo";
			this.Text = "Form";
			this.fraWord.ResumeLayout(false);
			this.fraVert.ResumeLayout(false);
			this.fraEvents.ResumeLayout(false);
			this.fraProperties.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmRulerDemo());
		}

		private void hrulerControl_HooverValue(object sender, Lyquidity.UtilityLibrary.Controls.RulerControl.HooverValueEventArgs e)
		{
			this.lblMousePositionUnitsValue.Text = e.Value.ToString("0.0");
			this.lblMousePositionValue.Text = this.hrulerControl.MouseLocation.ToString();
		}
	}
}
