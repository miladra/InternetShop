using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class ProvinceService : IProvinceService
    {

        private readonly IProvinceRepository povinceRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProvinceService(IProvinceRepository povinceRepository, IUnitOfWork unitOfWork)
        {
            this.povinceRepository = povinceRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.Province entity, bool autoSave = true)
        {
            try
            {
                povinceRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.Province entity, bool autoSave = true)
        {
            try
            {
                povinceRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.Province entity, bool autoSave = true)
        {
            try
            {
                povinceRepository.Delete(entity);
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
                Province entity = povinceRepository.Find(id);
                povinceRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.Province Find(int id)
        {
            try
            {
                return povinceRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Province> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Province, bool>> predicate)
        {
            try
            {
                return povinceRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Province> Select()
        {
            try
            {
                return povinceRepository.Select().AsQueryable();
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
                return povinceRepository.Count();
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