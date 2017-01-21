using System;
using System.Linq;

namespace InternetShop.Service
{
    public interface IAgencyService
    {
        bool Add(InternetShop.Model.Agency entity, bool autoSave = true);

        bool Update(InternetShop.Model.Agency entity, bool autoSave = true);

        bool Delete(InternetShop.Model.Agency entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.Agency Find(int id);

        IQueryable<InternetShop.Model.Agency> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Agency, bool>> predicate);

        IQueryable<InternetShop.Model.Agency> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
