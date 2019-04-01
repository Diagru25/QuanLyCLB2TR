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

namespace QuanLiCLB
{
    public partial class frmThongke_Detail : Form
    {
        QLCLBDbContext db = new QLCLBDbContext();
        public frmThongke_Detail()
        {
            InitializeComponent();
            LoadCbb();
            Thongke();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thongke();
        }
        void LoadCbb()
        {
            comboBox1.DataSource = new LopHcController().Detail();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Ten";
        }
        void Thongke()
        {
            listView_Patient.Clear();
            int ID_LopHC;
            int.TryParse(comboBox1.SelectedValue.ToString(), out ID_LopHC);
            //var l = (from hocsinh in db.HocSinhs
            //         join dk in db.DangKies on hocsinh.ID equals dk.HocSinhID
            //         //where hocsinh.Lophc == ID_LopHC
            //         group hocsinh by hocsinh.Lophc into g
            //         select new
            //         {
            //             TenLop = (from lop in db.LopHCs
            //                       where lop.ID == g.Key
            //                       select lop.Ten).FirstOrDefault(),
            //             //TenLop = g.Key,
            //             Sohocsinh = g.Count(),
            //         }).ToList();
//            ID_LopHC = 1;
            var test = (from hs in db.HocSinhs
                        join dk in db.DangKies on hs.ID equals dk.HocSinhID
                        join lh in db.LopHocs on dk.LopID equals lh.ID
                        join clb in db.Clbs on lh.ClbID equals clb.ID
                        where hs.Lophc == ID_LopHC
                        select new
                        {
                            Tenhs = hs.TenHS,
                            TenCLB = clb.TenClb,
                            TenLopCLB = lh.TenLp
                        }).ToList();
            var i = 0;
            listView_Patient.Columns.Add("STT");
            listView_Patient.Columns.Add("Tên Học sinh");
            listView_Patient.Columns.Add("Tên Câu lạc bộ");
            listView_Patient.Columns.Add("Lớp Câu lạc bộ");
            listView_Patient.Columns[0].Width = 50;
            listView_Patient.Columns[1].Width = 200;
            listView_Patient.Columns[2].Width = 200;
            listView_Patient.Columns[3].Width = 200;
            foreach (var row in test)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(row.Tenhs.ToString());
                item.SubItems.Add(row.TenCLB.ToString());
                item.SubItems.Add(row.TenLopCLB.ToString());
                listView_Patient.Items.Add(item);
            }
        }
    }
}
