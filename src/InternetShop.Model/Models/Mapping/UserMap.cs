using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Name)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Username)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Password)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Mobile)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Tell)
                .HasMaxLength(50);


            // Table & Column Mappings
            entityBuilder.ToTable("User");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.Username).HasColumnName("Username");
            entityBuilder.Property(t => t.Password).HasColumnName("Password");
            entityBuilder.Property(t => t.BirthDate).HasColumnName("BirthDate");
            entityBuilder.Property(t => t.Mobile).HasColumnName("Mobile");
            entityBuilder.Property(t => t.Tell).HasColumnName("Tell");
            entityBuilder.Property(t => t.Gender).HasColumnName("Gender");
            entityBuilder.Property(t => t.Status).HasColumnName("Status");


            // Relationships
            //entityBuilder.HasOne(bc => bc.u)
            //             .WithMany(c => c.RoleUsers)
            //             .HasForeignKey(bc => bc.ID);
            //entityBuilder.HasOne(r => r.usercer)
            //    .WithMany(u => u.u)
            //    .Map(x =>
            //    {
            //        x.MapLeftKey("UserID");
            //        x.MapRightKey("RoleID");
            //        x.ToTable("RoleUser");
            //    });

        }
    }
}
