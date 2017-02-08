namespace Centipac
{
    partial class clockForm
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
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnIn = new MaterialSkin.Controls.MaterialLabel();
            this.btnOut = new MaterialSkin.Controls.MaterialLabel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.btnLogIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "Username";
            this.txtUser.Location = new System.Drawing.Point(12, 82);
            this.txtUser.MaxLength = 30;
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(228, 23);
            this.txtUser.TabIndex = 0;
            this.txtUser.TabStop = false;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // btnIn
            // 
            this.btnIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnIn.Depth = 0;
            this.btnIn.Font = new System.Drawing.Font("Roboto", 11F);
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIn.Location = new System.Drawing.Point(7, 7);
            this.btnIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(90, 40);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "Clock In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIn.MouseEnter += new System.EventHandler(this.btnIn_MouseEnter);
            this.btnIn.MouseLeave += new System.EventHandler(this.btnIn_MouseLeave);
            // 
            // btnOut
            // 
            this.btnOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOut.Depth = 0;
            this.btnOut.Font = new System.Drawing.Font("Roboto", 11F);
            this.btnOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOut.Location = new System.Drawing.Point(145, 7);
            this.btnOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(90, 40);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Clock Out";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOut.MouseEnter += new System.EventHandler(this.btnOut_MouseEnter);
            this.btnOut.MouseLeave += new System.EventHandler(this.btnOut_MouseLeave);
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.White;
            this.pnlTime.Controls.Add(this.btnLogIn);
            this.pnlTime.Controls.Add(this.btnOut);
            this.pnlTime.Controls.Add(this.btnIn);
            this.pnlTime.Location = new System.Drawing.Point(5, 119);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(246, 58);
            this.pnlTime.TabIndex = 4;
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogIn.Depth = 0;
            this.btnLogIn.Icon = null;
            this.btnLogIn.Location = new System.Drawing.Point(58, 13);
            this.btnLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Primary = true;
            this.btnLogIn.Size = new System.Drawing.Size(123, 30);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // clockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 175);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.txtUser);
            this.MaximizeBox = false;
            this.Name = "clockForm";
            this.Text = "Time Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.clockForm_FormClosing);
            this.Load += new System.EventHandler(this.clockForm_Load);
            this.pnlTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialLabel btnIn;
        private MaterialSkin.Controls.MaterialLabel btnOut;
        private System.Windows.Forms.Panel pnlTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogIn;
    }
}