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
    
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.VeDatTours = new HashSet<VeDatTour>();
        }
    
        public int IDTour { get; set; }
        public string tourName { get; set; }
        public string tourDescription { get; set; }
        public Nullable<int> soLuongKhachToiDa { get; set; }
        public Nullable<int> soLuongKhachHienTai { get; set; }
        public string hinhAnh { get; set; }
        public Nullable<bool> tinhTrangTour { get; set; }
        public Nullable<int> IDHanhTrinh { get; set; }
        public Nullable<int> IDDichVu { get; set; }
        public Nullable<int> IDKhachSan { get; set; }
        public Nullable<int> IDKhuyenMai { get; set; }
    
        public virtual DichVu DichVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual HanhTrinh HanhTrinh { get; set; }
        public virtual KhachSan KhachSan { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeDatTour> VeDatTours { get; set; }
    }
}
