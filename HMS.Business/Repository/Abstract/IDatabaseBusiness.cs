using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Repository.Abstract
{
    public interface IDatabaseBusiness<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> expression);
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> expression);
    }
}
