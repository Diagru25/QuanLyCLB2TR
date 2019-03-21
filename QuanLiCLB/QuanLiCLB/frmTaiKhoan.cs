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
    public partial class frmTaiKhoan : Form
    {
        List<TaiKhoan> l = null;
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
        public void ShowView(List<TaiKhoan> lp)
        {
            l = lp;
            listView1.Items.Clear();
            var i = 1;

            if (l.Count > 0)
            {
                txbID.Text = l[0].ID.ToString();
                txbUserName.Text = l[0].TenTK.ToString();
                cboQuyen.Text = l[0].Quyen;
                foreach (TaiKhoan row in l)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = "" + i++;
                    item.SubItems.Add(row.ID.ToString());
                    item.SubItems.Add(row.TenTK);
                    item.SubItems.Add(row.Quyen);
                    listView1.Items.Add(item);
                }
            }
            btn_edit(false);
        }

        public frmTaiKhoan()
        {
            InitializeComponent();
            var nv = new TKController();
            ShowView(nv.Detail());
            IsAdmin(ConstantCommon.QUYEN);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            long i = Convert.ToInt64(listView1.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID == i);
            txbID.Text = l[index].ID.ToString();
            txbUserName.Text = l[index].TenTK.ToString();
            cboQuyen.Text = l[index].Quyen;
        }

        private void btnAddCLB_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            txbID.Text = "";
            txbUserName.Text = "";

            this.Add_bool = true;
            txbUserName.Enabled = true;
        }

        private void btnEditCLB_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            Edit_bool = true;
            txbUserName.Enabled = false;
        }

        private void btnDelCLB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                long id = Convert.ToInt64(txbID.Text);
                var entity = new TKController();
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
                var entity = new TaiKhoan();

                entity.TenTK = txbUserName.Text;
                entity.Quyen = string.IsNullOrEmpty(cboQuyen.Text) ? "User" : cboQuyen.Text;
                entity.MatKhau = "1";
                var clb = new TKController();
                long t = clb.Add(entity);
                if (t > 0)
                {
                    ShowView(clb.Detail());
                    MessageBox.Show("Bạn đã tạo 1 tài khoản mới, mật khẩu mặc định là \"1\"");
                }     
                else
                    MessageBox.Show("Thêm bản ghi không thành công" );
            }
            if (Add_bool == false && Edit_bool == true)
            {
                var entity = new TaiKhoan();
                entity.ID = Convert.ToInt64(txbID.Text);
                entity.Quyen = string.IsNullOrEmpty(cboQuyen.Text) ? "User" : cboQuyen.Text;
                var clb = new TKController();
                if (clb.ChangeRole(entity))
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
    }
}
