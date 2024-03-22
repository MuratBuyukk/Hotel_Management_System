using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.ViewModels
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }
        public int RoomStatusId { get; set; }
        public int RoomTypeId { get; set; }
        public int Floor { get; set; }
        public int RoomNo { get; set; }
        public String RoomStatusName { get; set; }
        public String RoomTypeName { get; set; }


    }
}
