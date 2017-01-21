using System;
using System.Linq;

namespace InternetShop.Service
{
    public interface IRoleService
    {
        bool Add(InternetShop.Model.Role entity, bool autoSave = true);

        bool Update(InternetShop.Model.Role entity, bool autoSave = true);

        bool Delete(InternetShop.Model.Role entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.Role Find(int id);
        InternetShop.Model.Role Find(string name);

        IQueryable<InternetShop.Model.Role> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Role, bool>> predicate);

        IQueryable<InternetShop.Model.Role> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
