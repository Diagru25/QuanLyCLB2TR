using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCLB.Model.View
{
    public class HocSinhView
    {
        public long ID { get; set; }

        public string TenHS { get; set; }

        public bool? GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        public long? Lophc { get; set; }

        public string TenLopHc { get; set; }
    }
}
