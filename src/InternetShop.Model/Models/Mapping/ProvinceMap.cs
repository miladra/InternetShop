
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class ProvinceMap 
    {
        public ProvinceMap(EntityTypeBuilder<Province> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            entityBuilder.ToTable("Province");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
