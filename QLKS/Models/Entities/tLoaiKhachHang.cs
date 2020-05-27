namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tLoaiKhachHang")]
    public partial class tLoaiKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tLoaiKhachHang()
        {
            tChiTietKH = new HashSet<tChiTietKH>();
        }

        [Key]
        [StringLength(15)]
        public string LoaiKH { get; set; }

        [StringLength(50)]
        public string DienGiai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChiTietKH> tChiTietKH { get; set; }
    }
}
