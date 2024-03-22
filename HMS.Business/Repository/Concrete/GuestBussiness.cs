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
    public class GuestBussiness : IDatabaseBusiness<Guest>
    {
        public void Add(Guest entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Guests.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Guest entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Guests.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.Guests.Find(id);
                db.Guests.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Guest Get(Expression<Func<Guest, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Guests.Where(expression).FirstOrDefault();
            }
        }

        public List<Guest> GetAll(Expression<Func<Guest, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Guests.Where(expression).ToList();
            }
        }

        public List<Guest> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Guests.ToList();
            }
        }

        public Guest GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Guests.Find(id);
            }
        }

        public void Update(Guest entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Guests.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public int LastGuestId()
        {
            var items = GetAll();
            return items.Max(x => x.GuestId);
        }
    }
}
