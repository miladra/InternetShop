using InternetShop.Data.Infrastructure;
using InternetShop.Model;


namespace InternetShop.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory , context) { }
    }
}