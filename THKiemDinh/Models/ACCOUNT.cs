namespace THKiemDinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [StringLength(3)]
        public string id { get; set; }

        [StringLength(10)]
        public string id_nv { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
