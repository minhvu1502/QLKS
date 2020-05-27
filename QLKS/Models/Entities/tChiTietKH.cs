namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tChiTietKH")]
    public partial class tChiTietKH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tChiTietKH()
        {
            tDangKy = new HashSet<tDangKy>();
            tDatPhong = new HashSet<tDatPhong>();
        }

        [Key]
        [StringLength(15)]
        public string MaKH { get; set; }

        [StringLength(15)]
        public string LoaiKH { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        public DateTime? NgaySinh { get; set; }

        public bool Phai { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(7)]
        public string DienThoai { get; set; }

        public int? DiemTichLuy { get; set; }

        [StringLength(20)]
        public string TheCanCuoc { get; set; }

        public virtual tLoaiKhachHang tLoaiKhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDangKy> tDangKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDatPhong> tDatPhong { get; set; }
    }
}
