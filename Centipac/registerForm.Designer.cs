namespace Centipac
{
    partial class registerForm
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
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblInfo = new MaterialSkin.Controls.MaterialLabel();
            this.txtPass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.Hint = " New Password";
            this.txtPass.Location = new System.Drawing.Point(64, 199);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(168, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = " New Username";
            this.txtUser.Location = new System.Drawing.Point(64, 161);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(168, 23);
            this.txtUser.TabIndex = 2;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Depth = 0;
            this.lblInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(17, 73);
            this.lblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(90, 19);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "placeHolder";
            // 
            // txtPass2
            // 
            this.txtPass2.Depth = 0;
            this.txtPass2.Hint = " Confirm Password";
            this.txtPass2.Location = new System.Drawing.Point(64, 228);
            this.txtPass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.SelectedText = "";
            this.txtPass2.SelectionLength = 0;
            this.txtPass2.SelectionStart = 0;
            this.txtPass2.Size = new System.Drawing.Size(168, 23);
            this.txtPass2.TabIndex = 5;
            this.txtPass2.UseSystemPasswordChar = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(183, 265);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(105, 26);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 303);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.MaximizeBox = false;
            this.Name = "registerForm";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registerForm_FormClosed);
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialLabel lblInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass2;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
    }
}