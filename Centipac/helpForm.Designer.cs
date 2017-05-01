namespace Centipac
{
    partial class helpForm
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRegistrant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(239, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "To view help, navigate to this link: ";
            // 
            // txtRegistrant
            // 
            this.txtRegistrant.Depth = 0;
            this.txtRegistrant.Hint = "";
            this.txtRegistrant.Location = new System.Drawing.Point(12, 105);
            this.txtRegistrant.MaxLength = 32767;
            this.txtRegistrant.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegistrant.Name = "txtRegistrant";
            this.txtRegistrant.PasswordChar = '\0';
            this.txtRegistrant.SelectedText = "";
            this.txtRegistrant.SelectionLength = 0;
            this.txtRegistrant.SelectionStart = 0;
            this.txtRegistrant.Size = new System.Drawing.Size(238, 23);
            this.txtRegistrant.TabIndex = 8;
            this.txtRegistrant.TabStop = false;
            this.txtRegistrant.Text = "https://github.com/Zeffe/centipac/wiki";
            this.txtRegistrant.UseSystemPasswordChar = false;
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 151);
            this.Controls.Add(this.txtRegistrant);
            this.Controls.Add(this.materialLabel3);
            this.MaximizeBox = false;
            this.Name = "helpForm";
            this.Sizable = false;
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.helpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegistrant;
    }
}