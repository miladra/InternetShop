using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class FactorMap
    {
        public FactorMap(EntityTypeBuilder<Factor> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.FlloweCode)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Description)
                .HasMaxLength(400);

            entityBuilder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(200);

            entityBuilder.Property(t => t.CodePosti)
                // .IsFixedLength()
                .HasColumnType("char(10)");
               // .HasMaxLength(10);

            // Table & Column Mappings
            entityBuilder.ToTable("Factors");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.BuyDate).HasColumnName("BuyDate");
            entityBuilder.Property(t => t.FlloweCode).HasColumnName("FlloweCode");
            entityBuilder.Property(t => t.Description).HasColumnName("Description");
            entityBuilder.Property(t => t.Price).HasColumnName("Price");
            entityBuilder.Property(t => t.UserID).HasColumnName("UserID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.Mobile).HasColumnName("Mobile");
            entityBuilder.Property(t => t.Email).HasColumnName("Email");
            entityBuilder.Property(t => t.Address).HasColumnName("Address");
            entityBuilder.Property(t => t.CodePosti).HasColumnName("CodePosti");
            entityBuilder.Property(t => t.IsFinish).HasColumnName("IsFinish");

            // Relationships
            entityBuilder.HasOne(t => t.User)
                .WithMany(t => t.Factors)
                .HasForeignKey(d => d.UserID);

        }
    }
}
