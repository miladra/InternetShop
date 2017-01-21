using InternetShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Data.Code
{
    public static class Extensions
    {
        public static void EnsureSeedData(this ShopDBContext context)
        {
            //if (context.AllMigrationsApplied())
            //{
            //    if (!context.Products.Any())
            //    {
            //        context.SaveChanges();
            //    }

            //    if (!context.WebsiteAds.Any())
            //    {

            //        context.SaveChanges();
            //    }
            //}
        }
    }
}