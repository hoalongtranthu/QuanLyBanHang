namespace BTL_WinDow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
        }

        [Key]
        public int MaSach { get; set; }

        [Required]
        [StringLength(100)]
        public string TieuDe { get; set; }

        [Column(TypeName = "image")]
        public byte[] AnhBia { get; set; }

        public DateTime NgayPhatHanh { get; set; }

        public int GiaBan { get; set; }

        [StringLength(30)]
        public string TacGia { get; set; }

        [StringLength(30)]
        public string NhaPhatHanh { get; set; }

        public int? SoLuongCo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
