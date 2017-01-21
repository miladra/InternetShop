using InternetShop.Data.Infrastructure;
using InternetShop.Model;


namespace InternetShop.Data.Repositories
{
    public class ProvinceRepository : RepositoryBase<Province>, IProvinceRepository
    {
        public ProvinceRepository(IDbFactory dbFactory, ShopDBContext context)
            : base(dbFactory , context) { } 
     }
}