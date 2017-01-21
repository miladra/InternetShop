using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class FactorItemService : IFactorItemService
    {

        private readonly IFactorItemRepository factorItemRepository;
        private readonly IUnitOfWork unitOfWork;

        public FactorItemService(IFactorItemRepository FactorItemRepository, IUnitOfWork unitOfWork)
        {
            this.factorItemRepository = FactorItemRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(FactorItem entity, bool autoSave = true)
        {
            try
            {
                factorItemRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(FactorItem entity, bool autoSave = true)
        {
            try
            {
                factorItemRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(FactorItem entity, bool autoSave = true)
        {
            try
            {
                factorItemRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id, bool autoSave = true)
        {
            try
            {
                FactorItem entity = factorItemRepository.Find(id);
                factorItemRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.FactorItem Find(int id)
        {
            try
            {
                return factorItemRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<FactorItem> Where(System.Linq.Expressions.Expression<Func<FactorItem, bool>> predicate)
        {
            try
            {
                return factorItemRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<FactorItem> Select()
        {
            try
            {
                return factorItemRepository.Select().AsQueryable();
            }
            catch
            {
                return null;
            }
        }



        public void Save()
        {
            unitOfWork.Commit();
        }
        public int Count()
        {
            try
            {
                return factorItemRepository.Count();
            }
            catch
            {
                return -1;
            }
        }

        public IQueryable<T> Select<T>(Expression<Func<T, bool>> selector)
        {
            throw new NotImplementedException();
        }

        public int GetLastIdentity()
        {
            throw new NotImplementedException();
        }
    }
}