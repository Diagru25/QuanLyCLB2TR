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
    public partial class frmLopHC : Form
    {
        List<LopHC> l = null;
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
        public frmLopHC()
        {
            InitializeComponent();
            var nv = new LopHcController();
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
        public void ShowView(List<LopHC> lp)
        {
            l = lp;
            listView1.Items.Clear();
            var i = 1;

            if (l.Count > 0)
            {
                txbID.Text = l[0].ID.ToString();
                txbTen.Text = l[0].Ten.ToString();
                foreach (LopHC row in l)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = "" + i++;
                    item.SubItems.Add(row.ID.ToString());
                    item.SubItems.Add(row.Ten);
                    listView1.Items.Add(item);
                }
            }
            btn_edit(false);
        }

        private void btnAddCLB_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            txbID.Text = "";
            txbTen.Text = "";

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
                var entity = new LopHcController();
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
                var entity = new LopHC();

                entity.Ten = txbTen.Text;
                var clb = new LopHcController();
                long t = clb.Add(entity);
                if (t > 0)
                    ShowView(clb.Detail());
                else
                    MessageBox.Show("Thêm bản ghi không thành công");
            }
            if (Add_bool == false && Edit_bool == true)
            {
                var entity = new LopHC();
                entity.ID = Convert.ToInt64(txbID.Text);
                entity.Ten = txbTen.Text;

                var clb = new LopHcController();
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            long i = Convert.ToInt64(listView1.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID == i);
            txbID.Text = l[index].ID.ToString();
            txbTen.Text = l[index].Ten.ToString();
        }
        // tìm theo tên
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)
            {
                LopHcController drc = new LopHcController();
                var li = drc.FindByName(txtFind.Text);
                if (li.Count <= 0)
                {
                    MessageBox.Show("không tìm thấy");
                    return;
                }
                ShowView(li);
            }
        }
        // làm mới
        private void button2_Click(object sender, EventArgs e)
        {
            LopHcController lc = new LopHcController();
            ShowView(lc.Detail());
        }
    }
}
