namespace Centipac
{
    partial class reportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Centipac.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(871, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(102, 74);
            this.dtStart.MaxDate = new System.DateTime(2050, 2, 20, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(204, 20);
            this.dtStart.TabIndex = 39;
            this.dtStart.Value = new System.DateTime(2017, 2, 20, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Start Date: ";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(462, 74);
            this.dtEnd.MaxDate = new System.DateTime(2050, 2, 20, 0, 0, 0, 0);
            this.dtEnd.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(204, 20);
            this.dtEnd.TabIndex = 41;
            this.dtEnd.Value = new System.DateTime(2017, 2, 20, 0, 0, 0, 0);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(364, 74);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 40;
            this.materialLabel3.Text = "End Date: ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Depth = 0;
            this.btnGenerate.Icon = null;
            this.btnGenerate.Location = new System.Drawing.Point(709, 75);
            this.btnGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Primary = true;
            this.btnGenerate.Size = new System.Drawing.Size(119, 18);
            this.btnGenerate.TabIndex = 42;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(Centipac.Customer);
            // 
            // reportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 624);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportForm";
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reportForm_FormClosing);
            this.Load += new System.EventHandler(this.reportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerate;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
    }
}