namespace QuanLiCLB
{
    partial class frmCLB
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveCLB = new System.Windows.Forms.Button();
            this.btnDelCLB = new System.Windows.Forms.Button();
            this.btnEditCLB = new System.Windows.Forms.Button();
            this.btnAddCLB = new System.Windows.Forms.Button();
            this.groupedit_Patient = new System.Windows.Forms.GroupBox();
            this.txtHocPhiCLB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameCLB = new System.Windows.Forms.TextBox();
            this.txtIDCLB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Patient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupedit_Patient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSaveCLB);
            this.groupBox2.Controls.Add(this.btnDelCLB);
            this.groupBox2.Controls.Add(this.btnEditCLB);
            this.groupBox2.Controls.Add(this.btnAddCLB);
            this.groupBox2.Location = new System.Drawing.Point(1204, 1043);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(1084, 134);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(904, 45);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(728, 45);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 54);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveCLB
            // 
            this.btnSaveCLB.Location = new System.Drawing.Point(556, 45);
            this.btnSaveCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnSaveCLB.Name = "btnSaveCLB";
            this.btnSaveCLB.Size = new System.Drawing.Size(156, 54);
            this.btnSaveCLB.TabIndex = 3;
            this.btnSaveCLB.Text = "Lưu";
            this.btnSaveCLB.UseVisualStyleBackColor = true;
            this.btnSaveCLB.Click += new System.EventHandler(this.btnSavePatient_Click);
            // 
            // btnDelCLB
            // 
            this.btnDelCLB.Location = new System.Drawing.Point(380, 45);
            this.btnDelCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelCLB.Name = "btnDelCLB";
            this.btnDelCLB.Size = new System.Drawing.Size(160, 54);
            this.btnDelCLB.TabIndex = 2;
            this.btnDelCLB.Text = "Xóa";
            this.btnDelCLB.UseVisualStyleBackColor = true;
            this.btnDelCLB.Click += new System.EventHandler(this.btnDelPatient_Click);
            // 
            // btnEditCLB
            // 
            this.btnEditCLB.Location = new System.Drawing.Point(208, 45);
            this.btnEditCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnEditCLB.Name = "btnEditCLB";
            this.btnEditCLB.Size = new System.Drawing.Size(156, 54);
            this.btnEditCLB.TabIndex = 1;
            this.btnEditCLB.Text = "Sửa";
            this.btnEditCLB.UseVisualStyleBackColor = true;
            this.btnEditCLB.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnAddCLB
            // 
            this.btnAddCLB.Location = new System.Drawing.Point(36, 45);
            this.btnAddCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnAddCLB.Name = "btnAddCLB";
            this.btnAddCLB.Size = new System.Drawing.Size(156, 54);
            this.btnAddCLB.TabIndex = 0;
            this.btnAddCLB.Text = "Thêm";
            this.btnAddCLB.UseVisualStyleBackColor = true;
            this.btnAddCLB.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // groupedit_Patient
            // 
            this.groupedit_Patient.Controls.Add(this.txtHocPhiCLB);
            this.groupedit_Patient.Controls.Add(this.label6);
            this.groupedit_Patient.Controls.Add(this.txtNameCLB);
            this.groupedit_Patient.Controls.Add(this.txtIDCLB);
            this.groupedit_Patient.Controls.Add(this.label2);
            this.groupedit_Patient.Controls.Add(this.label1);
            this.groupedit_Patient.Location = new System.Drawing.Point(1204, 162);
            this.groupedit_Patient.Margin = new System.Windows.Forms.Padding(8);
            this.groupedit_Patient.Name = "groupedit_Patient";
            this.groupedit_Patient.Padding = new System.Windows.Forms.Padding(8);
            this.groupedit_Patient.Size = new System.Drawing.Size(1084, 865);
            this.groupedit_Patient.TabIndex = 7;
            this.groupedit_Patient.TabStop = false;
            // 
            // txtHocPhiCLB
            // 
            this.txtHocPhiCLB.Location = new System.Drawing.Point(276, 426);
            this.txtHocPhiCLB.Margin = new System.Windows.Forms.Padding(8);
            this.txtHocPhiCLB.Name = "txtHocPhiCLB";
            this.txtHocPhiCLB.Size = new System.Drawing.Size(456, 38);
            this.txtHocPhiCLB.TabIndex = 26;
            this.txtHocPhiCLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHocPhiCLB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 434);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mức học phí";
            // 
            // txtNameCLB
            // 
            this.txtNameCLB.Location = new System.Drawing.Point(276, 302);
            this.txtNameCLB.Margin = new System.Windows.Forms.Padding(8);
            this.txtNameCLB.Name = "txtNameCLB";
            this.txtNameCLB.Size = new System.Drawing.Size(456, 38);
            this.txtNameCLB.TabIndex = 13;
            // 
            // txtIDCLB
            // 
            this.txtIDCLB.Enabled = false;
            this.txtIDCLB.Location = new System.Drawing.Point(276, 177);
            this.txtIDCLB.Margin = new System.Windows.Forms.Padding(8);
            this.txtIDCLB.Name = "txtIDCLB";
            this.txtIDCLB.Size = new System.Drawing.Size(260, 38);
            this.txtIDCLB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên câu lạc bộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // listView_Patient
            // 
            this.listView_Patient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Patient.FullRowSelect = true;
            this.listView_Patient.GridLines = true;
            this.listView_Patient.Location = new System.Drawing.Point(28, 10);
            this.listView_Patient.Margin = new System.Windows.Forms.Padding(8);
            this.listView_Patient.Name = "listView_Patient";
            this.listView_Patient.Size = new System.Drawing.Size(1152, 1167);
            this.listView_Patient.TabIndex = 6;
            this.listView_Patient.UseCompatibleStateImageBehavior = false;
            this.listView_Patient.View = System.Windows.Forms.View.Details;
            this.listView_Patient.SelectedIndexChanged += new System.EventHandler(this.ListView_Patient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Tên câu lạc bộ";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "";
            this.columnHeader3.Text = "Mức học phí";
            this.columnHeader3.Width = 133;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1204, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(1084, 136);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo tên";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(36, 48);
            this.txtFind.Margin = new System.Windows.Forms.Padding(8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(608, 38);
            this.txtFind.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2312, 1203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupedit_Patient);
            this.Controls.Add(this.listView_Patient);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmCLB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí Câu lạc bộ";
            this.groupBox2.ResumeLayout(false);
            this.groupedit_Patient.ResumeLayout(false);
            this.groupedit_Patient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveCLB;
        private System.Windows.Forms.Button btnDelCLB;
        private System.Windows.Forms.Button btnEditCLB;
        private System.Windows.Forms.Button btnAddCLB;
        private System.Windows.Forms.TextBox txtHocPhiCLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameCLB;
        private System.Windows.Forms.TextBox txtIDCLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Patient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupedit_Patient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
    }
}