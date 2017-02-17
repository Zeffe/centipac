namespace Centipac
{
    partial class addForm
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
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassConfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboRank = new Xenon.ThirteenComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(33, 225);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(154, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Employee";
            this.btnAdd.useBackColor = false;
            this.btnAdd.useForeColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "Username";
            this.txtUser.Location = new System.Drawing.Point(12, 88);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(207, 23);
            this.txtUser.TabIndex = 1;
            this.txtUser.TabStop = false;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "Full Name";
            this.txtName.Location = new System.Drawing.Point(12, 117);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "Password";
            this.txtPass.Location = new System.Drawing.Point(12, 158);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(207, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.TabStop = false;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Depth = 0;
            this.txtPassConfirm.Hint = "Password (Confirm)";
            this.txtPassConfirm.Location = new System.Drawing.Point(12, 188);
            this.txtPassConfirm.MaxLength = 32767;
            this.txtPassConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.SelectedText = "";
            this.txtPassConfirm.SelectionLength = 0;
            this.txtPassConfirm.SelectionStart = 0;
            this.txtPassConfirm.Size = new System.Drawing.Size(207, 23);
            this.txtPassConfirm.TabIndex = 4;
            this.txtPassConfirm.TabStop = false;
            this.txtPassConfirm.UseSystemPasswordChar = false;
            // 
            // comboRank
            // 
            this.comboRank.AccentColor = System.Drawing.Color.DodgerBlue;
            this.comboRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboRank.ColorScheme = Xenon.ThirteenComboBox.ColorSchemes.Light;
            this.comboRank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRank.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.comboRank.ForeColor = System.Drawing.Color.White;
            this.comboRank.FormattingEnabled = true;
            this.comboRank.Location = new System.Drawing.Point(225, 88);
            this.comboRank.Name = "comboRank";
            this.comboRank.Size = new System.Drawing.Size(121, 26);
            this.comboRank.TabIndex = 6;
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 276);
            this.Controls.Add(this.comboRank);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnAdd);
            this.Name = "addForm";
            this.Text = "Add Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addForm_FormClosing);
            this.Load += new System.EventHandler(this.addForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassConfirm;
        private Xenon.ThirteenComboBox comboRank;
    }
}