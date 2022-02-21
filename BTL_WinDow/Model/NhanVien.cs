namespace BTL_WinDow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            DonHangs = new HashSet<DonHang>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        public int MaNV { get; set; }

        [StringLength(30)]
        public string HoTen { get; set; }

        public int? Tuoi { get; set; }

        [StringLength(30)]
        public string DiaChi { get; set; }

        public bool? isAdmin { get; set; }

        [StringLength(20)]
        public string TenDangNhap { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
