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
    public class RoomTypeBusiness : IDatabaseBusiness<RoomType>
    {
        public void Add(RoomType entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.RoomTypes.Add(entity);
            }
        }

        public void Delete(RoomType entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.RoomTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.RoomTypes.Find(id);
                db.RoomTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public RoomType Get(Expression<Func<RoomType, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<RoomType> GetAll(Expression<Func<RoomType, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomTypes.Where(expression).ToList();
            }
        }

        public List<RoomType> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomTypes.ToList();
            }
        }

        public RoomType GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.RoomTypes.Find(id);
            }
        }

        public void Update(RoomType entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.RoomTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
