using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Model.Mapping
{
    public class RoleUserMap
    {
        public RoleUserMap(EntityTypeBuilder<RoleUser> entityBuilder)
        {
            entityBuilder.HasKey(bc => new { bc.RoleID, bc.UserID });

            entityBuilder.HasOne(bc => bc.Role)
                .WithMany(b => b.RoleUsers)
                .HasForeignKey(bc => bc.RoleID);

            entityBuilder.HasOne(bc => bc.User)
                .WithMany(c => c.RoleUsers)
                .HasForeignKey(bc => bc.UserID);
        }
    }
}
