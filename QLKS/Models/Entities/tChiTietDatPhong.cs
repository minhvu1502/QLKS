namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tChiTietDatPhong")]
    public partial class tChiTietDatPhong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string MaDP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string LoaiPhong { get; set; }

        public byte SLPhongDat { get; set; }

        public virtual tDatPhong tDatPhong { get; set; }

        public virtual tLoaiPhong tLoaiPhong { get; set; }
    }
}
