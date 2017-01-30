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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupUserOptions = new MaterialSkin.Controls.MaterialGroupBox();
            this.btnManager = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLogOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.btnClock = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(300, 35);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 104);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(276, 152);
            this.materialTabControl1.TabIndex = 3;
            this.materialTabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialTabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color Scheme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theme";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btnClock.Location = new System.Drawing.Point(143, 33);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(24, 26);
            this.btnClock.TabIndex = 6;
            this.btnClock.TabStop = false;
            this.btnClock.MouseEnter += new System.EventHandler(this.btnClock_MouseEnter);
            this.btnClock.MouseLeave += new System.EventHandler(this.btnClock_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.groupUserOptions);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centipac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupUserOptions.ResumeLayout(false);
            this.groupUserOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialGroupBox groupUserOptions;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogOut;
        private MaterialSkin.Controls.MaterialRaisedButton btnSettings;
        private System.Windows.Forms.Timer timerUI;
        private MaterialSkin.Controls.MaterialRaisedButton btnManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnClock;
    }
}

