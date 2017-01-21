using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class AgencyService : IAgencyService
    {

        private readonly IAgencyRepository agencyRepository;
        private readonly IUnitOfWork unitOfWork;

        public AgencyService(IAgencyRepository agencyRepository, IUnitOfWork unitOfWork)
        {
            this.agencyRepository = agencyRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.Agency entity, bool autoSave = true)
        {
            try
            {
                agencyRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.Agency entity, bool autoSave = true)
        {
            try
            {
                agencyRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.Agency entity, bool autoSave = true)
        {
            try
            {
                agencyRepository.Delete(entity);
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
                Agency entity = agencyRepository.Find(id);
                agencyRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.Agency Find(int id)
        {
            try
            {
                return agencyRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Agency> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Agency, bool>> predicate)
        {
            try
            {
                return agencyRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Agency> Select()
        {
            try
            {
                return agencyRepository.Select().AsQueryable();
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
                return agencyRepository.Count();
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