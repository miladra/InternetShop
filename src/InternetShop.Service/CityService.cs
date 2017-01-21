using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class CityService : ICityService
    {

        private readonly ICityRepository cityRepository;
        private readonly IUnitOfWork unitOfWork;

        public CityService(ICityRepository cityRepository, IUnitOfWork unitOfWork)
        {
            this.cityRepository = cityRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.City entity, bool autoSave = true)
        {
            try
            {
                cityRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.City entity, bool autoSave = true)
        {
            try
            {
                cityRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.City entity, bool autoSave = true)
        {
            try
            {
                cityRepository.Delete(entity);
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
                City entity = cityRepository.Find(id);
                cityRepository.Delete(entity);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.City Find(int id)
        {
            try
            {
                return cityRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.City> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.City, bool>> predicate)
        {
            try
            {
                return cityRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.City> Select()
        {
            try
            {
                return cityRepository.Select().AsQueryable();
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
                return cityRepository.Count();
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