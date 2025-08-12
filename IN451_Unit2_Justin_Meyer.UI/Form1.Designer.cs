namespace IN451_Unit2_Justin_Meyer.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadNames;
        private System.Windows.Forms.Button btnLoadLastNames;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadNames = new System.Windows.Forms.Button();
            this.btnLoadLastNames = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadNames
            // 
            this.btnLoadNames.Location = new System.Drawing.Point(12, 12);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(120, 30);
            this.btnLoadNames.TabIndex = 0;
            this.btnLoadNames.Text = "Load Names";
            this.btnLoadNames.UseVisualStyleBackColor = true;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // btnLoadLastNames
            // 
            this.btnLoadLastNames.Location = new System.Drawing.Point(138, 12);
            this.btnLoadLastNames.Name = "btnLoadLastNames";
            this.btnLoadLastNames.Size = new System.Drawing.Size(140, 30);
            this.btnLoadLastNames.TabIndex = 1;
            this.btnLoadLastNames.Text = "Load Last Names";
            this.btnLoadLastNames.UseVisualStyleBackColor = true;
            this.btnLoadLastNames.Click += new System.EventHandler(this.btnLoadLastNames_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.IntegralHeight = false;
            this.lstCustomers.Location = new System.Drawing.Point(12, 48);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(410, 270);
            this.lstCustomers.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 325);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Customers: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnLoadLastNames);
            this.Controls.Add(this.btnLoadNames);
            this.MinimumSize = new System.Drawing.Size(450, 390);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN451_Unit2_Justin_Meyer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
