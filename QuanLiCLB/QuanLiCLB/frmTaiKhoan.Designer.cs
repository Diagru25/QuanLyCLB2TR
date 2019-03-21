namespace QuanLiCLB
{
    partial class frmTaiKhoan
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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddCLB = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveCLB = new System.Windows.Forms.Button();
            this.btnDelCLB = new System.Windows.Forms.Button();
            this.btnEditCLB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên đăng nhập";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // txbUserName
            // 
            this.txbUserName.Enabled = false;
            this.txbUserName.Location = new System.Drawing.Point(306, 241);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(571, 38);
            this.txbUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboQuyen);
            this.groupBox3.Controls.Add(this.txbUserName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1187, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 799);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(14, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1162, 1075);
            this.listView1.TabIndex = 57;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1187, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(1084, 136);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSaveCLB);
            this.groupBox2.Controls.Add(this.btnDelCLB);
            this.groupBox2.Controls.Add(this.btnEditCLB);
            this.groupBox2.Controls.Add(this.btnAddCLB);
            this.groupBox2.Location = new System.Drawing.Point(1187, 960);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(1084, 127);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cboQuyen.Location = new System.Drawing.Point(306, 390);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(571, 39);
            this.cboQuyen.TabIndex = 3;
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(306, 94);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(571, 38);
            this.txbID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quyền";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2284, 1099);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddCLB;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveCLB;
        private System.Windows.Forms.Button btnDelCLB;
        private System.Windows.Forms.Button btnEditCLB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}