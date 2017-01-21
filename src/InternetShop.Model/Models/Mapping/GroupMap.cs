using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class GroupMap
    {
        public GroupMap(EntityTypeBuilder<Group> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            entityBuilder.ToTable("Group");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.Name).HasColumnName("Name");
            entityBuilder.Property(t => t.ParentID).HasColumnName("ParentID");

            // Relationships
            entityBuilder.HasOne(t => t.Group2)
                .WithMany(t => t.Group1)
                .HasForeignKey(d => d.ParentID);

        }
    }
}
