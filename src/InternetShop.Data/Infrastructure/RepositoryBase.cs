using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace InternetShop.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private ShopDBContext dataContext;
        private readonly DbSet<T> dbSet;
        #endregion

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        //protected ShopDBContext DbContext
        //{
        //    get
        //    {
        //        return dataContext ?? (dataContext = DbFactory.Init());
        //    }
        //}

        protected RepositoryBase(IDbFactory dbFactory, ShopDBContext context)
        {
            DbFactory = dbFactory;
            dbSet = context.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T Find(int id)
        {
            return dbSet.Find(id);
        }
        public virtual IQueryable<T> GetAll()
        {
            return dbSet.AsQueryable();
        }
        public virtual IQueryable<T> Select()
        {
            return dbSet.AsQueryable();
        }
        public virtual IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).AsQueryable();
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }
        public int Count()
        {
            try
            {
                return dbSet.Count();
            }
            catch(Exception ex)
            {
                return -1;
            }
        }
        #endregion

    }
}
