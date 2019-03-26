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
    public partial class frmThongke_CLB : Form
    {
        QLCLBDbContext db = new QLCLBDbContext();
        public frmThongke_CLB()
        {
            InitializeComponent();
            LoadCbb();
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
            ID_LopHC = 1;
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

            var test = (from dk in db.DangKies
                        join hs in db.HocSinhs on dk.HocSinhID equals hs.ID
                        select new
                        {
                            MaLopHC = hs.Lophc,
                            ID_Hocsinh = hs.ID,
                        }).Distinct().ToList();
            var r = (from x in test
                     group x by x.MaLopHC into g
                     select new
                     {
                         TenLop = (from lop in db.LopHCs
                                   where lop.ID == g.Key
                                   select lop.Ten).FirstOrDefault(),
                         Sohocsinh = g.Count()
                     }
                ).ToList();
            var i = 0;
            listView_Patient.Columns.Add("STT");
            listView_Patient.Columns.Add("Tên Lớp");
            listView_Patient.Columns.Add("Số học sinh tham gia");
            listView_Patient.Columns[0].Width = 50;
            listView_Patient.Columns[1].Width = 100;
            listView_Patient.Columns[2].Width = 200;
            foreach (var row in r)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(row.TenLop.ToString());
                item.SubItems.Add(row.Sohocsinh.ToString());
                listView_Patient.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thongke();
        }
    }
}
