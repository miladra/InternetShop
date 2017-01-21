using InternetShop.Data.Infrastructure;
using InternetShop.Model;

namespace InternetShop.Data.Repositories
{
    public class FactorRepository : RepositoryBase<Factor>, IFactorRepository
    {
        public FactorRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory , context) { }
    }
}