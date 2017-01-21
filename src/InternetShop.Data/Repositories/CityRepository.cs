using InternetShop.Data.Infrastructure;
using InternetShop.Model;


namespace InternetShop.Data.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {

        public CityRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory , context) { }
    }
}