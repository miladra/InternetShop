using InternetShop.Data.Infrastructure;
using InternetShop.Model;


namespace InternetShop.Data.Repositories
{
    public class FactorItemRepository : RepositoryBase<FactorItem>, IFactorItemRepository
    {
        public FactorItemRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory , context) { }
    }
}