namespace THKiemDinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THETHANHVIEN")]
    public partial class THETHANHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THETHANHVIEN()
        {
            PHIEUMUONSACHes = new HashSet<PHIEUMUONSACH>();
        }

        [Key]
        [StringLength(6)]
        public string id_thethanhvien { get; set; }

        [StringLength(50)]
        public string tenkh { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [StringLength(9)]
        public string cmnd { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUONSACH> PHIEUMUONSACHes { get; set; }
    }
}
