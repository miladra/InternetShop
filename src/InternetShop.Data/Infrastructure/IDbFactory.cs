using System;

namespace InternetShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopDBContext Init();
    }
}
