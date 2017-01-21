using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class RoleService : IRoleService
    {

        private readonly IRoleRepository RoleRepository;
        private readonly IUnitOfWork unitOfWork;

        public RoleService(IRoleRepository RoleRepository, IUnitOfWork unitOfWork)
        {
            this.RoleRepository = RoleRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.Role entity, bool autoSave = true)
        {
            try
            {
                RoleRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.Role entity, bool autoSave = true)
        {
            try
            {
                RoleRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.Role entity, bool autoSave = true)
        {
            try
            {
                RoleRepository.Delete(entity);
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
                Role entity = RoleRepository.Find(id);
                RoleRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.Role Find(int id)
        {
            try
            {
                return RoleRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public InternetShop.Model.Role Find(string name)
        {
            try
            {
                return RoleRepository.Where(t => t.Name == name).SingleOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Role> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Role, bool>> predicate)
        {
            try
            {
                return RoleRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Role> Select()
        {
            try
            {
                return RoleRepository.Select().AsQueryable();
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
                return RoleRepository.Count();
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