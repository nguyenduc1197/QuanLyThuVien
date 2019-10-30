namespace THKiemDinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUMUONSACH")]
    public partial class PHIEUMUONSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUMUONSACH()
        {
            MUONSACHes = new HashSet<MUONSACH>();
        }

        [Key]
        [StringLength(10)]
        public string id_phieumuonsach { get; set; }

        [StringLength(6)]
        public string id_the { get; set; }

        public DateTime? ngaytra { get; set; }

        public DateTime? ngaymuon { get; set; }

        public bool? datrasachhet { get; set; }

        public double? tiendienbu { get; set; }

        [StringLength(10)]
        public string id_nv { get; set; }

        public bool? saved { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUONSACH> MUONSACHes { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THETHANHVIEN THETHANHVIEN { get; set; }
    }
}
