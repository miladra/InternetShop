
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T Find(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Select();
        IQueryable<T> Where(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where);
        int Count();
    }
}
