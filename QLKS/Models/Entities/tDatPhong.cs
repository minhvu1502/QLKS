namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDatPhong")]
    public partial class tDatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDatPhong()
        {
            tChiTietDatPhong = new HashSet<tChiTietDatPhong>();
        }

        [Key]
        [StringLength(15)]
        public string MaDP { get; set; }

        [StringLength(15)]
        public string MaKH { get; set; }

        [StringLength(250)]
        public string Diachi { get; set; }

        [StringLength(250)]
        public string TenCongTy { get; set; }

        [StringLength(150)]
        public string MaSoThue { get; set; }

        [StringLength(255)]
        public string DiaChiCty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChiTietDatPhong> tChiTietDatPhong { get; set; }

        public virtual tChiTietKH tChiTietKH { get; set; }
    }
}
