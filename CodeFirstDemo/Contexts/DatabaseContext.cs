using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Contexts;

public class DatabaseContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductsCategories { get; set; }



    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => new { pc.ProductId, pc.CategoryId });

        modelBuilder.Entity<ShoppingCart>()
            .HasKey(sc => new { sc.AccountID, sc.ProductID });

        modelBuilder.Entity<Role>().HasData(new List<Role>()
        {
            new()
            {
                RoleId = 1,
                RoleName = "Pisarz"
            },
            new()
            {
                RoleId = 2,
                RoleName = "Malarz"
            },
            new()
            {
                RoleId = 3,
                RoleName = "Akrobata"
            }
        });
        modelBuilder.Entity<Account>().HasData(new List<Account>()
        {
            new()
            {
                AccountId = 1,
                RoleId = 1,
                AccountFirstName = "Janek",
                AccountLastName = "Janeczek",
                AccountEmail = "janek.janeczek@protonmail.com",
                AccountPhone = "111111111"
            },
            new()
            {
                AccountId = 2,
                RoleId = 2,
                AccountFirstName = "test",
                AccountLastName = "test",
                AccountEmail = "test.test@gmail.com",
                AccountPhone = "222222222"
            },
            new()
            {
                AccountId = 3,
                RoleId = 3,
                AccountFirstName = "wololo",
                AccountLastName = "wololo",
                AccountEmail = "wololo.wololo@gmail.com",
                AccountPhone = "333333333"
            }
        });
        modelBuilder.Entity<Product>().HasData(new List<Product>()
        {
            new()
            {
                PK = 2,
                Name = "test1",
                Width = 2.1m,
                Height = 1.1m,
                Depth = 1.3m
            },
            new()
            {
                PK = 3,
                Name = "test3",
                Width = 2.0m,
                Height = 1.9m,
                Depth = 1.8m
            },
            new()
            {
                PK = 4,
                Name = "test4",
                Width = 2.1m,
                Height = 7.1m,
                Depth = 1.6m
            },
            new()
            {
                PK = 1,
                Name = "test31",
                Width = 2.2m,
                Height = 1.3m,
                Depth = 1.4m
            }
        });
        modelBuilder.Entity<ShoppingCart>().HasData(new List<ShoppingCart>()
        {
            new()
            {
                AccountID = 1,
                ProductID = 1,
                ShoppingCartAmount = 13
            },
            new()
            {
                AccountID = 2,
                ProductID = 3,
                ShoppingCartAmount = 2
            },
            new()
            {
                AccountID = 3,
                ProductID = 2,
                ShoppingCartAmount = 5
            }
        });
        modelBuilder.Entity<Category>().HasData(new List<Category>()
        {
            new()
            {
                CategoryId = 1,
                CategoryName = "TestCat1"
            },
            new()
            {
                CategoryId = 2,
                CategoryName = "TestCat2"
            },
            new()
            {
                CategoryId = 3,
                CategoryName = "TestCat3"
            }
        });
        modelBuilder.Entity<ProductCategory>().HasData(new List<ProductCategory>()
        {
            new()
            {
                ProductId = 1,
                CategoryId = 1
            },
            new()
            {
                ProductId = 2,
                CategoryId = 2
            },
            new()
            {
                ProductId = 3,
                CategoryId = 3
            }
        });
    }
}