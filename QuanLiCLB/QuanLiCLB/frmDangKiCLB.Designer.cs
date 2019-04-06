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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cboLopHC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewDK
            // 
            this.listviewDK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7});
            this.listviewDK.FullRowSelect = true;
            this.listviewDK.GridLines = true;
            this.listviewDK.Location = new System.Drawing.Point(12, 12);
            this.listviewDK.Name = "listviewDK";
            this.listviewDK.Size = new System.Drawing.Size(607, 543);
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "Người đăng ký";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày đăng ký";
            this.columnHeader7.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(623, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 57);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(14, 20);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(230, 20);
            this.txtFind.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSaveCLB);
            this.groupBox2.Controls.Add(this.btnDelCLB);
            this.groupBox2.Controls.Add(this.btnEditCLB);
            this.groupBox2.Controls.Add(this.btnAddCLB);
            this.groupBox2.Location = new System.Drawing.Point(623, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 53);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveCLB
            // 
            this.btnSaveCLB.Location = new System.Drawing.Point(210, 15);
            this.btnSaveCLB.Name = "btnSaveCLB";
            this.btnSaveCLB.Size = new System.Drawing.Size(58, 23);
            this.btnSaveCLB.TabIndex = 9;
            this.btnSaveCLB.Text = "Lưu";
            this.btnSaveCLB.UseVisualStyleBackColor = true;
            this.btnSaveCLB.Click += new System.EventHandler(this.btnSaveCLB_Click);
            // 
            // btnDelCLB
            // 
            this.btnDelCLB.Location = new System.Drawing.Point(144, 15);
            this.btnDelCLB.Name = "btnDelCLB";
            this.btnDelCLB.Size = new System.Drawing.Size(60, 23);
            this.btnDelCLB.TabIndex = 8;
            this.btnDelCLB.Text = "Xóa";
            this.btnDelCLB.UseVisualStyleBackColor = true;
            this.btnDelCLB.Click += new System.EventHandler(this.btnDelCLB_Click);
            // 
            // btnEditCLB
            // 
            this.btnEditCLB.Location = new System.Drawing.Point(80, 15);
            this.btnEditCLB.Name = "btnEditCLB";
            this.btnEditCLB.Size = new System.Drawing.Size(58, 23);
            this.btnEditCLB.TabIndex = 7;
            this.btnEditCLB.Text = "Sửa";
            this.btnEditCLB.UseVisualStyleBackColor = true;
            this.btnEditCLB.Click += new System.EventHandler(this.btnEditCLB_Click);
            // 
            // btnAddCLB
            // 
            this.btnAddCLB.Location = new System.Drawing.Point(15, 15);
            this.btnAddCLB.Name = "btnAddCLB";
            this.btnAddCLB.Size = new System.Drawing.Size(58, 23);
            this.btnAddCLB.TabIndex = 6;
            this.btnAddCLB.Text = "Thêm";
            this.btnAddCLB.UseVisualStyleBackColor = true;
            this.btnAddCLB.Click += new System.EventHandler(this.btnAddCLB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboLopHC);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(623, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(406, 419);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLop);
            this.panel1.Controls.Add(this.cboHS);
            this.panel1.Controls.Add(this.dtpNgayDK);
            this.panel1.Controls.Add(this.txbHocPhi);
            this.panel1.Controls.Add(this.txbNguoiDK);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 338);
            this.panel1.TabIndex = 14;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(162, 180);
            this.cboLop.Margin = new System.Windows.Forms.Padding(1);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(193, 21);
            this.cboLop.TabIndex = 25;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboHS
            // 
            this.cboHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHS.FormattingEnabled = true;
            this.cboHS.Location = new System.Drawing.Point(162, 133);
            this.cboHS.Margin = new System.Windows.Forms.Padding(1);
            this.cboHS.Name = "cboHS";
            this.cboHS.Size = new System.Drawing.Size(193, 21);
            this.cboHS.TabIndex = 24;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(162, 288);
            this.dtpNgayDK.Margin = new System.Windows.Forms.Padding(1);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(193, 20);
            this.dtpNgayDK.TabIndex = 23;
            // 
            // txbHocPhi
            // 
            this.txbHocPhi.Location = new System.Drawing.Point(162, 230);
            this.txbHocPhi.Margin = new System.Windows.Forms.Padding(1);
            this.txbHocPhi.Name = "txbHocPhi";
            this.txbHocPhi.Size = new System.Drawing.Size(193, 20);
            this.txbHocPhi.TabIndex = 22;
            // 
            // txbNguoiDK
            // 
            this.txbNguoiDK.Location = new System.Drawing.Point(162, 84);
            this.txbNguoiDK.Margin = new System.Windows.Forms.Padding(1);
            this.txbNguoiDK.Name = "txbNguoiDK";
            this.txbNguoiDK.Size = new System.Drawing.Size(193, 20);
            this.txbNguoiDK.TabIndex = 21;
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(162, 36);
            this.txbID.Margin = new System.Windows.Forms.Padding(1);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(193, 20);
            this.txbID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Học phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Người đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // cboLopHC
            // 
            this.cboLopHC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHC.FormattingEnabled = true;
            this.cboLopHC.Location = new System.Drawing.Point(166, 30);
            this.cboLopHC.Margin = new System.Windows.Forms.Padding(1);
            this.cboLopHC.Name = "cboLopHC";
            this.cboLopHC.Size = new System.Drawing.Size(193, 21);
            this.cboLopHC.TabIndex = 27;
            this.cboLopHC.SelectedValueChanged += new System.EventHandler(this.cboLopHC_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Lớp hành chính";
            // 
            // frmDangKiCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1039, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listviewDK);
            this.Name = "frmDangKiCLB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cboLopHC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
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
    }
}