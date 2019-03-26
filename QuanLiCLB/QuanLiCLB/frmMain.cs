using QuanLiCLB.controller;
using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCLB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (ConstantCommon.QUYEN == "Admin")
            {
                tsmiTaiKhoan.Enabled = true;
                ThongKetsmi.Visible = true;
            }
            //showOne();
        }
        void showOne()
        {
            //new HocSinhController().test();
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            txtUsernameDoctor.Text = ConstantCommon.TEN_DANG_NHAP;
            txtPasswordDoctor.Text = ConstantCommon.MAT_KHAU;
            groupedit_NV.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thay đổi mật khẩu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if(new TKController().EditTK(txtUsernameDoctor.Text, txtPasswordDoctor.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công");
                }
            }
            else
            {
                txtUsernameDoctor.Text = ConstantCommon.TEN_DANG_NHAP;
                txtPasswordDoctor.Text = ConstantCommon.MAT_KHAU;
                return;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtPasswordDoctor.Clear();
            txtUsernameDoctor.Clear();
            groupedit_NV.Enabled = false;
        }
        private void tsmiDanhMucHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.ShowDialog();
        }

        private void tsmiDanhMucLopHoc_Click(object sender, EventArgs e)
        {
            frmLopHoc frm = new frmLopHoc();
            frm.ShowDialog();
        }
        private void tsmiDanhMucCLB_Click(object sender, EventArgs e)
        {
            frmCLB frm = new frmCLB();
            frm.ShowDialog();
        }

        private void tsmiTimKiemDocGia_Click(object sender, EventArgs e)
        {

        }

        private void tsmiTimKiemSach_Click(object sender, EventArgs e)
        {

        }

        private void tsmiTimKiemSachDaChoMuon_Click(object sender, EventArgs e)
        {

        }

        private void tsmiTKThuNhap_Click(object sender, EventArgs e)
        {
            frmThongke_CLB frm = new frmThongke_CLB();
            frm.ShowDialog();
        }

        private void tsmiDanhMucDangKiCLB_Click(object sender, EventArgs e)
        {
            frmDangKiCLB frm = new frmDangKiCLB();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConstantCommon.TEN_DANG_NHAP = "";
            ConstantCommon.ID = 0;
            ConstantCommon.HO_TEN_NV = "";
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void lớpHànhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLopHC frm = new frmLopHC();
            frm.ShowDialog();
        }

        private void tsmiTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void thốngKêTheoTừngCâuLạcBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongke_Detail frm = new frmThongke_Detail();
            frm.ShowDialog();
        }
    }
}
