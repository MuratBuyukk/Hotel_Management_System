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
    public class BookingStatusBusiness : IDatabaseBusiness<BookingStatu>
    {
        public void Add(BookingStatu entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.BookingStatus.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(BookingStatu entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.BookingStatus.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.BookingStatus.Find(id);
                db.BookingStatus.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BookingStatu Get(Expression<Func<BookingStatu, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.BookingStatus.Where(expression).FirstOrDefault();
            }
        }

        public List<BookingStatu> GetAll(Expression<Func<BookingStatu, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.BookingStatus.Where(expression).ToList();
            }
        }

        public List<BookingStatu> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.BookingStatus.ToList();
            }
        }

        public BookingStatu GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.BookingStatus.Find(id);
            }
        }

        public void Update(BookingStatu entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.BookingStatus.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
