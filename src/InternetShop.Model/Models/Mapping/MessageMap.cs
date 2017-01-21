using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class MessageMap
    {
        public MessageMap(EntityTypeBuilder<Message> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Title)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Name)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Email)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Website)
                .HasMaxLength(50);

            // Table & Column Mappings
            entityBuilder.ToTable("Message");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.Title).HasColumnName("Title");
            entityBuilder.Property(t => t.Body).HasColumnName("Body");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.Email).HasColumnName("Email");
            entityBuilder.Property(t => t.Website).HasColumnName("Website");
            entityBuilder.Property(t => t.IsRead).HasColumnName("IsRead");
        }
    }
}
