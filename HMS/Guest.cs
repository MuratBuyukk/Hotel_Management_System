//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guest()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string GuestLastName { get; set; }
        public string GuestTelNo { get; set; }
        public string GuestEmail { get; set; }
        public string GuestNationality { get; set; }
        public string GuestPassaport { get; set; }
        public int BookingId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
