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
            this.SuspendLayout();
            // 
            // txtRegistrantEdit
            // 
            this.txtRegistrantEdit.Depth = 0;
            this.txtRegistrantEdit.Hint = "Registrant";
            this.txtRegistrantEdit.Location = new System.Drawing.Point(32, 26);
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
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listEditors);
            this.Controls.Add(this.txtRegistrantEdit);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(578, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegistrantEdit;
        private MaterialSkin.Controls.MaterialListView listEditors;
        private System.Windows.Forms.ColumnHeader cEmployee;
        private System.Windows.Forms.ColumnHeader cDateTime;
    }
}
