using System;
using System.Linq;


namespace InternetShop.Service
{
    public interface ICityService
    {
        bool Add(InternetShop.Model.City entity, bool autoSave = true);

        bool Update(InternetShop.Model.City entity, bool autoSave = true);

        bool Delete(InternetShop.Model.City entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.City Find(int id);

        IQueryable<InternetShop.Model.City> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.City, bool>> predicate);

        IQueryable<InternetShop.Model.City> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
