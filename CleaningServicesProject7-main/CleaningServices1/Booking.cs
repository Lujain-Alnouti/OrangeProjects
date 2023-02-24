//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleaningServices1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.Ratings = new HashSet<Rating>();
            this.Services = new HashSet<Service>();
            this.Services1 = new HashSet<Service>();
        }
    
        public int BookingID { get; set; }
        public string ClientName { get; set; }
        public decimal ClientPhone { get; set; }
        public string Address { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Status { get; set; }
        public string ClientEmail { get; set; }
        public int CityID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services1 { get; set; }
        public virtual Employee Employee { get; set; }
    }
}