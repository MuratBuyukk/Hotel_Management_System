
using HMS.Business.Repository.Concrete;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GuestBussiness guestBussiness = new GuestBussiness();
            RoomBusiness roomBusiness = new RoomBusiness();
            roomBusiness.ChangeRoomStatus(1, 4);
            var items = roomBusiness.GetAll();
            foreach(var item in items)
            {
                Console.WriteLine("room id: " + item.RoomId + "room status: " + item.RoomStatusId);
            }
           

            

        }
    }
}
