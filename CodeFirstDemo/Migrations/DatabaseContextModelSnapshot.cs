﻿// <auto-generated />
using CodeFirstDemo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstDemo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstDemo.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_account");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountEmail")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("email");

                    b.Property<string>("AccountFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("AccountLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("AccountPhone")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("phone");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("FK_role");

                    b.HasKey("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            AccountEmail = "janek.janeczek@protonmail.com",
                            AccountFirstName = "Janek",
                            AccountLastName = "Janeczek",
                            AccountPhone = "111111111",
                            RoleId = 1
                        },
                        new
                        {
                            AccountId = 2,
                            AccountEmail = "test.test@gmail.com",
                            AccountFirstName = "test",
                            AccountLastName = "test",
                            AccountPhone = "222222222",
                            RoleId = 2
                        },
                        new
                        {
                            AccountId = 3,
                            AccountEmail = "wololo.wololo@gmail.com",
                            AccountFirstName = "wololo",
                            AccountLastName = "wololo",
                            AccountPhone = "333333333",
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_category");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "TestCat1"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "TestCat2"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "TestCat3"
                        });
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Product", b =>
                {
                    b.Property<int>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_product");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK"));

                    b.Property<decimal>("Depth")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("depth");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("height");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("weight");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("width");

                    b.HasKey("PK");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            PK = 2,
                            Depth = 1.3m,
                            Height = 1.1m,
                            Name = "test1",
                            Weight = 0m,
                            Width = 2.1m
                        },
                        new
                        {
                            PK = 3,
                            Depth = 1.8m,
                            Height = 1.9m,
                            Name = "test3",
                            Weight = 0m,
                            Width = 2.0m
                        },
                        new
                        {
                            PK = 4,
                            Depth = 1.6m,
                            Height = 7.1m,
                            Name = "test4",
                            Weight = 0m,
                            Width = 2.1m
                        },
                        new
                        {
                            PK = 1,
                            Depth = 1.4m,
                            Height = 1.3m,
                            Name = "test31",
                            Weight = 0m,
                            Width = 2.2m
                        });
                });

            modelBuilder.Entity("CodeFirstDemo.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("FK_product");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("FK_category");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products_Categories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_role");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Pisarz"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Malarz"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Akrobata"
                        });
                });

            modelBuilder.Entity("CodeFirstDemo.Models.ShoppingCart", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("int")
                        .HasColumnName("FK_account");

                    b.Property<int>("ProductID")
                        .HasColumnType("int")
                        .HasColumnName("FK_product");

                    b.Property<int>("ShoppingCartAmount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.HasKey("AccountID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("Shopping_Carts");

                    b.HasData(
                        new
                        {
                            AccountID = 1,
                            ProductID = 1,
                            ShoppingCartAmount = 13
                        },
                        new
                        {
                            AccountID = 2,
                            ProductID = 3,
                            ShoppingCartAmount = 2
                        },
                        new
                        {
                            AccountID = 3,
                            ProductID = 2,
                            ShoppingCartAmount = 5
                        });
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Account", b =>
                {
                    b.HasOne("CodeFirstDemo.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CodeFirstDemo.Models.ProductCategory", b =>
                {
                    b.HasOne("CodeFirstDemo.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstDemo.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CodeFirstDemo.Models.ShoppingCart", b =>
                {
                    b.HasOne("CodeFirstDemo.Models.Account", "Account")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstDemo.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Account", b =>
                {
                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("CodeFirstDemo.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}