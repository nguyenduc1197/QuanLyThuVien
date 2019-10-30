namespace THKiemDinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUONSACH")]
    public partial class MUONSACH
    {
        [Key]
        [StringLength(10)]
        public string id_muonsach { get; set; }

        [StringLength(10)]
        public string id_phieumuon { get; set; }

        [StringLength(10)]
        public string id_sach { get; set; }

        public int soluong { get; set; }

        public bool? datra { get; set; }

        public DateTime? ngaytra { get; set; }

        public virtual PHIEUMUONSACH PHIEUMUONSACH { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
