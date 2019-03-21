namespace QuanLiCLB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKy")]
    public partial class DangKy
    {
        public long ID { get; set; }

        public long? LopID { get; set; }

        public long? HocSinhID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDky { get; set; }

        public decimal? HocPhi { get; set; }

        public long? TaiKhoanID { get; set; }

        [StringLength(100)]
        public string NguoiDangKy { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual LopHoc LopHoc { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
