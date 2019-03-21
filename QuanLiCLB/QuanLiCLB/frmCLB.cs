using QuanLiCLB.controller;
using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCLB
{
    public partial class frmCLB : Form
    {
        List<Clb> l =null;
        private bool Add_bool = false;
        private bool Edit_bool = false;

        public void btn_edit(bool t)
        {
            groupedit_Patient.Enabled = t;
            btnAddCLB.Enabled = !t;
            btnEditCLB.Enabled = !t;
            btnDelCLB.Enabled = !t;
            btnSaveCLB.Enabled = t;
            btnCancel.Enabled = t;
            Add_bool = false;
            Edit_bool = false;
        }
        public frmCLB()
        {
            InitializeComponent();
            var nv = new CLBController();
            ShowView(nv.Detail());
            IsAdmin(ConstantCommon.QUYEN);
        }
        void IsAdmin(string role)
        {
            if(role == "User")
            {
                btnAddCLB.Enabled = false;
                btnEditCLB.Enabled = false;
                btnDelCLB.Enabled = false;
                btnCancel.Enabled = false;
                btnSaveCLB.Enabled = false;
            }
        }
        public void ShowView(List<Clb> lp)
        {
            l = lp;
            listView_Patient.Items.Clear();
            var i = 1;

            if (l.Count>0)
            {
                txtIDCLB.Text = l[0].ID.ToString();
                txtNameCLB.Text = l[0].TenClb.ToString();
                txtHocPhiCLB.Text = ((Decimal)l[0].MucHocPhi).ToString("N0");
                foreach (Clb row in l)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = "" + i++;
                    item.SubItems.Add(row.ID.ToString());
                    item.SubItems.Add(row.TenClb);
                    item.SubItems.Add(((Decimal)row.MucHocPhi).ToString("N0"));
                    listView_Patient.Items.Add(item);
                } 
            } 
            btn_edit(false);
        }

        private void ListView_Patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Patient.SelectedItems.Count == 0)
                return;
            long i = Convert.ToInt64(listView_Patient.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID == i);
            txtIDCLB.Text = l[index].ID.ToString();
            txtNameCLB.Text = l[index].TenClb.ToString();
            txtHocPhiCLB.Text = ((Decimal)l[index].MucHocPhi).ToString("N0");
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            txtIDCLB.Text = "";
            txtNameCLB.Text = "";
            txtHocPhiCLB.Text = "";
            
            this.Add_bool = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            Edit_bool = true;
        }

        private void btnDelPatient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==DialogResult.Yes)
            {
                long id = Convert.ToInt64(txtIDCLB.Text);
                var entity = new CLBController();
                if (entity.delete(id))
                    ShowView(entity.Detail());
                else
                    MessageBox.Show("Không xóa được!");
            }
        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            if(Add_bool==true && Edit_bool==false)
            {
                var entity = new Clb();
                
                entity.TenClb = txtNameCLB.Text;
                entity.MucHocPhi = Convert.ToDecimal(txtHocPhiCLB.Text);
                var clb = new CLBController();
                long t = clb.Add(entity);
                if ( t>0)
                    ShowView(clb.Detail());
                else
                    MessageBox.Show("Thêm bản ghi không thành công");
            }
            if(Add_bool==false && Edit_bool==true)
            {
                var entity = new Clb();
                entity.ID = Convert.ToInt64(txtIDCLB.Text);
                entity.TenClb = txtNameCLB.Text;
                entity.MucHocPhi = Convert.ToDecimal(txtHocPhiCLB.Text);
                
                var clb = new CLBController();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Length > 0)
            {
                CLBController drc = new CLBController();
                var li = drc.FindByName(txtFind.Text);
                if (li.Count <= 0)
                {
                    MessageBox.Show("không tìm thấy.");
                    return;
                }
                ShowView(li);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLBController dtc = new CLBController();
            ShowView(dtc.Detail());
        }

        private void txtHocPhiCLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
