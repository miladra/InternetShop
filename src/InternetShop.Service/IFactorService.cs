using System;
using System.Linq;

namespace InternetShop.Service
{
    public interface IFactorService
    {
        bool Add(InternetShop.Model.Factor entity, bool autoSave = true);

        bool Update(InternetShop.Model.Factor entity, bool autoSave = true);

        bool Delete(InternetShop.Model.Factor entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.Factor Find(int id);

        IQueryable<InternetShop.Model.Factor> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Factor, bool>> predicate);

        IQueryable<InternetShop.Model.Factor> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
