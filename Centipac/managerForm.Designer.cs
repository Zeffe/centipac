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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGenerate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEnlarge = new MaterialSkin.Controls.MaterialRaisedButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listCustomers = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtDay = new System.Windows.Forms.DateTimePicker();
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
            this.btnReload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnScheduleReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlTableSelect = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.pnlSliderSelect = new System.Windows.Forms.Panel();
            this.lblSlider = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRuler1 = new MaterialSkin.Controls.MaterialRuler();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.listSchedule = new MaterialSkin.Controls.MaterialListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMonday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cWednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cThursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFriday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSaturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSunday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabScheduleReport = new System.Windows.Forms.TabPage();
            this.btnNewWindow = new MaterialSkin.Controls.MaterialRaisedButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.timerAdd = new System.Windows.Forms.Timer(this.components);
            this.timerEdit = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserScheduleBindingSource)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlTableSelect.SuspendLayout();
            this.pnlSliderSelect.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.tabScheduleReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(Centipac.Customer);
            // 
            // UserScheduleBindingSource
            // 
            this.UserScheduleBindingSource.DataSource = typeof(Centipac.UserSchedule);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabMain;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(837, 51);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabScheduleReport);
            this.tabMain.Depth = 0;
            this.tabMain.Location = new System.Drawing.Point(0, 114);
            this.tabMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(837, 363);
            this.tabMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Controls.Add(this.btnEnlarge);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.dtEnd);
            this.tabPage1.Controls.Add(this.dtStart);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.listCustomers);
            this.tabPage1.Controls.Add(this.dtDay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Depth = 0;
            this.btnGenerate.Icon = null;
            this.btnGenerate.Location = new System.Drawing.Point(321, 105);
            this.btnGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Primary = true;
            this.btnGenerate.Size = new System.Drawing.Size(83, 23);
            this.btnGenerate.TabIndex = 41;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnlarge.Depth = 0;
            this.btnEnlarge.Icon = null;
            this.btnEnlarge.Location = new System.Drawing.Point(6, 105);
            this.btnEnlarge.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Primary = true;
            this.btnEnlarge.Size = new System.Drawing.Size(71, 23);
            this.btnEnlarge.TabIndex = 40;
            this.btnEnlarge.Text = "Enlarge";
            this.btnEnlarge.UseVisualStyleBackColor = true;
            this.btnEnlarge.Click += new System.EventHandler(this.btnEnlarge_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Centipac.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(398, 207);
            this.reportViewer1.TabIndex = 39;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(174, 71);
            this.dtEnd.MaxDate = new System.DateTime(2050, 2, 20, 0, 0, 0, 0);
            this.dtEnd.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(204, 20);
            this.dtEnd.TabIndex = 38;
            this.dtEnd.Value = new System.DateTime(2017, 2, 20, 0, 0, 0, 0);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(174, 42);
            this.dtStart.MaxDate = new System.DateTime(2050, 2, 20, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(204, 20);
            this.dtStart.TabIndex = 37;
            this.dtStart.Value = new System.DateTime(2017, 2, 20, 0, 0, 0, 0);
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 71);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "End Date: ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "Start Date: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Report:";
            // 
            // listCustomers
            // 
            this.listCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listCustomers.Depth = 0;
            this.listCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listCustomers.FullRowSelect = true;
            this.listCustomers.Location = new System.Drawing.Point(410, 32);
            this.listCustomers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listCustomers.MouseState = MaterialSkin.MouseState.OUT;
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.OwnerDraw = true;
            this.listCustomers.Size = new System.Drawing.Size(411, 297);
            this.listCustomers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listCustomers.TabIndex = 1;
            this.listCustomers.UseCompatibleStateImageBehavior = false;
            this.listCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Registrant";
            this.columnHeader5.Width = 163;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Employee";
            this.columnHeader6.Width = 153;
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(523, 6);
            this.dtDay.MaxDate = new System.DateTime(2050, 2, 20, 0, 0, 0, 0);
            this.dtDay.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(204, 20);
            this.dtDay.TabIndex = 0;
            this.dtDay.Value = new System.DateTime(2017, 2, 20, 0, 0, 0, 0);
            this.dtDay.ValueChanged += new System.EventHandler(this.dtDay_ValueChanged);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.materialFlatButton1.Location = new System.Drawing.Point(104, 295);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Edit Ranks";
            this.toolTip1.SetToolTip(this.materialFlatButton1, "Feature currently disabled.");
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
            this.listRanks.Size = new System.Drawing.Size(264, 129);
            this.listRanks.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listRanks.TabIndex = 6;
            this.listRanks.UseCompatibleStateImageBehavior = false;
            this.listRanks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rank";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Title";
            this.columnHeader8.Width = 175;
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
            this.tabPage3.Controls.Add(this.btnReload);
            this.tabPage3.Controls.Add(this.btnScheduleReport);
            this.tabPage3.Controls.Add(this.pnlTableSelect);
            this.tabPage3.Controls.Add(this.pnlSliderSelect);
            this.tabPage3.Controls.Add(this.lblEndDate);
            this.tabPage3.Controls.Add(this.lblStartDate);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Controls.Add(this.cmbDay);
            this.tabPage3.Controls.Add(this.materialDivider1);
            this.tabPage3.Controls.Add(this.materialRuler1);
            this.tabPage3.Controls.Add(this.pnlTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(829, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReload.Depth = 0;
            this.btnReload.Icon = null;
            this.btnReload.Location = new System.Drawing.Point(4, 279);
            this.btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReload.Name = "btnReload";
            this.btnReload.Primary = true;
            this.btnReload.Size = new System.Drawing.Size(122, 23);
            this.btnReload.TabIndex = 34;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnScheduleReport
            // 
            this.btnScheduleReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScheduleReport.Depth = 0;
            this.btnScheduleReport.Icon = null;
            this.btnScheduleReport.Location = new System.Drawing.Point(4, 308);
            this.btnScheduleReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScheduleReport.Name = "btnScheduleReport";
            this.btnScheduleReport.Primary = true;
            this.btnScheduleReport.Size = new System.Drawing.Size(122, 23);
            this.btnScheduleReport.TabIndex = 33;
            this.btnScheduleReport.Text = "View Report";
            this.btnScheduleReport.UseVisualStyleBackColor = true;
            this.btnScheduleReport.Click += new System.EventHandler(this.btnScheduleReport_Click);
            // 
            // pnlTableSelect
            // 
            this.pnlTableSelect.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableSelect.Controls.Add(this.lblTable);
            this.pnlTableSelect.Location = new System.Drawing.Point(64, 220);
            this.pnlTableSelect.Name = "pnlTableSelect";
            this.pnlTableSelect.Size = new System.Drawing.Size(61, 24);
            this.pnlTableSelect.TabIndex = 31;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(12, 5);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 13);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Table";
            // 
            // pnlSliderSelect
            // 
            this.pnlSliderSelect.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlSliderSelect.Controls.Add(this.lblSlider);
            this.pnlSliderSelect.Location = new System.Drawing.Point(3, 220);
            this.pnlSliderSelect.Name = "pnlSliderSelect";
            this.pnlSliderSelect.Size = new System.Drawing.Size(61, 24);
            this.pnlSliderSelect.TabIndex = 30;
            // 
            // lblSlider
            // 
            this.lblSlider.AutoSize = true;
            this.lblSlider.Location = new System.Drawing.Point(12, 5);
            this.lblSlider.Name = "lblSlider";
            this.lblSlider.Size = new System.Drawing.Size(38, 13);
            this.lblSlider.TabIndex = 0;
            this.lblSlider.Text = "Sliders";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 26);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(26, 13);
            this.lblEndDate.TabIndex = 29;
            this.lblEndDate.Text = "End";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 6);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(29, 13);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Start";
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(3, 250);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(122, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDay.Location = new System.Drawing.Point(3, 47);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(123, 21);
            this.cmbDay.TabIndex = 26;
            this.cmbDay.Text = "Monday";
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
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
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.listSchedule);
            this.pnlTable.Location = new System.Drawing.Point(139, 3);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(683, 328);
            this.pnlTable.TabIndex = 32;
            this.pnlTable.Visible = false;
            // 
            // listSchedule
            // 
            this.listSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cMonday,
            this.cTuesday,
            this.cWednesday,
            this.cThursday,
            this.cFriday,
            this.cSaturday,
            this.cSunday});
            this.listSchedule.Depth = 0;
            this.listSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listSchedule.FullRowSelect = true;
            this.listSchedule.Location = new System.Drawing.Point(3, 10);
            this.listSchedule.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listSchedule.MouseState = MaterialSkin.MouseState.OUT;
            this.listSchedule.Name = "listSchedule";
            this.listSchedule.OwnerDraw = true;
            this.listSchedule.Size = new System.Drawing.Size(676, 322);
            this.listSchedule.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listSchedule.TabIndex = 1;
            this.listSchedule.UseCompatibleStateImageBehavior = false;
            this.listSchedule.View = System.Windows.Forms.View.Details;
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 109;
            // 
            // cMonday
            // 
            this.cMonday.Text = "Mon";
            this.cMonday.Width = 81;
            // 
            // cTuesday
            // 
            this.cTuesday.Text = "Tue";
            this.cTuesday.Width = 86;
            // 
            // cWednesday
            // 
            this.cWednesday.Text = "Wed";
            this.cWednesday.Width = 87;
            // 
            // cThursday
            // 
            this.cThursday.Text = "Thu";
            this.cThursday.Width = 88;
            // 
            // cFriday
            // 
            this.cFriday.Text = "Fri";
            this.cFriday.Width = 67;
            // 
            // cSaturday
            // 
            this.cSaturday.Text = "Sat";
            this.cSaturday.Width = 70;
            // 
            // cSunday
            // 
            this.cSunday.Text = "Sun";
            this.cSunday.Width = 85;
            // 
            // tabScheduleReport
            // 
            this.tabScheduleReport.Controls.Add(this.btnNewWindow);
            this.tabScheduleReport.Controls.Add(this.reportViewer2);
            this.tabScheduleReport.Location = new System.Drawing.Point(4, 22);
            this.tabScheduleReport.Name = "tabScheduleReport";
            this.tabScheduleReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabScheduleReport.Size = new System.Drawing.Size(829, 337);
            this.tabScheduleReport.TabIndex = 3;
            this.tabScheduleReport.Text = "Schedule Report";
            this.tabScheduleReport.UseVisualStyleBackColor = true;
            // 
            // btnNewWindow
            // 
            this.btnNewWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewWindow.Depth = 0;
            this.btnNewWindow.Icon = null;
            this.btnNewWindow.Location = new System.Drawing.Point(589, 6);
            this.btnNewWindow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewWindow.Name = "btnNewWindow";
            this.btnNewWindow.Primary = true;
            this.btnNewWindow.Size = new System.Drawing.Size(237, 23);
            this.btnNewWindow.TabIndex = 41;
            this.btnNewWindow.Text = "Open In Separate Window";
            this.btnNewWindow.UseVisualStyleBackColor = true;
            this.btnNewWindow.Click += new System.EventHandler(this.btnNewWindow_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.UserScheduleBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Centipac.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(6, 35);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(823, 302);
            this.reportViewer2.TabIndex = 40;
            // 
            // timerAdd
            // 
            this.timerAdd.Interval = 1000;
            this.timerAdd.Tick += new System.EventHandler(this.timerAdd_Tick);
            // 
            // timerEdit
            // 
            this.timerEdit.Interval = 1000;
            this.timerEdit.Tick += new System.EventHandler(this.timerEdit_Tick);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 477);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "managerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerForm_FormClosing);
            this.Load += new System.EventHandler(this.managerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserScheduleBindingSource)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlTableSelect.ResumeLayout(false);
            this.pnlTableSelect.PerformLayout();
            this.pnlSliderSelect.ResumeLayout(false);
            this.pnlSliderSelect.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.tabScheduleReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView listEmployees;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialRuler materialRuler1;
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
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.Panel pnlTableSelect;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Panel pnlSliderSelect;
        private System.Windows.Forms.Label lblSlider;
        private System.Windows.Forms.Panel pnlTable;
        private MaterialSkin.Controls.MaterialListView listSchedule;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cMonday;
        private System.Windows.Forms.ColumnHeader cTuesday;
        private System.Windows.Forms.ColumnHeader cWednesday;
        private System.Windows.Forms.ColumnHeader cThursday;
        private System.Windows.Forms.ColumnHeader cFriday;
        private System.Windows.Forms.ColumnHeader cSaturday;
        private System.Windows.Forms.ColumnHeader cSunday;
        private System.Windows.Forms.Timer timerAdd;
        private System.Windows.Forms.Timer timerEdit;
        private System.Windows.Forms.DateTimePicker dtDay;
        private MaterialSkin.Controls.MaterialListView listCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnlarge;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerate;
        private MaterialSkin.Controls.MaterialRaisedButton btnScheduleReport;
        private System.Windows.Forms.TabPage tabScheduleReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource UserScheduleBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewWindow;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialRaisedButton btnReload;
    }
}