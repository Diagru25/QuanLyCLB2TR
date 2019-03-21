namespace QuanLiCLB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            DangKies = new HashSet<DangKy>();
        }

        public long ID { get; set; }

        [StringLength(200)]
        public string TenLp { get; set; }

        [Column(TypeName = "text")]
        public string LichHoc { get; set; }

        public long? ClbID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [StringLength(50)]
        public string CaHoc { get; set; }

        public virtual Clb Clb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKy> DangKies { get; set; }
    }
}
