using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class FactorService : IFactorService
    {

        private readonly IFactorRepository factorRepository;
        private readonly IUnitOfWork unitOfWork;

        public FactorService(IFactorRepository FactorRepository, IUnitOfWork unitOfWork)
        {
            this.factorRepository = FactorRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.Factor entity, bool autoSave = true)
        {
            try
            {
                factorRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.Factor entity, bool autoSave = true)
        {
            try
            {
                factorRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.Factor entity, bool autoSave = true)
        {
            try
            {
                factorRepository.Delete(entity);
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
                Factor entity = factorRepository.Find(id);
                factorRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.Factor Find(int id)
        {
            try
            {
                return factorRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Factor> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Factor, bool>> predicate)
        {
            try
            {
                return factorRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Factor> Select()
        {
            try
            {
                return factorRepository.Select().AsQueryable();
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
                return factorRepository.Count();
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