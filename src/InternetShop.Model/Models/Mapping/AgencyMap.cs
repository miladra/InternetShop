
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class AgencyMap
    {
        public AgencyMap(EntityTypeBuilder<Agency> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            entityBuilder.ToTable("Agency");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.CityID).HasColumnName("CityID");
            entityBuilder.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.Address).HasColumnName("Address");

            // Relationships

            entityBuilder.HasOne(t => t.City)
                .WithMany(t => t.Agencies)
                .HasForeignKey(d => d.CityID);

            entityBuilder.HasOne(t => t.Province)
                .WithMany(t => t.Agencies)
                .HasForeignKey(d => d.ProvinceID);

            //entityBuilder.HasOptional(t => t.City)
            //    .WithMany(t => t.Agencies)
            //    .HasForeignKey(d => d.CityID);

            //entityBuilder.HasRequired(t => t.Province)
            //    .WithMany(t => t.Agencies)
            //    .HasForeignKey(d => d.ProvinceID);


        }
    }
}
