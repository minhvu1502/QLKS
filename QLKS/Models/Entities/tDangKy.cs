namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDangKy")]
    public partial class tDangKy
    {
        [Key]
        [StringLength(15)]
        public string MaDK { get; set; }

        [StringLength(15)]
        public string MaKH { get; set; }

        [StringLength(15)]
        public string SoPhong { get; set; }

        public DateTime? NgayVao { get; set; }

        public DateTime? NgayRa { get; set; }

        public virtual tChiTietKH tChiTietKH { get; set; }

        public virtual tSoPhong_LoaiPhong tSoPhong_LoaiPhong { get; set; }

        public virtual tDoanhThu tDoanhThu { get; set; }
    }
}
