namespace QLKS.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDanhGia")]
    public partial class tDanhGia
    {
        [Key]
        [StringLength(15)]
        public string MaDG { get; set; }

        [StringLength(4000)]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string NguoiDanhGia { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(1)]
        public string ViTri { get; set; }

        [StringLength(1)]
        public string PhucVu { get; set; }

        [StringLength(1)]
        public string TienNghi { get; set; }

        [StringLength(1)]
        public string GiaCa { get; set; }

        [StringLength(1)]
        public string VeSinh { get; set; }

        [StringLength(1)]
        public string MonAn { get; set; }
    }
}
