//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV_DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.CTPHIEUMUONs = new HashSet<CTPHIEUMUON>();
        }
    
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTheLoai { get; set; }
        public int NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public string MaTacGia { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public decimal TriGia { get; set; }
        public string MaTinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUMUON> CTPHIEUMUONs { get; set; }
        public virtual TACGIA TACGIA { get; set; }
        public virtual THELOAI THELOAI { get; set; }
        public virtual TINHTRANG TINHTRANG { get; set; }
    }
}
