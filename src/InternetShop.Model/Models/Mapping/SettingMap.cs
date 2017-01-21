
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetShop.Model.Mapping
{
    public class SettingMap
    {
        public SettingMap(EntityTypeBuilder<Setting> entityBuilder)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.ID);

            // Properties
            entityBuilder.Property(t => t.Title)
                .HasMaxLength(100);

            entityBuilder.Property(t => t.Keywords)
                .HasMaxLength(300);

            entityBuilder.Property(t => t.Description)
                .HasMaxLength(500);

            entityBuilder.Property(t => t.SmtpServer)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Email)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.EmailSenderName)
                .HasMaxLength(50);

            entityBuilder.Property(t => t.Picture1)
                .HasMaxLength(200);

            entityBuilder.Property(t => t.Picture2)
                .HasMaxLength(200);

            entityBuilder.Property(t => t.Picture3)
                .HasMaxLength(200);

            entityBuilder.Property(t => t.Picture4)
                .HasMaxLength(200);

            entityBuilder.Property(t => t.Picture5)
                .HasMaxLength(200);

            // Table & Column Mappings
            entityBuilder.ToTable("Setting");
            entityBuilder.Property(t => t.ID).HasColumnName("ID");
            entityBuilder.Property(t => t.ContactUs).HasColumnName("ContactUs");
            entityBuilder.Property(t => t.AboutUs).HasColumnName("AboutUs");
            entityBuilder.Property(t => t.Help).HasColumnName("Help");
            entityBuilder.Property(t => t.PrivacyPolicy).HasColumnName("PrivacyPolicy");
            entityBuilder.Property(t => t.Title).HasColumnName("Title");
            entityBuilder.Property(t => t.Keywords).HasColumnName("Keywords");
            entityBuilder.Property(t => t.Description).HasColumnName("Description");
            entityBuilder.Property(t => t.SmtpServer).HasColumnName("SmtpServer");
            entityBuilder.Property(t => t.Email).HasColumnName("Email");
            entityBuilder.Property(t => t.EmailSenderName).HasColumnName("EmailSenderName");
            entityBuilder.Property(t => t.Picture1).HasColumnName("Picture1");
            entityBuilder.Property(t => t.Picture2).HasColumnName("Picture2");
            entityBuilder.Property(t => t.Picture3).HasColumnName("Picture3");
            entityBuilder.Property(t => t.Picture4).HasColumnName("Picture4");
            entityBuilder.Property(t => t.Picture5).HasColumnName("Picture5");
        }
    }
}
