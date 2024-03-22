using HMS.Business.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Entities;
using System.Data.Entity;
using HMS.Entities.ViewModels;

namespace HMS.Business.Repository.Concrete
{
    public class UserBusiness : IDatabaseBusiness<User>
    {
        public void Add(User entity)
        {
            using (var db=new HotelManagementSystemEntities())
            {
                db.Users.Add(entity);
                db.SaveChanges();
            }
        }
        
        public void Delete(User entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Users.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var entity = db.Users.Find(id);
                db.Users.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public User Get(System.Linq.Expressions.Expression<Func<User, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Users.Where(expression).FirstOrDefault();
            }
        }

        public List<User> GetAll(System.Linq.Expressions.Expression<Func<User, bool>> expression)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Users.Where(expression).ToList();
            }
        }

        public List<User> GetAll()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Users.ToList();
            }
        }

        public User GetById(int id)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Users.Find(id);
            }
        }

        public void Update(User entity)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                db.Users.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public String ActiveUserName()
        {
            var items = GetAll();

            foreach (var item in items)
            {
                if (item.UserStatus)
                {
                    return item.UserName;
                }
            }
            return null;
        }
        public int ActiveUserID()
        {
            var items = GetAll();
            foreach (var item in items)
            {
                if (item.UserStatus)
                {
                    return item.UserId;
                }
            }
            return 0;
        }
        public void DeactivetUserStatus()
        {
            var items = GetAll();

            foreach (var item in items)
            {
                Update(new User
                {
                    UserId = item.UserId,
                    UserName = item.UserName,
                    Password = item.Password,
                    Email = item.Email,
                    UserStatus = false,
                    IsAdmin = item.IsAdmin
                });
            }
        }
        public List<UserViewModel> GetUsers()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var users = new List<UserViewModel>();
                foreach (var u in GetAll())
                {
                    users.Add(new UserViewModel
                    {
                        UserId = u.UserId,
                        UserName = u.UserName,
                        Email = u.Email,
                        Password= u.Password,
                        UserStatus= u.UserStatus,
                        IsAdmin = u.IsAdmin
                    });
                }
                return users;
            }
        }
    }
}

