using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCLB.controller;
using QuanLiCLB.Model;
using System.Globalization;

namespace QuanLiCLB
{
    public partial class frmLopHoc : Form
    {
        List<LopHoc> l = null;
        private bool Add_bool = false;
        private bool Edit_bool = false;
        public frmLopHoc()
        {
            InitializeComponent();
            //ShowView();
            LopHocController drc = new LopHocController();
            LoadCbb();
            ShowView(drc.Detail());
            IsAdmin(ConstantCommon.QUYEN);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void IsAdmin(string role)
        {
            if (role == "User")
            {
                btnAddLopHoc.Enabled = false;
                btnEditLopHoc.Enabled = false;
                btnDelLopHoc.Enabled = false;
                btnCancel.Enabled = false;
                btnSaveLopHoc.Enabled = false;
            }
        }
        void LoadCbb()
        {
            cbbClb.DataSource = new CLBController().Detail();
            cbbClb.ValueMember = "ID";
            cbbClb.DisplayMember = "TenClb";
        }
        void ShowView(List<LopHoc> ld)
        {
            try
            {
                l = ld;
                lvLopHoc.Items.Clear();
                var i = 1;
                txtIDLopHoc.Text = l[0].ID.ToString();
                txtTenLopHoc.Text = l[0].TenLp.ToString();
                txtLichLopHoc.Text = l[0].LichHoc.ToString();
                cbbClb.SelectedValue = l[0].ClbID;
                txbCaHoc.Text = l[0].CaHoc;
                dtpNgayBD.Value = Convert.ToDateTime(l[0].NgayBatDau);
                foreach (LopHoc row in l)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = "" + i++;
                    item.SubItems.Add(row.ID.ToString());
                    item.SubItems.Add(row.TenLp.ToString());
                    item.SubItems.Add(row.LichHoc.ToString());
                    item.SubItems.Add(Convert.ToDateTime(row.NgayBatDau).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    item.SubItems.Add(row.CaHoc);
                    lvLopHoc.Items.Add(item);
                }
                btn_edit(false);
            }
            catch (Exception)
            {

                
            }
        }

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLopHoc.SelectedItems.Count == 0)
                return;
            long i = Convert.ToInt32(lvLopHoc.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID==i);
            txtIDLopHoc.Text = l[index].ID.ToString();
            txtTenLopHoc.Text = l[index].TenLp.ToString();
            txtLichLopHoc.Text = l[index].LichHoc.ToString();
            txbCaHoc.Text = l[index].CaHoc.ToString();
            dtpNgayBD.Value = Convert.ToDateTime(l[index].NgayBatDau);
            
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {

            btn_edit(true);
            txtIDLopHoc.Text = "";
            txtTenLopHoc.Text = "";
            txtLichLopHoc.Text = "";
            this.Add_bool = true;
        }
        public void btn_edit(bool t)
        {
            grpEditDrug.Enabled = t;
            btnSaveLopHoc.Enabled = t;
            btnCancel.Enabled = t;
            btnAddLopHoc.Enabled = !t;
            btnEditLopHoc.Enabled = !t;
            btnDelLopHoc.Enabled = !t;
            btnExit.Enabled = !t;
            Add_bool = false;
            Edit_bool = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btn_edit(false);
        }

        private void btnEditDrug_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            this.Edit_bool = true;
        }
        private void btnSaveDrug_Click(object sender, EventArgs e)
        {
            if (Add_bool == true && Edit_bool == false)
            {
                LopHoc entity = new LopHoc();
                entity.TenLp = txtTenLopHoc.Text;
                entity.LichHoc = txtLichLopHoc.Text;
                entity.ClbID = Convert.ToInt64(cbbClb.SelectedValue);
                entity.CaHoc = txbCaHoc.Text;
                entity.NgayBatDau = dtpNgayBD.Value;

                var s = new LopHocController();
                long t=s.Add(entity);
                if(t>0)
                ShowView(s.Detail());
            }
            if (Add_bool == false && Edit_bool == true)
            {
                LopHoc entity = new LopHoc();
                entity.ID = Convert.ToInt64(txtIDLopHoc.Text);
                entity.TenLp = txtTenLopHoc.Text;
                entity.LichHoc = txtLichLopHoc.Text;
                entity.ClbID = Convert.ToInt64(cbbClb.SelectedValue);
                entity.CaHoc = txbCaHoc.Text;
                entity.NgayBatDau = dtpNgayBD.Value;
                var s = new LopHocController();
                if (s.Edit(entity))
                    ShowView(s.Detail());
                else
                {
                    MessageBox.Show("Sửa bản ghi không thành công");
                }
            }
            btn_edit(false);
        }

        private void btnDelDrug_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int maLopHoc = Convert.ToInt32(txtIDLopHoc.Text);
                var s = new LopHocController();
                if (s.Del(maLopHoc))
                    ShowView(s.Detail());
                else
                {
                    MessageBox.Show("Không xóa được");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)
            {
                LopHocController drc = new LopHocController();
                var li = drc.FindByName(txtFind.Text);
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
            LopHocController drc = new LopHocController();
            ShowView(drc.Detail());
        }
    }
}
