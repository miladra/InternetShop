using InternetShop.Data.Infrastructure;
using InternetShop.Model;


namespace InternetShop.Data.Repositories
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory , context) { }
    }
}