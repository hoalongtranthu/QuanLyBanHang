namespace BTL_WinDow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int MaDH { get; set; }

        public DateTime NgayLapDon { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        [StringLength(30)]
        public string TenKhachHang { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string DiaChi { get; set; }

        public int? MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
