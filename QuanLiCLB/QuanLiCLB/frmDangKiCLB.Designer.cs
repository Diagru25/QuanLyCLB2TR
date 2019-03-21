namespace QuanLiCLB
{
    partial class frmDangKiCLB
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
            this.listviewDK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveCLB = new System.Windows.Forms.Button();
            this.btnDelCLB = new System.Windows.Forms.Button();
            this.btnEditCLB = new System.Windows.Forms.Button();
            this.btnAddCLB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboHS = new System.Windows.Forms.ComboBox();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.txbHocPhi = new System.Windows.Forms.TextBox();
            this.txbNguoiDK = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewDK
            // 
            this.listviewDK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.listviewDK.FullRowSelect = true;
            this.listviewDK.GridLines = true;
            this.listviewDK.Location = new System.Drawing.Point(17, 17);
            this.listviewDK.Margin = new System.Windows.Forms.Padding(8);
            this.listviewDK.Name = "listviewDK";
            this.listviewDK.Size = new System.Drawing.Size(1152, 1289);
            this.listviewDK.TabIndex = 47;
            this.listviewDK.UseCompatibleStateImageBehavior = false;
            this.listviewDK.View = System.Windows.Forms.View.Details;
            this.listviewDK.SelectedIndexChanged += new System.EventHandler(this.listviewDK_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Lớp";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "Học sinh";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Tag = "";
            this.columnHeader3.Text = "Mức học phí";
            this.columnHeader3.Width = 133;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1185, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(1084, 136);
            this.groupBox1.TabIndex = 48;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSaveCLB);
            this.groupBox2.Controls.Add(this.btnDelCLB);
            this.groupBox2.Controls.Add(this.btnEditCLB);
            this.groupBox2.Controls.Add(this.btnAddCLB);
            this.groupBox2.Location = new System.Drawing.Point(1185, 1175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(1084, 127);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(908, 36);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 54);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(732, 36);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 54);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveCLB
            // 
            this.btnSaveCLB.Location = new System.Drawing.Point(560, 36);
            this.btnSaveCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnSaveCLB.Name = "btnSaveCLB";
            this.btnSaveCLB.Size = new System.Drawing.Size(156, 54);
            this.btnSaveCLB.TabIndex = 9;
            this.btnSaveCLB.Text = "Lưu";
            this.btnSaveCLB.UseVisualStyleBackColor = true;
            this.btnSaveCLB.Click += new System.EventHandler(this.btnSaveCLB_Click);
            // 
            // btnDelCLB
            // 
            this.btnDelCLB.Location = new System.Drawing.Point(384, 36);
            this.btnDelCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelCLB.Name = "btnDelCLB";
            this.btnDelCLB.Size = new System.Drawing.Size(160, 54);
            this.btnDelCLB.TabIndex = 8;
            this.btnDelCLB.Text = "Xóa";
            this.btnDelCLB.UseVisualStyleBackColor = true;
            this.btnDelCLB.Click += new System.EventHandler(this.btnDelCLB_Click);
            // 
            // btnEditCLB
            // 
            this.btnEditCLB.Location = new System.Drawing.Point(212, 36);
            this.btnEditCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnEditCLB.Name = "btnEditCLB";
            this.btnEditCLB.Size = new System.Drawing.Size(156, 54);
            this.btnEditCLB.TabIndex = 7;
            this.btnEditCLB.Text = "Sửa";
            this.btnEditCLB.UseVisualStyleBackColor = true;
            this.btnEditCLB.Click += new System.EventHandler(this.btnEditCLB_Click);
            // 
            // btnAddCLB
            // 
            this.btnAddCLB.Location = new System.Drawing.Point(40, 36);
            this.btnAddCLB.Margin = new System.Windows.Forms.Padding(8);
            this.btnAddCLB.Name = "btnAddCLB";
            this.btnAddCLB.Size = new System.Drawing.Size(156, 54);
            this.btnAddCLB.TabIndex = 6;
            this.btnAddCLB.Text = "Thêm";
            this.btnAddCLB.UseVisualStyleBackColor = true;
            this.btnAddCLB.Click += new System.EventHandler(this.btnAddCLB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboLop);
            this.groupBox3.Controls.Add(this.cboHS);
            this.groupBox3.Controls.Add(this.dtpNgayDK);
            this.groupBox3.Controls.Add(this.txbHocPhi);
            this.groupBox3.Controls.Add(this.txbNguoiDK);
            this.groupBox3.Controls.Add(this.txbID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1185, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 1000);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(384, 438);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(508, 39);
            this.cboLop.TabIndex = 13;
            // 
            // cboHS
            // 
            this.cboHS.FormattingEnabled = true;
            this.cboHS.Location = new System.Drawing.Point(384, 326);
            this.cboHS.Name = "cboHS";
            this.cboHS.Size = new System.Drawing.Size(508, 39);
            this.cboHS.TabIndex = 12;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(384, 696);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(508, 38);
            this.dtpNgayDK.TabIndex = 11;
            // 
            // txbHocPhi
            // 
            this.txbHocPhi.Location = new System.Drawing.Point(384, 558);
            this.txbHocPhi.Name = "txbHocPhi";
            this.txbHocPhi.Size = new System.Drawing.Size(508, 38);
            this.txbHocPhi.TabIndex = 10;
            // 
            // txbNguoiDK
            // 
            this.txbNguoiDK.Location = new System.Drawing.Point(384, 210);
            this.txbNguoiDK.Name = "txbNguoiDK";
            this.txbNguoiDK.Size = new System.Drawing.Size(508, 38);
            this.txbNguoiDK.TabIndex = 7;
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(384, 96);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(508, 38);
            this.txbID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Học phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // frmDangKiCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2284, 1319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listviewDK);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmDangKiCLB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listviewDK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveCLB;
        private System.Windows.Forms.Button btnDelCLB;
        private System.Windows.Forms.Button btnEditCLB;
        private System.Windows.Forms.Button btnAddCLB;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboHS;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.TextBox txbHocPhi;
        private System.Windows.Forms.TextBox txbNguoiDK;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}