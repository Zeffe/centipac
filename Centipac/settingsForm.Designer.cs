namespace Centipac
{
    partial class settingsForm
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
            this.comboColorScheme = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboTheme = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboColorScheme
            // 
            this.comboColorScheme.FormattingEnabled = true;
            this.comboColorScheme.Location = new System.Drawing.Point(16, 96);
            this.comboColorScheme.Name = "comboColorScheme";
            this.comboColorScheme.Size = new System.Drawing.Size(158, 21);
            this.comboColorScheme.TabIndex = 0;
            this.comboColorScheme.SelectedIndexChanged += new System.EventHandler(this.comboColorScheme_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Change Color Scheme:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Change Background:";
            // 
            // comboTheme
            // 
            this.comboTheme.FormattingEnabled = true;
            this.comboTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.comboTheme.Location = new System.Drawing.Point(16, 150);
            this.comboTheme.Name = "comboTheme";
            this.comboTheme.Size = new System.Drawing.Size(158, 21);
            this.comboTheme.TabIndex = 3;
            this.comboTheme.SelectedIndexChanged += new System.EventHandler(this.comboTheme_SelectedIndexChanged);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 300);
            this.Controls.Add(this.comboTheme);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboColorScheme);
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboColorScheme;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboTheme;
    }
}