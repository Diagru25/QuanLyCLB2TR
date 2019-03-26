namespace QuanLiCLB
{
    partial class frmThongke_CLB
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
            this.listView_Patient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Patient
            // 
            this.listView_Patient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Patient.FullRowSelect = true;
            this.listView_Patient.GridLines = true;
            this.listView_Patient.Location = new System.Drawing.Point(12, 12);
            this.listView_Patient.Name = "listView_Patient";
            this.listView_Patient.Size = new System.Drawing.Size(350, 298);
            this.listView_Patient.TabIndex = 9;
            this.listView_Patient.UseCompatibleStateImageBehavior = false;
            this.listView_Patient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên lớp";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số học sinh";
            // 
            // frmThongke_CLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 359);
            this.Controls.Add(this.listView_Patient);
            this.Name = "frmThongke_CLB";
            this.Text = "frmThongke_CLB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Patient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}