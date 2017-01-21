using System;
using System.Linq;

namespace InternetShop.Service
{
    public interface IGroupService
    {
        bool Add(InternetShop.Model.Group entity, bool autoSave = true);

        bool Update(InternetShop.Model.Group entity, bool autoSave = true);

        bool Delete(InternetShop.Model.Group entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.Group Find(int id);

        IQueryable<InternetShop.Model.Group> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Group, bool>> predicate);

        IQueryable<InternetShop.Model.Group> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
