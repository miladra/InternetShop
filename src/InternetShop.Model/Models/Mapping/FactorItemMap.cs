using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class FactorItemMap
    {
        public FactorItemMap(EntityTypeBuilder<FactorItem> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            entityBuilder.ToTable("FactorItems");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.ProductID).HasColumnName("ProductID");
            entityBuilder.Property(t => t.Qty).HasColumnName("Qty");
            entityBuilder.Property(t => t.OrderDate).HasColumnName("OrderDate");
            entityBuilder.Property(t => t.IsBuy).HasColumnName("IsBuy");
            entityBuilder.Property(t => t.FactorID).HasColumnName("FactorID");

            // Relationships
            entityBuilder.HasOne(t => t.Factor)
                .WithMany(t => t.FactorItems)
                .HasForeignKey(d => d.FactorID);
            entityBuilder.HasOne(t => t.Product)
                .WithMany(t => t.FactorItems)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
