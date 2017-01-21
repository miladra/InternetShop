using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using InternetShop.Service;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class GroupService : IGroupService
    {

        private readonly IGroupRepository groupRepository;
        private readonly IUnitOfWork unitOfWork;

        public GroupService(IGroupRepository groupRepository, IUnitOfWork unitOfWork)
        {
            this.groupRepository = groupRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.Group entity, bool autoSave = true)
        {
            try
            {
                groupRepository.Add(entity);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.Group entity, bool autoSave = true)
        {
            try
            {
                groupRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.Group entity, bool autoSave = true)
        {
            try
            {
                groupRepository.Delete(entity);
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
                Group entity = groupRepository.Find(id);
                groupRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.Group Find(int id)
        {
            try
            {
                return groupRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Group> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.Group, bool>> predicate)
        {
            try
            {
                return groupRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.Group> Select()
        {
            try
            {
                return groupRepository.Select().AsQueryable();
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
                return groupRepository.Count();
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