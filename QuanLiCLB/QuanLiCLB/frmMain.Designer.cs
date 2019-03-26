namespace QuanLiCLB
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLiHêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiDanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMucHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMucLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMucCLB = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHànhChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDanhMucDangKi = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiemDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiemSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiemSachDaChoMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKetsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTK = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupedit_NV = new System.Windows.Forms.GroupBox();
            this.txtPasswordDoctor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsernameDoctor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSuaThongTinTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupedit_NV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiHêThôngToolStripMenuItem,
            this.quanLiDanhMucToolStripMenuItem,
            this.timKiêmToolStripMenuItem,
            this.ThongKetsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLiHêThôngToolStripMenuItem
            // 
            this.quanLiHêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTaiKhoan,
            this.tsmiDangXuat,
            this.toolStripSeparator1,
            this.tsmiThoat});
            this.quanLiHêThôngToolStripMenuItem.Name = "quanLiHêThôngToolStripMenuItem";
            this.quanLiHêThôngToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.quanLiHêThôngToolStripMenuItem.Text = "Quản lí hệ thống";
            // 
            // tsmiTaiKhoan
            // 
            this.tsmiTaiKhoan.Enabled = false;
            this.tsmiTaiKhoan.Name = "tsmiTaiKhoan";
            this.tsmiTaiKhoan.Size = new System.Drawing.Size(177, 22);
            this.tsmiTaiKhoan.Text = "Quản lí tài khoản";
            this.tsmiTaiKhoan.Click += new System.EventHandler(this.tsmiTaiKhoan_Click);
            // 
            // tsmiDangXuat
            // 
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(177, 22);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(177, 22);
            this.tsmiThoat.Text = "Thoát chương trình";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // quanLiDanhMucToolStripMenuItem
            // 
            this.quanLiDanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanhMucHocSinh,
            this.tsmiDanhMucLopHoc,
            this.tsmiDanhMucCLB,
            this.lớpHànhChínhToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmiDanhMucDangKi});
            this.quanLiDanhMucToolStripMenuItem.Name = "quanLiDanhMucToolStripMenuItem";
            this.quanLiDanhMucToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quanLiDanhMucToolStripMenuItem.Text = "Quản lí danh mục";
            // 
            // tsmiDanhMucHocSinh
            // 
            this.tsmiDanhMucHocSinh.Name = "tsmiDanhMucHocSinh";
            this.tsmiDanhMucHocSinh.Size = new System.Drawing.Size(157, 22);
            this.tsmiDanhMucHocSinh.Text = "Học sinh";
            this.tsmiDanhMucHocSinh.Click += new System.EventHandler(this.tsmiDanhMucHocSinh_Click);
            // 
            // tsmiDanhMucLopHoc
            // 
            this.tsmiDanhMucLopHoc.Name = "tsmiDanhMucLopHoc";
            this.tsmiDanhMucLopHoc.Size = new System.Drawing.Size(157, 22);
            this.tsmiDanhMucLopHoc.Text = "Lớp học";
            this.tsmiDanhMucLopHoc.Click += new System.EventHandler(this.tsmiDanhMucLopHoc_Click);
            // 
            // tsmiDanhMucCLB
            // 
            this.tsmiDanhMucCLB.Name = "tsmiDanhMucCLB";
            this.tsmiDanhMucCLB.Size = new System.Drawing.Size(157, 22);
            this.tsmiDanhMucCLB.Text = "Câu lạc bộ";
            this.tsmiDanhMucCLB.Click += new System.EventHandler(this.tsmiDanhMucCLB_Click);
            // 
            // lớpHànhChínhToolStripMenuItem
            // 
            this.lớpHànhChínhToolStripMenuItem.Name = "lớpHànhChínhToolStripMenuItem";
            this.lớpHànhChínhToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lớpHànhChínhToolStripMenuItem.Text = "Lớp hành chính";
            this.lớpHànhChínhToolStripMenuItem.Click += new System.EventHandler(this.lớpHànhChínhToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // tsmiDanhMucDangKi
            // 
            this.tsmiDanhMucDangKi.Name = "tsmiDanhMucDangKi";
            this.tsmiDanhMucDangKi.Size = new System.Drawing.Size(157, 22);
            this.tsmiDanhMucDangKi.Text = "Đăng kí CLB";
            this.tsmiDanhMucDangKi.Click += new System.EventHandler(this.tsmiDanhMucDangKiCLB_Click);
            // 
            // timKiêmToolStripMenuItem
            // 
            this.timKiêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTimKiemDocGia,
            this.tsmiTimKiemSach,
            this.tsmiTimKiemSachDaChoMuon});
            this.timKiêmToolStripMenuItem.Enabled = false;
            this.timKiêmToolStripMenuItem.Name = "timKiêmToolStripMenuItem";
            this.timKiêmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.timKiêmToolStripMenuItem.Text = "Tìm kiếm";
            this.timKiêmToolStripMenuItem.Visible = false;
            // 
            // tsmiTimKiemDocGia
            // 
            this.tsmiTimKiemDocGia.Name = "tsmiTimKiemDocGia";
            this.tsmiTimKiemDocGia.Size = new System.Drawing.Size(154, 22);
            this.tsmiTimKiemDocGia.Text = "Tìm Học sinh";
            this.tsmiTimKiemDocGia.Click += new System.EventHandler(this.tsmiTimKiemDocGia_Click);
            // 
            // tsmiTimKiemSach
            // 
            this.tsmiTimKiemSach.Name = "tsmiTimKiemSach";
            this.tsmiTimKiemSach.Size = new System.Drawing.Size(154, 22);
            this.tsmiTimKiemSach.Text = "Tìm Lớp";
            this.tsmiTimKiemSach.Click += new System.EventHandler(this.tsmiTimKiemSach_Click);
            // 
            // tsmiTimKiemSachDaChoMuon
            // 
            this.tsmiTimKiemSachDaChoMuon.Name = "tsmiTimKiemSachDaChoMuon";
            this.tsmiTimKiemSachDaChoMuon.Size = new System.Drawing.Size(154, 22);
            this.tsmiTimKiemSachDaChoMuon.Text = "Tìm Câu lạc bộ";
            this.tsmiTimKiemSachDaChoMuon.Click += new System.EventHandler(this.tsmiTimKiemSachDaChoMuon_Click);
            // 
            // ThongKetsmi
            // 
            this.ThongKetsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTK,
            this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem});
            this.ThongKetsmi.Name = "ThongKetsmi";
            this.ThongKetsmi.Size = new System.Drawing.Size(69, 20);
            this.ThongKetsmi.Text = "Thống kê";
            this.ThongKetsmi.Visible = false;
            // 
            // tsmiTK
            // 
            this.tsmiTK.Name = "tsmiTK";
            this.tsmiTK.Size = new System.Drawing.Size(152, 22);
            this.tsmiTK.Text = "Thống kê";
            this.tsmiTK.Click += new System.EventHandler(this.tsmiTKThuNhap_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupedit_NV
            // 
            this.groupedit_NV.Controls.Add(this.txtPasswordDoctor);
            this.groupedit_NV.Controls.Add(this.label11);
            this.groupedit_NV.Controls.Add(this.txtUsernameDoctor);
            this.groupedit_NV.Controls.Add(this.label10);
            this.groupedit_NV.Controls.Add(this.btnBoQua);
            this.groupedit_NV.Controls.Add(this.btnLuu);
            this.groupedit_NV.Enabled = false;
            this.groupedit_NV.Location = new System.Drawing.Point(12, 36);
            this.groupedit_NV.Name = "groupedit_NV";
            this.groupedit_NV.Size = new System.Drawing.Size(519, 260);
            this.groupedit_NV.TabIndex = 8;
            this.groupedit_NV.TabStop = false;
            // 
            // txtPasswordDoctor
            // 
            this.txtPasswordDoctor.Location = new System.Drawing.Point(139, 104);
            this.txtPasswordDoctor.Name = "txtPasswordDoctor";
            this.txtPasswordDoctor.Size = new System.Drawing.Size(195, 20);
            this.txtPasswordDoctor.TabIndex = 66;
            this.txtPasswordDoctor.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Mật khẩu";
            // 
            // txtUsernameDoctor
            // 
            this.txtUsernameDoctor.Location = new System.Drawing.Point(139, 47);
            this.txtUsernameDoctor.Name = "txtUsernameDoctor";
            this.txtUsernameDoctor.ReadOnly = true;
            this.txtUsernameDoctor.Size = new System.Drawing.Size(195, 20);
            this.txtUsernameDoctor.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tên đăng nhập";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(415, 205);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 31;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(307, 205);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSuaThongTinTK
            // 
            this.btnSuaThongTinTK.Location = new System.Drawing.Point(254, 302);
            this.btnSuaThongTinTK.Name = "btnSuaThongTinTK";
            this.btnSuaThongTinTK.Size = new System.Drawing.Size(140, 23);
            this.btnSuaThongTinTK.TabIndex = 29;
            this.btnSuaThongTinTK.Text = "Sửa thông tin tài khoản";
            this.btnSuaThongTinTK.UseVisualStyleBackColor = true;
            this.btnSuaThongTinTK.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(427, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // thốngKêTheoTừngCâuLạcBộToolStripMenuItem
            // 
            this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem.Name = "thốngKêTheoTừngCâuLạcBộToolStripMenuItem";
            this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem.Text = "Thống kê theo từng câu lạc bộ";
            this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTheoTừngCâuLạcBộToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 337);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaThongTinTK);
            this.Controls.Add(this.groupedit_NV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí Câu lạc bộ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupedit_NV.ResumeLayout(false);
            this.groupedit_NV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLiHêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem quanLiDanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucHocSinh;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucLopHoc;
        private System.Windows.Forms.ToolStripMenuItem timKiêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiemDocGia;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiemSach;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiemSachDaChoMuon;
        private System.Windows.Forms.ToolStripMenuItem ThongKetsmi;
        private System.Windows.Forms.ToolStripMenuItem tsmiTK;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaiKhoan;
        private System.Windows.Forms.GroupBox groupedit_NV;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSuaThongTinTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtPasswordDoctor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsernameDoctor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucCLB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucDangKi;
        private System.Windows.Forms.ToolStripMenuItem lớpHànhChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoTừngCâuLạcBộToolStripMenuItem;
    }
}

