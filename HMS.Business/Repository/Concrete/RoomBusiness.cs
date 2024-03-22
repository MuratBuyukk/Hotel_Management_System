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
    public class RoomBusiness : IDatabaseBusiness<Room>
    {
        public void Add(Room entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Rooms.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Room entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Rooms.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.Rooms.Find(id);
                db.Rooms.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Room Get(Expression<Func<Room, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Rooms.Where(expression).FirstOrDefault();
            }
        }

        public List<Room> GetAll(Expression<Func<Room, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Rooms.Where(expression).ToList();
            }
        }

        public List<Room> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Rooms.ToList();
            }
        }

        public Room GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Rooms.Find(id);
            }
        }

        public void Update(Room entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Rooms.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<RoomViewModel> GetRooms()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from r in db.Rooms
                                  join t in db.RoomTypes on r.RoomTypeId equals t.RoomTypeId
                                  join s in db.RoomStatus on r.RoomStatusId equals s.RoomStatusId
                                  select new
                                  {
                                      r,
                                      t.RoomTypeName,
                                      s.RoomStatusName
                                  };
                var rooms = new List<RoomViewModel>();
                foreach (var r in queryResult)
                {
                    rooms.Add(new RoomViewModel
                    {
                        RoomId = r.r.RoomId,
                        RoomStatusId = r.r.RoomStatusId,
                        RoomTypeId = r.r.RoomTypeId,
                        Floor = r.r.Floor,
                        RoomNo = r.r.RoomNo,
                        RoomTypeName = r.RoomTypeName,
                        RoomStatusName = r.RoomStatusName
                    });
                }
                return rooms;
            }
        }

        public List<Room> getAvailableRoom()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from r in db.Rooms
                                  where r.RoomStatusId == 1
                                  select new
                                  {
                                      r,
                                  };
                var rooms = new List<Room>();
                foreach (var r in queryResult)
                {
                    rooms.Add(new Room
                    {
                        RoomId = r.r.RoomId,
                        RoomStatusId = r.r.RoomStatusId,
                        RoomTypeId = r.r.RoomTypeId,
                        Floor = r.r.Floor,
                        RoomNo = r.r.RoomNo,
                    });
                }
                return rooms;
            }
        }

        public void ChangeRoomStatus(int roomId,int status)
        {
            var items = GetAll();
            foreach (var item in items)
            {
                if (item.RoomId == roomId)
                {
                    Update(new Room
                    {
                        RoomId = item.RoomId,
                        RoomStatusId = status,
                        RoomTypeId = item.RoomTypeId,
                        Floor = item.Floor,
                        RoomNo = item.RoomNo,
                    });
                }
            }
        }
        public int NumberOfRooms(int status)
        {
            int result = 0;
            using (var db = new HotelManagementSystemEntities())
            {
                var queryResult = from r in db.Rooms
                                  where r.RoomStatusId == status
                                  select new
                                  {
                                      r,
                                  };
                foreach(var r in queryResult)
                {
                    result++;
                }
            }
            return result;
        }
        public List<SP_RoomTypesTotal_Result> GetRoomTypesTotal()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.SP_RoomTypesTotal().ToList();
            }
        }
    }
}

