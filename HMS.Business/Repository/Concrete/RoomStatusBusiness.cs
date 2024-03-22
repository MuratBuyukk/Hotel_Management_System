using HMS.Business.Repository.Abstract;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Repository.Concrete
{
    public class RoomStatusBusiness : IDatabaseBusiness<RoomStatu>
    {
        public void Add(RoomStatu entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.RoomStatus.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(RoomStatu entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.RoomStatus.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.RoomStatus.Find(id);
                db.RoomStatus.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public RoomStatu Get(Expression<Func<RoomStatu, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomStatus.Where(expression).FirstOrDefault();
            }
        }

        public List<RoomStatu> GetAll(Expression<Func<RoomStatu, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomStatus.Where(expression).ToList();
            }
        }

        public List<RoomStatu> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomStatus.ToList();
            }
        }

        public RoomStatu GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomStatus.Find(id);
            }
        }

        public void Update(RoomStatu entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.RoomStatus.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
