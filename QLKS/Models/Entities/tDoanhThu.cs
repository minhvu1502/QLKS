namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDoanhThu")]
    public partial class tDoanhThu
    {
        [Key]
        [StringLength(15)]
        public string MaDK { get; set; }

        [StringLength(15)]
        public string LoaiPhong { get; set; }

        public int? SoNgayO { get; set; }

        public double? ThucThu { get; set; }

        public virtual tDangKy tDangKy { get; set; }
    }
}
