namespace THKiemDinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            ACCOUNTs = new HashSet<ACCOUNT>();
            PHIEUMUONSACHes = new HashSet<PHIEUMUONSACH>();
        }

        [Key]
        [StringLength(10)]
        public string id_nv { get; set; }

        [StringLength(50)]
        public string tennv { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [StringLength(9)]
        public string cmnd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUONSACH> PHIEUMUONSACHes { get; set; }
    }
}
