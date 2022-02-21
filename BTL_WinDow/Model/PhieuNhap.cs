namespace BTL_WinDow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
        }

        [Key]
        public int SoPN { get; set; }

        public int MaXN { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual XuongNhap XuongNhap { get; set; }
    }
}
