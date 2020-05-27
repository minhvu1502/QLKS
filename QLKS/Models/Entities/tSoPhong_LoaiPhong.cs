namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tSoPhong_LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tSoPhong_LoaiPhong()
        {
            tDangKy = new HashSet<tDangKy>();
        }

        [Key]
        [StringLength(15)]
        public string SoPhong { get; set; }

        [Required]
        [StringLength(15)]
        public string LoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDangKy> tDangKy { get; set; }

        public virtual tLoaiPhong tLoaiPhong { get; set; }
    }
}
