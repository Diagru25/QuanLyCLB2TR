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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                if (txtPassword.Text.Length > 0)
                {
                    TaiKhoan temp = new TaiKhoan();
                    temp = new TKController().Login(txtUsername.Text, txtPassword.Text);
                    if (temp == null)
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                        return;
                    }
                    else
                    {
                        ConstantCommon.ID = temp.ID;
                        ConstantCommon.QUYEN = temp.Quyen;
                        ConstantCommon.TEN_DANG_NHAP = txtUsername.Text;
                        ConstantCommon.MAT_KHAU = txtPassword.Text;
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}
