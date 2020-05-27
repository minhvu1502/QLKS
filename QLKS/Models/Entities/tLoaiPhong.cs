namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tLoaiPhong")]
    public partial class tLoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tLoaiPhong()
        {
            tChiTietDatPhong = new HashSet<tChiTietDatPhong>();
            tSoPhong_LoaiPhong = new HashSet<tSoPhong_LoaiPhong>();
        }

        [Key]
        [StringLength(15)]
        public string LoaiPhong { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        public int? DonGia { get; set; }

        [StringLength(50)]
        public string HinhAnh { get; set; }

        [StringLength(10)]
        public string DienTich { get; set; }

        [StringLength(1)]
        public string SoGiuong { get; set; }

        [StringLength(1)]
        public string SoPhongNgu { get; set; }

        [StringLength(1)]
        public string BonTam { get; set; }

        [StringLength(1)]
        public string SoPhongTam { get; set; }

        public double? Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChiTietDatPhong> tChiTietDatPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tSoPhong_LoaiPhong> tSoPhong_LoaiPhong { get; set; }
    }
}
