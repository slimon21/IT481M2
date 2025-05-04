namespace NorthwindCustomerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox listBoxLastNames;

        private void InitializeComponent()
        {
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.listBoxLastNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.btnLoadData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(150, 30);
            this.btnLoadData.Text = "Load Customer Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 50);
            this.lblCount.Size = new System.Drawing.Size(100, 20);

            this.listBoxLastNames.FormattingEnabled = true;
            this.listBoxLastNames.Location = new System.Drawing.Point(12, 80);
            this.listBoxLastNames.Size = new System.Drawing.Size(260, 150);

            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.listBoxLastNames);
            this.Name = "MainForm";
            this.Text = "Northwind Customer Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
