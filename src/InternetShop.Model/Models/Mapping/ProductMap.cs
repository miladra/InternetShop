
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(1000);

            entityBuilder.Property(t => t.Keywords)
                .HasMaxLength(300);

            entityBuilder.Property(t => t.Description)
                .HasMaxLength(500);

            entityBuilder.Property(t => t.Tags)
                .HasMaxLength(200);

            entityBuilder.Property(t => t.Image)
                .HasMaxLength(100);

            entityBuilder.Property(t => t.Summery)
                .IsRequired();

            // Table & Column Mappings
            entityBuilder.ToTable("Product");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.GroupID).HasColumnName("GroupID");
            entityBuilder.Property(t => t.Price).HasColumnName("Price");
            entityBuilder.Property(t => t.Url).HasColumnName("Url");
            entityBuilder.Property(t => t.Keywords).HasColumnName("Keywords");
            entityBuilder.Property(t => t.Description).HasColumnName("Description");
            entityBuilder.Property(t => t.Tags).HasColumnName("Tags");
            entityBuilder.Property(t => t.Like).HasColumnName("Like");
            entityBuilder.Property(t => t.Dislike).HasColumnName("Dislike");
            entityBuilder.Property(t => t.Enabled).HasColumnName("Enabled");
            entityBuilder.Property(t => t.Image).HasColumnName("Image");
            entityBuilder.Property(t => t.Summery).HasColumnName("Summery");

            // Relationships
            entityBuilder.HasOne(t => t.Group)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.GroupID);

        }
    }
}
