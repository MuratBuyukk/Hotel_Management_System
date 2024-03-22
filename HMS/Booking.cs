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
    using HMS.Entities;
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.Bills = new HashSet<Bill>();
            this.Guests = new HashSet<Guest>();
            this.Services = new HashSet<Service>();
        }
    
        public int BookingId { get; set; }
        public Nullable<int> RoomId { get; set; }
        public System.DateTime CinDate { get; set; }
        public System.DateTime CoutDate { get; set; }
        public Nullable<int> totalNight { get; set; }
        public decimal dailyPrice { get; set; }
        public Nullable<decimal> totalRoomCharge { get; set; }
        public int BookingStatusId { get; set; }
        public int GuestId { get; set; }
        public int UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual BookingStatu BookingStatu { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
    }
}
