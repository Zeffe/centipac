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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNext = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.listRanks = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.listEmployees = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRuler1 = new MaterialSkin.Controls.MaterialRuler();
            this.menuProgressBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(837, 51);
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
            this.materialTabControl1.Size = new System.Drawing.Size(837, 363);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.materialFlatButton1);
            this.tabPage2.Controls.Add(this.listRanks);
            this.tabPage2.Controls.Add(this.lblTitle);
            this.tabPage2.Controls.Add(this.lblUsername);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.lblHeader);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.listEmployees);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(553, 290);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Primary = false;
            this.btnRefresh.Size = new System.Drawing.Size(79, 36);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.useBackColor = false;
            this.btnRefresh.useForeColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Enabled = false;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(315, 245);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(50, 36);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.useBackColor = false;
            this.btnEdit.useForeColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(317, 197);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(48, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.useBackColor = false;
            this.btnAdd.useForeColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Enabled = false;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(310, 112);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = false;
            this.btnNext.Size = new System.Drawing.Size(55, 36);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.useBackColor = false;
            this.btnNext.useForeColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(51, 290);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Edit Ranks";
            this.materialFlatButton1.useBackColor = false;
            this.materialFlatButton1.useForeColor = false;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // listRanks
            // 
            this.listRanks.AutoArrange = false;
            this.listRanks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRanks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listRanks.Depth = 0;
            this.listRanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listRanks.FullRowSelect = true;
            this.listRanks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listRanks.Location = new System.Drawing.Point(13, 157);
            this.listRanks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listRanks.MouseState = MaterialSkin.MouseState.OUT;
            this.listRanks.Name = "listRanks";
            this.listRanks.OwnerDraw = true;
            this.listRanks.Size = new System.Drawing.Size(168, 124);
            this.listRanks.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listRanks.TabIndex = 6;
            this.listRanks.UseCompatibleStateImageBehavior = false;
            this.listRanks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rank";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Title";
            this.columnHeader8.Width = 81;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(47, 120);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 19);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(9, 87);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(9, 53);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Full Name: ";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Depth = 0;
            this.lblHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(8, 12);
            this.lblHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(145, 19);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Selected Employee: ";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(296, 290);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = false;
            this.btnDelete.Size = new System.Drawing.Size(69, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.useBackColor = false;
            this.btnDelete.useForeColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listEmployees
            // 
            this.listEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listEmployees.Depth = 0;
            this.listEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listEmployees.FullRowSelect = true;
            this.listEmployees.Location = new System.Drawing.Point(372, 6);
            this.listEmployees.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEmployees.MouseState = MaterialSkin.MouseState.OUT;
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.OwnerDraw = true;
            this.listEmployees.Size = new System.Drawing.Size(449, 275);
            this.listEmployees.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listEmployees.TabIndex = 0;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            this.listEmployees.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listEmployees_ColumnClick);
            this.listEmployees.SelectedIndexChanged += new System.EventHandler(this.listEmployees_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Full Name";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rank";
            this.columnHeader3.Width = 95;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.materialDivider1);
            this.tabPage3.Controls.Add(this.materialRuler1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(829, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(132, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 325);
            this.materialDivider1.TabIndex = 25;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRuler1
            // 
            this.materialRuler1.ActualSize = true;
            this.materialRuler1.Depth = 0;
            this.materialRuler1.DivisionMarkFactor = 2;
            this.materialRuler1.Divisions = 2;
            this.materialRuler1.ForeColor = System.Drawing.Color.Black;
            this.materialRuler1.Location = new System.Drawing.Point(215, 6);
            this.materialRuler1.MajorInterval = 1;
            this.materialRuler1.MiddleMarkFactor = 2;
            this.materialRuler1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRuler1.MouseTrackingOn = true;
            this.materialRuler1.Name = "materialRuler1";
            this.materialRuler1.Orientation = MaterialSkin.Controls.enumOrientation.orHorizontal;
            this.materialRuler1.RulerAlignment = MaterialSkin.Controls.enumRulerAlignment.raBottomOrRight;
            this.materialRuler1.ScaleMode = MaterialSkin.Controls.enumScaleMode.smMillimetres;
            this.materialRuler1.Size = new System.Drawing.Size(603, 31);
            this.materialRuler1.StartValue = 0D;
            this.materialRuler1.TabIndex = 24;
            this.materialRuler1.Text = "materialRuler1";
            this.materialRuler1.UseTime = true;
            this.materialRuler1.VerticalNumbers = false;
            this.materialRuler1.ZoomFactor = 4.6D;
            // 
            // menuProgressBar
            // 
            this.menuProgressBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.menuProgressBar.Name = "menuProgressBar";
            this.menuProgressBar.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 477);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "managerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerForm_FormClosing);
            this.Load += new System.EventHandler(this.managerForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.menuProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView listEmployees;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialRuler materialRuler1;
        private System.Windows.Forms.ContextMenuStrip menuProgressBar;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialFlatButton btnDelete;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialListView listRanks;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblHeader;
        private MaterialSkin.Controls.MaterialFlatButton btnNext;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnRefresh;
    }
}