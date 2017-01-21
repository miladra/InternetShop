
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class CityMap 
    {
        public CityMap(EntityTypeBuilder<City> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            entityBuilder.ToTable("City");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.ProvinceID).HasColumnName("ProvinceID");

            // Relationships
            entityBuilder.HasOne(t => t.Province)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => d.ProvinceID);

        }
    }
}
