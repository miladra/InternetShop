using System;
using System.Linq;

namespace InternetShop.Service
{
    public interface IProvinceService
    {
        bool Add(InternetShop.Model.Province entity, bool autoSave = true);

        bool Update(InternetShop.Model.Province entity, bool autoSave = true);

        bool Delete(InternetShop.Model.Province entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.Province Find(int id);

        IQueryable<InternetShop.Model.Province> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Province, bool>> predicate);

        IQueryable<InternetShop.Model.Province> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
