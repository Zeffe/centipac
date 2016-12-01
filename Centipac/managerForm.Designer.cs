namespace Centipac
{
    partial class managerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ayy",
            "lmao"}, -1);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialRuler1 = new MaterialSkin.Controls.MaterialRuler();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(770, 51);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 114);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(770, 315);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.materialListView1.Location = new System.Drawing.Point(223, 29);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(323, 205);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employees";
            this.columnHeader1.Width = 306;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialRuler1);
            this.tabPage3.Controls.Add(this.trackBar1);
            this.tabPage3.Controls.Add(this.materialProgressBar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialRuler1
            // 
            this.materialRuler1.ActualSize = true;
            this.materialRuler1.Depth = 0;
            this.materialRuler1.DivisionMarkFactor = 2;
            this.materialRuler1.Divisions = 3;
            this.materialRuler1.ForeColor = System.Drawing.Color.Black;
            this.materialRuler1.Location = new System.Drawing.Point(212, 71);
            this.materialRuler1.MajorInterval = 1;
            this.materialRuler1.MiddleMarkFactor = 2;
            this.materialRuler1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRuler1.MouseTrackingOn = true;
            this.materialRuler1.Name = "materialRuler1";
            this.materialRuler1.Orientation = MaterialSkin.Controls.enumOrientation.orHorizontal;
            this.materialRuler1.RulerAlignment = MaterialSkin.Controls.enumRulerAlignment.raBottomOrRight;
            this.materialRuler1.ScaleMode = MaterialSkin.Controls.enumScaleMode.smMillimetres;
            this.materialRuler1.Size = new System.Drawing.Size(540, 31);
            this.materialRuler1.StartValue = -0.5D;
            this.materialRuler1.TabIndex = 24;
            this.materialRuler1.Text = "materialRuler1";
            this.materialRuler1.UseTime = true;
            this.materialRuler1.VerticalNumbers = false;
            this.materialRuler1.ZoomFactor = 4D;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(195, 20);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(291, 45);
            this.trackBar1.TabIndex = 23;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(225, 142);
            this.materialProgressBar1.Maximum = 390;
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Offset = 0;
            this.materialProgressBar1.Size = new System.Drawing.Size(527, 5);
            this.materialProgressBar1.TabIndex = 22;
            this.materialProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialProgressBar1_MouseDown);
            this.materialProgressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.materialProgressBar1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 441);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "managerForm";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerForm_FormClosing);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private MaterialSkin.Controls.MaterialRuler materialRuler1;
    }
}