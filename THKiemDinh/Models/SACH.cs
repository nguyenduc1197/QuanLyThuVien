namespace THKiemDinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            MUONSACHes = new HashSet<MUONSACH>();
        }

        [Key]
        [StringLength(10)]
        public string id_sach { get; set; }

        [StringLength(50)]
        public string tensach { get; set; }

        [StringLength(3)]
        public string id_tinhtrangsach { get; set; }

        public int? soluong { get; set; }

        [StringLength(10)]
        public string id_loai { get; set; }

        public double? giagoc { get; set; }

        public virtual LOAISACH LOAISACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUONSACH> MUONSACHes { get; set; }

        public virtual TINHTRANG TINHTRANG { get; set; }
    }
}
