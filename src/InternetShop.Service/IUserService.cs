using System;
using System.Linq;


namespace InternetShop.Service
{
    public interface IUserService
    {
        bool Add(InternetShop.Model.User entity, bool autoSave = true);

        bool Update(InternetShop.Model.User entity, bool autoSave = true);

        bool Delete(InternetShop.Model.User entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        InternetShop.Model.User Find(int id);

        IQueryable<InternetShop.Model.User> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.User, bool>> predicate);

        IQueryable<InternetShop.Model.User> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        bool Exist(string username, string password);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
