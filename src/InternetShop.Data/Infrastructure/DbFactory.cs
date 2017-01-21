namespace InternetShop.Data.Infrastructure
{
    public class DbFactory : Disposable , IDbFactory
    {
        ShopDBContext dbContext;
        public ShopDBContext Init()
        {
            return dbContext ?? (dbContext = new ShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
