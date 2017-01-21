using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.Product entity, bool autoSave = true)
        {
            try
            {
                productRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.Product entity, bool autoSave = true)
        {
            try
            {
                productRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.Product entity, bool autoSave = true)
        {
            try
            {
                productRepository.Delete(entity);
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
                Product entity = productRepository.Find(id);
                productRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.Product Find(int id)
        {
            try
            {
                return productRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Product> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Product, bool>> predicate)
        {
            try
            {
                return productRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Product> Select()
        {
            try
            {
                return productRepository.Select().AsQueryable();
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
                return productRepository.Count();
            }
            catch
            {
                return -1;
            }
        }

        public bool Update(InternetShop.Model.Product entity, string imagePath, bool autoSave = true)
        {
            try
            {
                if (imagePath != null)
                {
                    entity.Image = imagePath;
                }
                productRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
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