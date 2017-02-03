namespace Centipac
{
    partial class msgbox
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
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnNo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnYes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(10, 74);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(87, 19);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "placeholder";
            // 
            // btnNo
            // 
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Icon = null;
            this.btnNo.Location = new System.Drawing.Point(42, 74);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Primary = true;
            this.btnNo.Size = new System.Drawing.Size(51, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYes.Depth = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Icon = null;
            this.btnYes.Location = new System.Drawing.Point(12, 73);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(51, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Depth = 0;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(69, 73);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Primary = true;
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtInput
            // 
            this.txtInput.Depth = 0;
            this.txtInput.Hint = "";
            this.txtInput.Location = new System.Drawing.Point(14, 73);
            this.txtInput.MaxLength = 32767;
            this.txtInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.Size = new System.Drawing.Size(75, 23);
            this.txtInput.TabIndex = 4;
            this.txtInput.TabStop = false;
            this.txtInput.UseSystemPasswordChar = false;
            this.txtInput.Visible = false;
            // 
            // msgbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(102, 108);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNo);
            this.MaximizeBox = false;
            this.Name = "msgbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnNo;
        private MaterialSkin.Controls.MaterialRaisedButton btnYes;
        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtInput;
    }
}