namespace BTL_WinDow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuongNhap")]
    public partial class XuongNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XuongNhap()
        {
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        public int MaXN { get; set; }

        [StringLength(100)]
        public string TenXN { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
