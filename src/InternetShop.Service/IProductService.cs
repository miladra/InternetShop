using System;
using System.Linq;


namespace InternetShop.Service
{
    public interface IProductService
    {
        bool Add(InternetShop.Model.Product entity, bool autoSave = true);

        bool Update(InternetShop.Model.Product entity, bool autoSave = true);

        bool Update(InternetShop.Model.Product entity, string imagePath, bool autoSave = true);

        bool Delete(InternetShop.Model.Product entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.Product Find(int id);

        IQueryable<InternetShop.Model.Product> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Product, bool>> predicate);

        IQueryable<InternetShop.Model.Product> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
