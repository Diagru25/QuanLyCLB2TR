using QuanLiCLB.controller;
using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCLB
{
    public partial class frmDangKiCLB : Form
    {
        //double? cost;
        List<DangKy> l = null;
        private bool Add_bool = false;
        private bool Edit_bool = false;

        public void btn_edit(bool t)
        {
            groupBox3.Enabled = t;
            btnAddCLB.Enabled = !t;
            btnEditCLB.Enabled = !t;
            btnDelCLB.Enabled = !t;
            btnSaveCLB.Enabled = t;
            btnCancel.Enabled = t;
            Add_bool = false;
            Edit_bool = false;
        }
        public frmDangKiCLB()
        {
            InitializeComponent();
            loadCbo();
            var nv = new DangKiCLBController();
            ShowView(nv.Detail());
            IsAdmin(ConstantCommon.QUYEN);
        }
        void IsAdmin(string role)
        {
            if (role == "User")
            {
                btnAddCLB.Enabled = false;
                btnEditCLB.Enabled = false;
                btnDelCLB.Enabled = false;
                btnCancel.Enabled = false;
                btnSaveCLB.Enabled = false;
            }
        }
        void loadCbo()
        {
            cboHS.DataSource = new HocSinhController().Detail();
            cboHS.ValueMember = "ID";
            cboHS.DisplayMember = "TenHS";

            cboLop.DataSource = new LopHocController().Detail();
            cboLop.ValueMember = "ID";
            cboLop.DisplayMember = "TenLp";
        }
        public void ShowView(List<DangKy> lp)
        {
            l = lp;
            listviewDK.Items.Clear();
            var i = 1;

            if (l.Count > 0)
            {
                txbID.Text = l[0].ID.ToString();
                txbHocPhi.Text = ((Decimal)l[0].HocPhi).ToString("N0");
                cboLop.SelectedValue = l[0].LopID;
                cboHS.SelectedValue = l[0].HocSinhID;
                dtpNgayDK.Value = Convert.ToDateTime(l[0].NgayDky);
                txbNguoiDK.Text = l[0].NguoiDangKy.ToString();
                foreach (DangKy row in l)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = "" + i++;
                    item.SubItems.Add(row.ID.ToString());
                    item.SubItems.Add((new LopHocController().DetailOne((long)row.LopID)).TenLp);
                    item.SubItems.Add((new HocSinhController().DetailOne((long)row.HocSinhID)).TenHS);
                    item.SubItems.Add(((Decimal)row.HocPhi).ToString("N0"));
                    listviewDK.Items.Add(item);
                }
            }
            btn_edit(false);
        }

        private void listviewDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewDK.SelectedItems.Count == 0)
                return;
            long i = Convert.ToInt64(listviewDK.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID == i);
            txbID.Text = l[index].ID.ToString();
            txbHocPhi.Text = ((Decimal)l[index].HocPhi).ToString("N0");
            cboLop.SelectedValue = l[index].LopID;
            cboHS.SelectedValue = l[index].HocSinhID;
            dtpNgayDK.Value = Convert.ToDateTime(l[index].NgayDky);
            txbNguoiDK.Text = l[index].NguoiDangKy;
        }

        private void btnAddCLB_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            txbID.Text = "";
            txbNguoiDK.Text = "";
            txbHocPhi.Text = "";

            this.Add_bool = true;
        }

        private void btnEditCLB_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            Edit_bool = true;
        }

        private void btnDelCLB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                long id = Convert.ToInt64(txbID.Text);
                var entity = new DangKiCLBController();
                if (entity.delete(id))
                    ShowView(entity.Detail());
                else
                    MessageBox.Show("Không xóa được!");
            }
        }

        private void btnSaveCLB_Click(object sender, EventArgs e)
        {
            if (Add_bool == true && Edit_bool == false)
            {
                var entity = new DangKy();

                entity.HocSinhID = Convert.ToInt32(cboHS.SelectedValue);
                entity.LopID = Convert.ToInt32(cboLop.SelectedValue);
                entity.HocPhi = Convert.ToDecimal(txbHocPhi.Text);
                entity.NgayDky = dtpNgayDK.Value;
                entity.TaiKhoanID = ConstantCommon.ID;
                entity.NguoiDangKy = txbNguoiDK.Text;

                var clb = new DangKiCLBController();
                long t = clb.Add(entity);
                if (t > 0)
                    ShowView(clb.Detail());
                else
                    MessageBox.Show("Thêm bản ghi không thành công");
            }
            if (Add_bool == false && Edit_bool == true)
            {
                var entity = new DangKy();

                entity.ID = Convert.ToInt32(txbID.Text);
                entity.HocSinhID = Convert.ToInt32(cboHS.SelectedValue);
                entity.LopID = Convert.ToInt32(cboLop.SelectedValue);
                entity.HocPhi = Convert.ToDecimal(txbHocPhi.Text);
                entity.NgayDky = dtpNgayDK.Value;
                entity.TaiKhoanID = ConstantCommon.ID;
                entity.NguoiDangKy = txbNguoiDK.Text;

                var clb = new DangKiCLBController();
                if (clb.Edit(entity))
                    ShowView(clb.Detail());
                else
                    MessageBox.Show("Sửa bản ghi không thành công");
            }
            btn_edit(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btn_edit(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)
            {
                DangKiCLBController drc = new DangKiCLBController();
                var li = drc.Find(txtFind.Text);
                if (li.Count <= 0)
                {
                    MessageBox.Show("không tìm thấy");
                    return;
                }
                ShowView(li);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKiCLBController drc = new DangKiCLBController();
            ShowView(drc.Detail());
        }
    }
}
