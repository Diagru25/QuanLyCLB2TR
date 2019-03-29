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
using System.Collections;
using System.Globalization;
using QuanLiCLB.Model.View;

namespace QuanLiCLB
{
    public partial class frmHocSinh : Form
    {
        List<HocSinhView> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = false;
        public frmHocSinh()
        {
            InitializeComponent();
            var dg = new HocSinhController();
            loadcbb();
            ShowView(dg.DetailView());
            IsAdmin(ConstantCommon.QUYEN);
        }
        void IsAdmin(string role)
        {
            if (role == "User")
            {
                btnAddHocSinh.Enabled = false;
                btnEditHocSinh.Enabled = false;
                btnDelHocSinh.Enabled = false;
                btnCancel.Enabled = false;
                btnSaveHocSinh.Enabled = false;
            }
        }
        void loadcbb()
        {
            cbbLopHocSinh.DataSource = new LopHcController().Detail();
            cbbLopHocSinh.ValueMember = "ID";
            cbbLopHocSinh.DisplayMember = "Ten";
        }
        public void ShowView(List<HocSinhView> ld)
        {
            l = ld;
            int i = 1;
            txtIDHocSinh.Text = l[0].ID.ToString();
            txtTenHocSinh.Text = string.IsNullOrEmpty(l[0].TenHS) ? "" : l[0].TenHS.ToString();
            dtpDateHocSinh.Text = Convert.ToDateTime(l[0].NgaySinh).ToShortDateString();
            cbbLopHocSinh.SelectedValue = l[0].Lophc;
            if (l[0].GioiTinh == null) cbbGenderHocSinh.Text = "";
            else cbbGenderHocSinh.Text = (l[0].GioiTinh == true) ? "Nam" : "Nữ";
            listView_HocSinh.Items.Clear();
            foreach (var row in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(row.ID.ToString());
                item.SubItems.Add(row.TenHS);
                item.SubItems.Add((row.GioiTinh != null && row.GioiTinh == true) ? "Nam" : "Nữ");
                item.SubItems.Add(Convert.ToDateTime(row.NgaySinh).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                item.SubItems.Add(row.TenLopHc);

                listView_HocSinh.Items.Add(item);
            }
            btn_enable(false);

        }

        public void ListView_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_HocSinh.SelectedItems.Count == 0) return;
            long id = Convert.ToInt64(listView_HocSinh.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID == id);
            txtIDHocSinh.Text = l[index].ID.ToString();
            txtTenHocSinh.Text = l[index].TenHS;
            dtpDateHocSinh.Text = l[index].NgaySinh.ToString();
            cbbLopHocSinh.SelectedValue = l[index].Lophc;
            if (l[index].GioiTinh == null) cbbGenderHocSinh.Text = "";
            else cbbGenderHocSinh.Text = (l[index].GioiTinh == true) ? "Nam" : "Nữ";
        }
        public void btn_enable(bool t)
        {
            groupDG.Enabled = t;
            btnAddHocSinh.Enabled = !t;
            btnEditHocSinh.Enabled = !t;
            btnDelHocSinh.Enabled = !t;
            btnSaveHocSinh.Enabled = t;
            btnCancel.Enabled = t;
            Them_bool = false;
            Sua_bool = false;
        }
        void add(bool t)
        {
            txtTenHocSinh.Enabled = t;
            dtpDateHocSinh.Enabled = t;
            cbbGenderHocSinh.Enabled = t;
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            btn_enable(true);
            txtIDHocSinh.Text = "";
            txtTenHocSinh.Text = "";
            dtpDateHocSinh.Text = "";
            cbbGenderHocSinh.Text = "";
            add(true);
            this.Them_bool = true;
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            add(true);
            btn_enable(true);
            Sua_bool = true;
        }

        private void btnDelDoctor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chắc chắn muốn bản ghi không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                long id = Convert.ToInt64(txtIDHocSinh.Text);
                var entity = new HocSinhController();
                if (entity.Del(id))
                    ShowView(entity.DetailView());
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
            if (Them_bool == true && Sua_bool == false)
            {
                var entity = new HocSinh();
                entity.TenHS = txtTenHocSinh.Text;
                entity.GioiTinh = cbbGenderHocSinh.Text == "Nam" ? true : false;
                entity.NgaySinh = dtpDateHocSinh.Value;
                entity.Lophc = Convert.ToInt64(cbbLopHocSinh.SelectedValue);

                var dg = new HocSinhController();
                long ijk = dg.Add(entity);
                if (ijk > 0)
                    ShowView(dg.DetailView());
                else
                    MessageBox.Show("Thêm bản ghi không thành công");
                add(false);
            }
            ///sua hoc sinh
            if (Them_bool == false && Sua_bool == true)
            {
                var entity = new HocSinh();
                entity.ID = Convert.ToInt32(txtIDHocSinh.Text);
                entity.TenHS = txtTenHocSinh.Text;
                entity.GioiTinh = cbbGenderHocSinh.Text == "Nam" ? true : false;
                entity.NgaySinh = dtpDateHocSinh.Value;
                entity.Lophc = Convert.ToInt64(cbbLopHocSinh.SelectedValue);
                var dg = new HocSinhController();
                if (dg.Edit(entity))
                    ShowView(dg.DetailView());
                else
                    MessageBox.Show("Sửa bản ghi không thành công");
            }
            btn_enable(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btn_enable(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)
            {
                HocSinhController drc = new HocSinhController();
                var li = drc.FindByNameView(txtFind.Text);
                if (li.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy.");
                    return;
                }

                ShowView(li);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocSinhController dtc = new HocSinhController();
            ShowView(dtc.DetailView());
        }
    }
}
