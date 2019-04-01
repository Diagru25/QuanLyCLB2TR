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
            Thongke();
        }
        void Thongke()
        {
            listView_Patient.Clear();
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
            //var r1 = (from lops in db.LopHCs
            //          join lop in r on lops.Ten equals lop.TenLop into abc
            //          from b in abc.DefaultIfEmpty()
            //          select new
            //          {
            //              TenLop = lops.Ten,
            //              Sohocsinh = b.Sohocsinh,
            //          }).ToList();
            var lophc = (from lop in db.LopHCs
                         join hs in db.HocSinhs on lop.ID equals hs.Lophc
                         select new
                         {
                             Malop = lop.ID,
                             ID_HS = hs.ID
                         }).Distinct().ToList();
            var r2 = (from x in lophc
                      group x by x.Malop into g
                      select new
                      {
                          TenLop = (from lop in db.LopHCs
                                    where lop.ID == g.Key
                                    select lop.Ten).FirstOrDefault(),
                          Sohocsinh = g.Count()
                      }
                ).ToList();
            //var testl = (from lophc in db.LopHCs
            //             join hs in db.HocSinhs);
            var i = 0;
            listView_Patient.Columns.Add("STT");
            listView_Patient.Columns.Add("Tên Lớp");
            listView_Patient.Columns.Add("Số học sinh");
            listView_Patient.Columns[0].Width = 50;
            listView_Patient.Columns[1].Width = 100;
            listView_Patient.Columns[2].Width = 200;
            foreach (var row in r2)
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
