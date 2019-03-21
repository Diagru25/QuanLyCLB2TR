namespace QuanLiCLB.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLCLBDbContext : DbContext
    {
        public QLCLBDbContext()
            : base("name=QLCLBDbContext")
        {
        }

        public virtual DbSet<Clb> Clbs { get; set; }
        public virtual DbSet<DangKy> DangKies { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<LopHC> LopHCs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clb>()
                .Property(e => e.MucHocPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DangKy>()
                .Property(e => e.HocPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LopHC>()
                .HasMany(e => e.HocSinhs)
                .WithOptional(e => e.LopHC1)
                .HasForeignKey(e => e.Lophc);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.LichHoc)
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.CaHoc)
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.DangKies)
                .WithOptional(e => e.LopHoc)
                .HasForeignKey(e => e.LopID);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Quyen)
                .IsUnicode(false);
        }
    }
}
