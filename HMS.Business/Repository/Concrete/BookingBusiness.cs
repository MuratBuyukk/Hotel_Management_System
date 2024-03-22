using HMS.Business.Repository.Abstract;
using HMS.Entities;
using HMS.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Repository.Concrete
{
    public class BookingBusiness : IDatabaseBusiness<Booking>
    {
        public void Add(Booking entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Bookings.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Booking entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Bookings.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.Bookings.Find(id);
                db.Bookings.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Booking Get(Expression<Func<Booking, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Bookings.Where(expression).FirstOrDefault();
            }
        }

        public List<Booking> GetAll(Expression<Func<Booking, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Bookings.Where(expression).ToList();
            }
        }

        public List<Booking> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Bookings.ToList();
            }
        }

        public Booking GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Bookings.Find(id);
            }
        }

        public void Update(Booking entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Bookings.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<BookingViewModel> GetRezervationList()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from b in db.Bookings
                                  join s in db.BookingStatus on b.BookingStatusId equals s.BookingStatusId
                                  join u in db.Users on b.UserId equals u.UserId
                                  join r in db.Rooms on b.RoomId equals r.RoomId
                                  join g in db.Guests on b.GuestId equals g.GuestId
                                  where b.BookingStatusId == 1
                                  select new
                                  {
                                      b,
                                      s.BookingStatusName,
                                      u.UserName,
                                      r.RoomNo,
                                      g.GuestLastName
                                  };
                var bookings = new List<BookingViewModel>();
                foreach (var b in queryResult)
                {
                    bookings.Add(new BookingViewModel
                    {
                        BookingId = b.b.BookingId,
                        RoomId = (int)b.b.RoomId,
                        RoomNo = b.RoomNo,
                        CinDate = b.b.CinDate,
                        CoutDate = b.b.CoutDate,
                        TotalNight = (int)b.b.TotalNight,
                        DailyPrice = b.b.DailyPrice,
                        TotalRoomCharge = (decimal)b.b.TotalRoomCharge,
                        BookingStatusId = b.b.BookingStatusId,
                        BookingStatusName = b.BookingStatusName,
                        GuestId = b.b.GuestId,
                        GuestLastName = b.GuestLastName,
                        UserId = b.b.UserId,
                        UserName = b.UserName
                    });
                }
                return bookings;
            }
        }
        public List<BookingViewModel> GetAcommadationList()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from b in db.Bookings
                                  join s in db.BookingStatus on b.BookingStatusId equals s.BookingStatusId
                                  join u in db.Users on b.UserId equals u.UserId
                                  join r in db.Rooms on b.RoomId equals r.RoomId
                                  join g in db.Guests on b.GuestId equals g.GuestId
                                  where b.BookingStatusId == 2
                                  select new
                                  {
                                      b,
                                      s.BookingStatusName,
                                      u.UserName,
                                      r.RoomNo,
                                      g.GuestLastName
                                  };
                var bookings = new List<BookingViewModel>();
                foreach (var b in queryResult)
                {
                    bookings.Add(new BookingViewModel
                    {
                        BookingId = b.b.BookingId,
                        RoomId = (int)b.b.RoomId,
                        RoomNo = b.RoomNo,
                        CinDate = b.b.CinDate,
                        CoutDate = b.b.CoutDate,
                        TotalNight = (int)b.b.TotalNight,
                        DailyPrice = b.b.DailyPrice,
                        TotalRoomCharge = (decimal)b.b.TotalRoomCharge,
                        BookingStatusId = b.b.BookingStatusId,
                        BookingStatusName = b.BookingStatusName,
                        GuestId = b.b.GuestId,
                        GuestLastName = b.GuestLastName,
                        UserId = b.b.UserId,
                        UserName = b.UserName
                    });
                }
                return bookings;
            }
        }
        public List<BookingViewModel> GetDepartedList()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from b in db.Bookings
                                  join s in db.BookingStatus on b.BookingStatusId equals s.BookingStatusId
                                  join u in db.Users on b.UserId equals u.UserId
                                  join r in db.Rooms on b.RoomId equals r.RoomId
                                  join g in db.Guests on b.GuestId equals g.GuestId
                                  where b.BookingStatusId == 3
                                  select new
                                  {
                                      b,
                                      s.BookingStatusName,
                                      u.UserName,
                                      r.RoomNo,
                                      g.GuestLastName
                                  };
                var bookings = new List<BookingViewModel>();
                foreach (var b in queryResult)
                {
                    bookings.Add(new BookingViewModel
                    {
                        BookingId = b.b.BookingId,
                        RoomId = (int)b.b.RoomId,
                        RoomNo = b.RoomNo,
                        CinDate = b.b.CinDate,
                        CoutDate = b.b.CoutDate,
                        TotalNight = (int)b.b.TotalNight,
                        DailyPrice = b.b.DailyPrice,
                        TotalRoomCharge = (decimal)b.b.TotalRoomCharge,
                        BookingStatusId = b.b.BookingStatusId,
                        BookingStatusName = b.BookingStatusName,
                        GuestId = b.b.GuestId,
                        GuestLastName = b.GuestLastName,
                        UserId = b.b.UserId,
                        UserName = b.UserName
                    });
                }
                return bookings;
            }
        }

        public void ChangeBookingStatus(int bookingId, int status)
        {
            var items = GetAll();
            foreach (var item in items)
            {
                if (item.BookingId == bookingId)
                {
                    Update(new Booking
                    {
                        BookingId = bookingId,
                        RoomId = item.RoomId,
                        CinDate = item.CinDate,
                        CoutDate = item.CoutDate,
                        TotalNight = item.TotalNight,
                        DailyPrice = item.DailyPrice,
                        TotalRoomCharge = item.TotalRoomCharge,
                        BookingStatusId = status,
                        GuestId = item.GuestId,
                        UserId = item.UserId
                    });
                }
            }
        }
        public int NumberOfTotals(int status)
        {
            int result = 0;
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from b in db.Bookings
                                  where b.BookingStatusId == status
                                  select new
                                  {
                                      b,
                                  };
                foreach (var r in queryResult)
                {
                    result++;
                }
            }
            return result;
        }
        public int NumberOfLists(int type, int status)
        {
            int result = 0;
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from b in db.Bookings
                                  join r in db.Rooms on b.RoomId equals r.RoomId
                                  where b.BookingStatusId == status && r.RoomTypeId == type
                                  select new
                                  {
                                      b
                                  };
                foreach (var r in queryResult)
                {
                    result++;
                }
            }
                return result;
        }

        public List<SP_RoomTypeReportByBooking_Result> GetReportByBookingReport()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.SP_RoomTypeReportByBooking().ToList();
            }
        }
        public List<SP_RoomTypeReportByAccommodation_Result> GetReportByAccommodationReport()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.SP_RoomTypeReportByAccommodation().ToList();
            }
        }

        public List<SP_RoomTypeReportByDeparted_Result> GetReportByDepartedReport()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.SP_RoomTypeReportByDeparted().ToList();
            }
        }
    }
}