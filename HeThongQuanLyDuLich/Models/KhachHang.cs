//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeThongQuanLyDuLich.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.VeDatTours = new HashSet<VeDatTour>();
        }
    
        public int IDKhachHang { get; set; }
        public string hoTenKhachHang { get; set; }
        public string sdtKhachHang { get; set; }
        public string diaChi { get; set; }
        public string CMND { get; set; }
        public Nullable<int> IDTaiKhoan { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeDatTour> VeDatTours { get; set; }
    }
}
