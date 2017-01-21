using InternetShop.Model;
using System;
using System.Linq;

namespace InternetShop.Service
{
    public interface IFactorItemService
    {
        bool Add(FactorItem entity, bool autoSave = true);

        bool Update(FactorItem entity, bool autoSave = true);

        bool Delete(FactorItem entity, bool autoSave = true);

        bool Delete(int id, bool autoSave = true);

        FactorItem Find(int id);

        IQueryable<FactorItem> Where(System.Linq.Expressions.Expression<Func<FactorItem, bool>> predicate);

        IQueryable<FactorItem> Select();

        IQueryable<T> Select<T>(System.Linq.Expressions.Expression<Func<T, bool>> selector);

        int GetLastIdentity();

        void Save();
        int Count();
    }
}
