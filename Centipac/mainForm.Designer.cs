namespace Centipac
{
    partial class mainForm
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
            this.tabMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblChildren = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdults = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbAdults = new Xenon.ThirteenComboBox();
            this.cmbChildren = new Xenon.ThirteenComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNewCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinish = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegistrant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancelFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFilter = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listCustomers = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTabControl = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.closeExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupUserOptions = new MaterialSkin.Controls.MaterialGroupBox();
            this.btnManager = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLogOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.btnClock = new System.Windows.Forms.PictureBox();
            this.menuTabPage = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.groupUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).BeginInit();
            this.menuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabMain;
            this.materialTabSelector1.ContextMenuStrip = this.menuTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(586, 35);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Depth = 0;
            this.tabMain.Location = new System.Drawing.Point(0, 100);
            this.tabMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(586, 326);
            this.tabMain.TabIndex = 3;
            this.tabMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialTabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblChildren);
            this.tabPage1.Controls.Add(this.lblAdults);
            this.tabPage1.Controls.Add(this.lblPrice);
            this.tabPage1.Controls.Add(this.materialDivider3);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.cmbAdults);
            this.tabPage1.Controls.Add(this.cmbChildren);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialDivider2);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnNewCustomer);
            this.tabPage1.Controls.Add(this.btnFinish);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtRegistrant);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Depth = 0;
            this.lblChildren.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChildren.Location = new System.Drawing.Point(397, 192);
            this.lblChildren.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(110, 19);
            this.lblChildren.TabIndex = 42;
            this.lblChildren.Text = "Children ($7): 0";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Depth = 0;
            this.lblAdults.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdults.Location = new System.Drawing.Point(397, 154);
            this.lblAdults.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(106, 19);
            this.lblAdults.TabIndex = 41;
            this.lblAdults.Text = "Adults ($10): 0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(397, 229);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 19);
            this.lblPrice.TabIndex = 40;
            this.lblPrice.Text = "Price: $0";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(389, 138);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(2, 153);
            this.materialDivider3.TabIndex = 39;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(150, 232);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 38;
            this.materialLabel4.Text = "Children: ";
            // 
            // cmbAdults
            // 
            this.cmbAdults.AccentColor = System.Drawing.Color.DodgerBlue;
            this.cmbAdults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbAdults.ColorScheme = Xenon.ThirteenComboBox.ColorSchemes.Light;
            this.cmbAdults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAdults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbAdults.ForeColor = System.Drawing.Color.White;
            this.cmbAdults.FormatString = "N0";
            this.cmbAdults.FormattingEnabled = true;
            this.cmbAdults.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10+"});
            this.cmbAdults.Location = new System.Drawing.Point(154, 177);
            this.cmbAdults.Name = "cmbAdults";
            this.cmbAdults.Size = new System.Drawing.Size(194, 23);
            this.cmbAdults.TabIndex = 37;
            this.cmbAdults.SelectedIndexChanged += new System.EventHandler(this.cmbAdults_SelectedIndexChanged);
            // 
            // cmbChildren
            // 
            this.cmbChildren.AccentColor = System.Drawing.Color.DodgerBlue;
            this.cmbChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbChildren.ColorScheme = Xenon.ThirteenComboBox.ColorSchemes.Light;
            this.cmbChildren.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbChildren.ForeColor = System.Drawing.Color.White;
            this.cmbChildren.FormattingEnabled = true;
            this.cmbChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10+"});
            this.cmbChildren.Location = new System.Drawing.Point(154, 254);
            this.cmbChildren.Name = "cmbChildren";
            this.cmbChildren.Size = new System.Drawing.Size(194, 23);
            this.cmbChildren.TabIndex = 36;
            this.cmbChildren.SelectedIndexChanged += new System.EventHandler(this.cmbChildren_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(150, 146);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(198, 19);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Adults (Without Registrant): ";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(122, 130);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(453, 2);
            this.materialDivider2.TabIndex = 34;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(135, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(81, 19);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Registrant:";
            // 
            // lblTime
            // 
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(375, 89);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(194, 23);
            this.lblTime.TabIndex = 32;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(375, 63);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(194, 23);
            this.lblDate.TabIndex = 31;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(418, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Date and Time:";
            // 
            // txtPhone
            // 
            this.txtPhone.Depth = 0;
            this.txtPhone.Hint = "Registrant Phone (optional)";
            this.txtPhone.Location = new System.Drawing.Point(139, 92);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(240, 23);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.TabStop = false;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(6, 272);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(102, 19);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewCustomer.Depth = 0;
            this.btnNewCustomer.Icon = null;
            this.btnNewCustomer.Location = new System.Drawing.Point(6, 6);
            this.btnNewCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Primary = true;
            this.btnNewCustomer.Size = new System.Drawing.Size(102, 36);
            this.btnNewCustomer.TabIndex = 28;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinish.Depth = 0;
            this.btnFinish.Icon = null;
            this.btnFinish.Location = new System.Drawing.Point(437, 272);
            this.btnFinish.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Primary = true;
            this.btnFinish.Size = new System.Drawing.Size(102, 19);
            this.btnFinish.TabIndex = 27;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Registrant Email (optional)";
            this.txtEmail.Location = new System.Drawing.Point(139, 63);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(240, 23);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtRegistrant
            // 
            this.txtRegistrant.Depth = 0;
            this.txtRegistrant.Hint = "Registrant Full Name";
            this.txtRegistrant.Location = new System.Drawing.Point(139, 34);
            this.txtRegistrant.MaxLength = 32767;
            this.txtRegistrant.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegistrant.Name = "txtRegistrant";
            this.txtRegistrant.PasswordChar = '\0';
            this.txtRegistrant.SelectedText = "";
            this.txtRegistrant.SelectionLength = 0;
            this.txtRegistrant.SelectionStart = 0;
            this.txtRegistrant.Size = new System.Drawing.Size(240, 23);
            this.txtRegistrant.TabIndex = 7;
            this.txtRegistrant.TabStop = false;
            this.txtRegistrant.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(114, 3);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 291);
            this.materialDivider1.TabIndex = 26;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(120, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 291);
            this.panel1.TabIndex = 43;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.btnCancelFilter);
            this.tabPage3.Controls.Add(this.btnFilter);
            this.tabPage3.Controls.Add(this.txtFilter);
            this.tabPage3.Controls.Add(this.listCustomers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(578, 300);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Today\'s Customers";
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelFilter.Depth = 0;
            this.btnCancelFilter.Icon = null;
            this.btnCancelFilter.Location = new System.Drawing.Point(547, 274);
            this.btnCancelFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Primary = true;
            this.btnCancelFilter.Size = new System.Drawing.Size(22, 23);
            this.btnCancelFilter.TabIndex = 3;
            this.btnCancelFilter.Text = "X";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Depth = 0;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(296, 274);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Primary = true;
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Depth = 0;
            this.txtFilter.Hint = "Filter";
            this.txtFilter.Location = new System.Drawing.Point(380, 274);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.Size = new System.Drawing.Size(161, 23);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TabStop = false;
            this.txtFilter.UseSystemPasswordChar = false;
            // 
            // listCustomers
            // 
            this.listCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listCustomers.Depth = 0;
            this.listCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listCustomers.FullRowSelect = true;
            this.listCustomers.Location = new System.Drawing.Point(8, 7);
            this.listCustomers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listCustomers.MouseState = MaterialSkin.MouseState.OUT;
            this.listCustomers.MultiSelect = false;
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.OwnerDraw = true;
            this.listCustomers.Size = new System.Drawing.Size(561, 261);
            this.listCustomers.TabIndex = 0;
            this.listCustomers.UseCompatibleStateImageBehavior = false;
            this.listCustomers.View = System.Windows.Forms.View.Details;
            this.listCustomers.DoubleClick += new System.EventHandler(this.listCustomers_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Registrant";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 123;
            // 
            // menuTabControl
            // 
            this.menuTabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuTabControl.Depth = 0;
            this.menuTabControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeExtraToolStripMenuItem});
            this.menuTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.Size = new System.Drawing.Size(132, 26);
            // 
            // closeExtraToolStripMenuItem
            // 
            this.closeExtraToolStripMenuItem.Name = "closeExtraToolStripMenuItem";
            this.closeExtraToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeExtraToolStripMenuItem.Text = "Close Extra";
            this.closeExtraToolStripMenuItem.Click += new System.EventHandler(this.closeExtraToolStripMenuItem_Click);
            // 
            // groupUserOptions
            // 
            this.groupUserOptions.BackColor = System.Drawing.Color.Transparent;
            this.groupUserOptions.Controls.Add(this.btnManager);
            this.groupUserOptions.Controls.Add(this.btnLogOut);
            this.groupUserOptions.Controls.Add(this.btnSettings);
            this.groupUserOptions.Depth = 0;
            this.groupUserOptions.DiamondPos = 50;
            this.groupUserOptions.Location = new System.Drawing.Point(187, 63);
            this.groupUserOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.groupUserOptions.Name = "groupUserOptions";
            this.groupUserOptions.Size = new System.Drawing.Size(97, 144);
            this.groupUserOptions.TabIndex = 4;
            this.groupUserOptions.TabStop = false;
            this.groupUserOptions.Text = "materialGroupBox1";
            this.groupUserOptions.Visible = false;
            this.groupUserOptions.Leave += new System.EventHandler(this.groupUserOptions_Leave);
            // 
            // btnManager
            // 
            this.btnManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManager.Depth = 0;
            this.btnManager.Icon = null;
            this.btnManager.Location = new System.Drawing.Point(6, 100);
            this.btnManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManager.Name = "btnManager";
            this.btnManager.Primary = true;
            this.btnManager.Size = new System.Drawing.Size(85, 36);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(6, 58);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Primary = true;
            this.btnLogOut.Size = new System.Drawing.Size(85, 36);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Depth = 0;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(6, 16);
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Primary = true;
            this.btnSettings.Size = new System.Drawing.Size(85, 36);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // timerUI
            // 
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.Black;
            this.btnClock.Image = global::Centipac.Properties.Resources.clock;
            this.btnClock.Location = new System.Drawing.Point(143, 34);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(24, 26);
            this.btnClock.TabIndex = 6;
            this.btnClock.TabStop = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            this.btnClock.MouseEnter += new System.EventHandler(this.btnClock_MouseEnter);
            this.btnClock.MouseLeave += new System.EventHandler(this.btnClock_MouseLeave);
            // 
            // menuTabPage
            // 
            this.menuTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuTabPage.Depth = 0;
            this.menuTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuTabPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuTabPage.Name = "menuTabPage";
            this.menuTabPage.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(30, 275);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(191, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Double Click to Edit/Delete";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(585, 425);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.groupUserOptions);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centipac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuTabControl.ResumeLayout(false);
            this.groupUserOptions.ResumeLayout(false);
            this.groupUserOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).EndInit();
            this.menuTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialGroupBox groupUserOptions;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogOut;
        private MaterialSkin.Controls.MaterialRaisedButton btnSettings;
        private System.Windows.Forms.Timer timerUI;
        private MaterialSkin.Controls.MaterialRaisedButton btnManager;
        private System.Windows.Forms.PictureBox btnClock;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinish;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegistrant;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Xenon.ThirteenComboBox cmbChildren;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Xenon.ThirteenComboBox cmbAdults;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblChildren;
        private MaterialSkin.Controls.MaterialLabel lblAdults;
        private MaterialSkin.Controls.MaterialLabel lblPrice;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialListView listCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuTabPage;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuTabControl;
        private System.Windows.Forms.ToolStripMenuItem closeExtraToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnFilter;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFilter;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelFilter;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}

