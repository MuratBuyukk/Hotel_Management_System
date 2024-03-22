using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.ViewModels
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public int RoomId { get;set; }
        public int RoomNo { get; set; }
        public DateTime CinDate { get; set; }
        public DateTime CoutDate { get; set; }
        public int TotalNight { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal TotalRoomCharge { get; set; }
        public int BookingStatusId { get; set; }
        public string BookingStatusName { get; set; }
        public int GuestId { get; set;}
        public string GuestLastName { get; set; }
        public int UserId { get; set;}
        public string UserName { get; set; }
    }
}
