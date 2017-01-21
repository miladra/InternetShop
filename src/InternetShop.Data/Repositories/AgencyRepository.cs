using InternetShop.Data.Infrastructure;
using InternetShop.Model;


namespace InternetShop.Data.Repositories
{
    public class AgencyRepository : RepositoryBase<Agency>, IAgencyRepository
    {

        public AgencyRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory, context) { }
    }
}