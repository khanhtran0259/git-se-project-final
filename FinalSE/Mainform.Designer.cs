namespace FinalSE
{
    partial class Mainform
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
            this.btnFormImort = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormImort
            // 
            this.btnFormImort.Location = new System.Drawing.Point(31, 55);
            this.btnFormImort.Name = "btnFormImort";
            this.btnFormImort.Size = new System.Drawing.Size(75, 23);
            this.btnFormImort.TabIndex = 0;
            this.btnFormImort.Text = "Nhập hàng";
            this.btnFormImort.UseVisualStyleBackColor = true;
            this.btnFormImort.Click += new System.EventHandler(this.btnFormImort_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(163, 55);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất hàng";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(296, 55);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Thống kê";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 175);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFormImort);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormImort;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReport;
    }
}