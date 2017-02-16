namespace ViewCustomerTabControls
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRegistrantEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listEditors = new MaterialSkin.Controls.MaterialListView();
            this.cEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nmAdults = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.nmChildren = new System.Windows.Forms.NumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmailEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPhoneEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegistrantEdit
            // 
            this.txtRegistrantEdit.Depth = 0;
            this.txtRegistrantEdit.Hint = "";
            this.txtRegistrantEdit.Location = new System.Drawing.Point(32, 36);
            this.txtRegistrantEdit.MaxLength = 32767;
            this.txtRegistrantEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegistrantEdit.Name = "txtRegistrantEdit";
            this.txtRegistrantEdit.PasswordChar = '\0';
            this.txtRegistrantEdit.SelectedText = "";
            this.txtRegistrantEdit.SelectionLength = 0;
            this.txtRegistrantEdit.SelectionStart = 0;
            this.txtRegistrantEdit.Size = new System.Drawing.Size(216, 23);
            this.txtRegistrantEdit.TabIndex = 0;
            this.txtRegistrantEdit.TabStop = false;
            this.txtRegistrantEdit.UseSystemPasswordChar = false;
            // 
            // listEditors
            // 
            this.listEditors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEditors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cEmployee,
            this.cDateTime});
            this.listEditors.Depth = 0;
            this.listEditors.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listEditors.FullRowSelect = true;
            this.listEditors.Location = new System.Drawing.Point(297, 11);
            this.listEditors.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEditors.MouseState = MaterialSkin.MouseState.OUT;
            this.listEditors.Name = "listEditors";
            this.listEditors.OwnerDraw = true;
            this.listEditors.Size = new System.Drawing.Size(268, 275);
            this.listEditors.TabIndex = 1;
            this.listEditors.UseCompatibleStateImageBehavior = false;
            this.listEditors.View = System.Windows.Forms.View.Details;
            // 
            // cEmployee
            // 
            this.cEmployee.Text = "Employee";
            this.cEmployee.Width = 154;
            // 
            // cDateTime
            // 
            this.cDateTime.Text = "Date";
            this.cDateTime.Width = 113;
            // 
            // nmAdults
            // 
            this.nmAdults.Location = new System.Drawing.Point(161, 77);
            this.nmAdults.Name = "nmAdults";
            this.nmAdults.Size = new System.Drawing.Size(87, 20);
            this.nmAdults.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Adults:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Children:";
            // 
            // nmChildren
            // 
            this.nmChildren.Location = new System.Drawing.Point(161, 110);
            this.nmChildren.Name = "nmChildren";
            this.nmChildren.Size = new System.Drawing.Size(87, 20);
            this.nmChildren.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 11);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Registrant:";
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Depth = 0;
            this.txtEmailEdit.Hint = "Email (Optional)";
            this.txtEmailEdit.Location = new System.Drawing.Point(32, 149);
            this.txtEmailEdit.MaxLength = 32767;
            this.txtEmailEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.PasswordChar = '\0';
            this.txtEmailEdit.SelectedText = "";
            this.txtEmailEdit.SelectionLength = 0;
            this.txtEmailEdit.SelectionStart = 0;
            this.txtEmailEdit.Size = new System.Drawing.Size(216, 23);
            this.txtEmailEdit.TabIndex = 7;
            this.txtEmailEdit.TabStop = false;
            this.txtEmailEdit.UseSystemPasswordChar = false;
            // 
            // txtPhoneEdit
            // 
            this.txtPhoneEdit.Depth = 0;
            this.txtPhoneEdit.Hint = "Phone (Optional)";
            this.txtPhoneEdit.Location = new System.Drawing.Point(32, 178);
            this.txtPhoneEdit.MaxLength = 32767;
            this.txtPhoneEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneEdit.Name = "txtPhoneEdit";
            this.txtPhoneEdit.PasswordChar = '\0';
            this.txtPhoneEdit.SelectedText = "";
            this.txtPhoneEdit.SelectionLength = 0;
            this.txtPhoneEdit.SelectionStart = 0;
            this.txtPhoneEdit.Size = new System.Drawing.Size(216, 23);
            this.txtPhoneEdit.TabIndex = 8;
            this.txtPhoneEdit.TabStop = false;
            this.txtPhoneEdit.UseSystemPasswordChar = false;
            // 
            // lblDate
            // 
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(28, 230);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 23);
            this.lblDate.TabIndex = 9;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(28, 253);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 23);
            this.lblTime.TabIndex = 10;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(158, 215);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 71);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(166, 248);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(91, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(166, 218);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(91, 21);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtPhoneEdit);
            this.Controls.Add(this.txtEmailEdit);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.nmChildren);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nmAdults);
            this.Controls.Add(this.listEditors);
            this.Controls.Add(this.txtRegistrantEdit);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(578, 300);
            ((System.ComponentModel.ISupportInitialize)(this.nmAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegistrantEdit;
        private MaterialSkin.Controls.MaterialListView listEditors;
        private System.Windows.Forms.ColumnHeader cEmployee;
        private System.Windows.Forms.ColumnHeader cDateTime;
        private System.Windows.Forms.NumericUpDown nmAdults;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.NumericUpDown nmChildren;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneEdit;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
    }
}
