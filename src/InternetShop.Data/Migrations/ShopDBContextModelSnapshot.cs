using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InternetShop.Data.Infrastructure;

namespace InternetShop.Data.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    partial class ShopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternetShop.Model.Agency", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Address")
                        .HasColumnName("Address");

                    b.Property<int?>("CityID")
                        .HasColumnName("CityID");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<int>("ProvinceID")
                        .HasColumnName("ProvinceID");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Agency");
                });

            modelBuilder.Entity("InternetShop.Model.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<int>("ProvinceID")
                        .HasColumnName("ProvinceID");

                    b.HasKey("ID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("InternetShop.Model.Factor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasMaxLength(200);

                    b.Property<DateTime>("BuyDate")
                        .HasColumnName("BuyDate");

                    b.Property<string>("CodePosti")
                        .HasColumnName("CodePosti")
                        .HasColumnType("char(10)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasMaxLength(400);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FlloweCode")
                        .HasColumnName("FlloweCode")
                        .HasMaxLength(50);

                    b.Property<bool>("IsFinish")
                        .HasColumnName("IsFinish");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnName("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<decimal?>("Price")
                        .HasColumnName("Price");

                    b.Property<int?>("UserID")
                        .HasColumnName("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Factors");
                });

            modelBuilder.Entity("InternetShop.Model.FactorItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("FactorID")
                        .HasColumnName("FactorID");

                    b.Property<bool?>("IsBuy")
                        .HasColumnName("IsBuy");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnName("OrderDate");

                    b.Property<int?>("ProductID")
                        .HasColumnName("ProductID");

                    b.Property<byte?>("Qty")
                        .HasColumnName("Qty");

                    b.HasKey("ID");

                    b.HasIndex("FactorID");

                    b.HasIndex("ProductID");

                    b.ToTable("FactorItems");
                });

            modelBuilder.Entity("InternetShop.Model.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentID")
                        .HasColumnName("ParentID");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("InternetShop.Model.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Body")
                        .HasColumnName("Body");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsRead")
                        .HasColumnName("IsRead");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasColumnName("Website")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("InternetShop.Model.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasMaxLength(500);

                    b.Property<int>("Dislike")
                        .HasColumnName("Dislike");

                    b.Property<bool>("Enabled")
                        .HasColumnName("Enabled");

                    b.Property<int?>("GroupID")
                        .HasColumnName("GroupID");

                    b.Property<string>("Image")
                        .HasColumnName("Image")
                        .HasMaxLength(100);

                    b.Property<string>("Keywords")
                        .HasColumnName("Keywords")
                        .HasMaxLength(300);

                    b.Property<int>("Like")
                        .HasColumnName("Like");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnName("Price");

                    b.Property<string>("Summery")
                        .IsRequired()
                        .HasColumnName("Summery");

                    b.Property<string>("Tags")
                        .HasColumnName("Tags")
                        .HasMaxLength(200);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("Url")
                        .HasMaxLength(1000);

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("InternetShop.Model.Province", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("InternetShop.Model.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("InternetShop.Model.RoleUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("InternetShop.Model.Setting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("AboutUs")
                        .HasColumnName("AboutUs");

                    b.Property<string>("ContactUs")
                        .HasColumnName("ContactUs");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasMaxLength(50);

                    b.Property<string>("EmailSenderName")
                        .HasColumnName("EmailSenderName")
                        .HasMaxLength(50);

                    b.Property<string>("Help")
                        .HasColumnName("Help");

                    b.Property<string>("Keywords")
                        .HasColumnName("Keywords")
                        .HasMaxLength(300);

                    b.Property<string>("Picture1")
                        .HasColumnName("Picture1")
                        .HasMaxLength(200);

                    b.Property<string>("Picture2")
                        .HasColumnName("Picture2")
                        .HasMaxLength(200);

                    b.Property<string>("Picture3")
                        .HasColumnName("Picture3")
                        .HasMaxLength(200);

                    b.Property<string>("Picture4")
                        .HasColumnName("Picture4")
                        .HasMaxLength(200);

                    b.Property<string>("Picture5")
                        .HasColumnName("Picture5")
                        .HasMaxLength(200);

                    b.Property<string>("PrivacyPolicy")
                        .HasColumnName("PrivacyPolicy");

                    b.Property<string>("SmtpServer")
                        .HasColumnName("SmtpServer")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("InternetShop.Model.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnName("BirthDate");

                    b.Property<bool?>("Gender")
                        .HasColumnName("Gender");

                    b.Property<string>("Mobile")
                        .HasColumnName("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnName("Password")
                        .HasMaxLength(50);

                    b.Property<byte?>("Status")
                        .HasColumnName("Status");

                    b.Property<string>("Tell")
                        .HasColumnName("Tell")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .HasColumnName("Username")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("InternetShop.Model.Agency", b =>
                {
                    b.HasOne("InternetShop.Model.City", "City")
                        .WithMany("Agencies")
                        .HasForeignKey("CityID");

                    b.HasOne("InternetShop.Model.Province", "Province")
                        .WithMany("Agencies")
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetShop.Model.City", b =>
                {
                    b.HasOne("InternetShop.Model.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetShop.Model.Factor", b =>
                {
                    b.HasOne("InternetShop.Model.User", "User")
                        .WithMany("Factors")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("InternetShop.Model.FactorItem", b =>
                {
                    b.HasOne("InternetShop.Model.Factor", "Factor")
                        .WithMany("FactorItems")
                        .HasForeignKey("FactorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetShop.Model.Product", "Product")
                        .WithMany("FactorItems")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("InternetShop.Model.Group", b =>
                {
                    b.HasOne("InternetShop.Model.Group", "Group2")
                        .WithMany("Group1")
                        .HasForeignKey("ParentID");
                });

            modelBuilder.Entity("InternetShop.Model.Product", b =>
                {
                    b.HasOne("InternetShop.Model.Group", "Group")
                        .WithMany("Products")
                        .HasForeignKey("GroupID");
                });

            modelBuilder.Entity("InternetShop.Model.RoleUser", b =>
                {
                    b.HasOne("InternetShop.Model.Role", "Role")
                        .WithMany("RoleUsers")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetShop.Model.User", "User")
                        .WithMany("RoleUsers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
