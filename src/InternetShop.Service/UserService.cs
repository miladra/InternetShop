using InternetShop.Data.Infrastructure;
using InternetShop.Data.Repositories;
using InternetShop.Model;
using InternetShop.Service;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternetShop.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool Add(InternetShop.Model.User entity, bool autoSave = true)
        {
            try
            {
                userRepository.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(InternetShop.Model.User entity, bool autoSave = true)
        {
            try
            {
                userRepository.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(InternetShop.Model.User entity, bool autoSave = true)
        {
            try
            {
                userRepository.Delete(entity);
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
                User entity = userRepository.Find(id);
                userRepository.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public InternetShop.Model.User Find(int id)
        {
            try
            {
                return userRepository.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.User> Where(System.Linq.Expressions.Expression<Func<InternetShop.Model.User, bool>> predicate)
        {
            try
            {
                return userRepository.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<InternetShop.Model.User> Select()
        {
            try
            {
                return userRepository.Select().AsQueryable();
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
                return userRepository.Count();
            }
            catch
            {
                return -1;
            }
        }

        public bool Exist(string username, string password)
        {
            try
            {
                return userRepository.Where(p => p.Username == username && p.Password == password).Any();
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