using QLKS.Models.Entities;

namespace QLKS.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLKS : DbContext
    {
        public QLKS()
            : base("name=QLKS1")
        {
        }

        public virtual DbSet<tChiTietDatPhong> tChiTietDatPhong { get; set; }
        public virtual DbSet<tChiTietKH> tChiTietKH { get; set; }
        public virtual DbSet<tDangKy> tDangKy { get; set; }
        public virtual DbSet<tDanhGia> tDanhGia { get; set; }
        public virtual DbSet<tDatPhong> tDatPhong { get; set; }
        public virtual DbSet<tDoanhThu> tDoanhThu { get; set; }
        public virtual DbSet<tLoaiKhachHang> tLoaiKhachHang { get; set; }
        public virtual DbSet<tLoaiPhong> tLoaiPhong { get; set; }
        public virtual DbSet<tSoPhong_LoaiPhong> tSoPhong_LoaiPhong { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tChiTietDatPhong>()
                .Property(e => e.MaDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tChiTietDatPhong>()
                .Property(e => e.LoaiPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tChiTietKH>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tChiTietKH>()
                .Property(e => e.LoaiKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDangKy>()
                .Property(e => e.MaDK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDangKy>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDangKy>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDangKy>()
                .HasOptional(e => e.tDoanhThu)
                .WithRequired(e => e.tDangKy);

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.MaDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.ViTri)
                .IsFixedLength();

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.PhucVu)
                .IsFixedLength();

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.TienNghi)
                .IsFixedLength();

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.GiaCa)
                .IsFixedLength();

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.VeSinh)
                .IsFixedLength();

            modelBuilder.Entity<tDanhGia>()
                .Property(e => e.MonAn)
                .IsFixedLength();

            modelBuilder.Entity<tDatPhong>()
                .Property(e => e.MaDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDatPhong>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDatPhong>()
                .HasMany(e => e.tChiTietDatPhong)
                .WithRequired(e => e.tDatPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tDoanhThu>()
                .Property(e => e.MaDK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDoanhThu>()
                .Property(e => e.LoaiPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tLoaiKhachHang>()
                .Property(e => e.LoaiKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tLoaiPhong>()
                .Property(e => e.LoaiPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tLoaiPhong>()
                .Property(e => e.DienTich)
                .IsFixedLength();

            modelBuilder.Entity<tLoaiPhong>()
                .Property(e => e.SoGiuong)
                .IsFixedLength();

            modelBuilder.Entity<tLoaiPhong>()
                .Property(e => e.SoPhongNgu)
                .IsFixedLength();

            modelBuilder.Entity<tLoaiPhong>()
                .Property(e => e.BonTam)
                .IsFixedLength();

            modelBuilder.Entity<tLoaiPhong>()
                .Property(e => e.SoPhongTam)
                .IsFixedLength();

            modelBuilder.Entity<tLoaiPhong>()
                .HasMany(e => e.tChiTietDatPhong)
                .WithRequired(e => e.tLoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tLoaiPhong>()
                .HasMany(e => e.tSoPhong_LoaiPhong)
                .WithRequired(e => e.tLoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tSoPhong_LoaiPhong>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSoPhong_LoaiPhong>()
                .Property(e => e.LoaiPhong)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
