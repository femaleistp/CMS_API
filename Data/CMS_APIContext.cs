using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMS_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CMS_API.Areas.Identity.Data;

namespace CMS_API.Data
{
    public class CMS_APIContext : IdentityDbContext<BlogUser>
    {
        public CMS_APIContext(DbContextOptions<CMS_APIContext> options)
            : base(options)
        {
        }

        public DbSet<CMS_API.Models.StaticPage> StaticPage { get; set; } = default!;
        public DbSet<CMS_API.Models.BlogPost> BlogPost { get; set; } = default!;
        public DbSet<CMS_API.Models.BusinessContact> BusinessContact { get; set; } = default!;
        public DbSet<CMS_API.Models.Feedback> Feedback { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Use a fixed GUID instead of Guid.NewGuid()
            var defaultUserId = "550e8400-e29b-41d4-a716-446655440000";

            // Use a fixed ConcurrencyStamp & PasswordHash
            var fixedConcurrencyStamp = "8c53efe6-37c7-43d7-848b-923a54308539";
            var fixedPasswordHash = "AQAAAAIAAYagAAAAEKHThnbUeYENSY2U8OdspULiPBnFIvVj48qYTeaf3qUZjxHW50fhklpE3g6bEx0ncA==";


            // Seed Default Identity User
            var hasher = new PasswordHasher<BlogUser>();
            modelBuilder.Entity<BlogUser>().HasData(
                new BlogUser
                {
                    Id = defaultUserId,
                    UserName = "testuser",
                    NormalizedUserName = "TESTUSER",
                    Email = "testuser@example.com",
                    NormalizedEmail = "TESTUSER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = fixedPasswordHash, // Use a hardcoded hash
                    SecurityStamp = "550e8400-e29b-41d4-a716-446655440001",
                    ConcurrencyStamp = fixedConcurrencyStamp // Use a hardcoded value
                }
            );


            // Seed Static Pages
            modelBuilder.Entity<StaticPage>().HasData(
                new StaticPage 
                { 
                    Id = 1, 
                    Title = "Home", 
                    Content = "Welcome to our site!", 
                    CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0),
                    UserId = defaultUserId
                },
                new StaticPage 
                { 
                    Id = 2, 
                    Title = "About", 
                    Content = "About us page content.", 
                    CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0),
                    UserId = defaultUserId
                }
            );

            // Seed Blog Posts
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost 
                { 
                    Id = 1, 
                    Title = "First Blog Post", 
                    Content = "This is a sample blog post.", 
                    CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0), 
                    UserId = defaultUserId
                },
                new BlogPost 
                { Id = 2, 
                    Title = "Second Blog Post", 
                    Content = "Another post for testing.", 
                    CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0),
                    UserId = defaultUserId
                }
            );

            // Seed Business Contacts
            modelBuilder.Entity<BusinessContact>().HasData(
                new BusinessContact 
                { 
                    Id = 1, 
                    Name = "John Doe", 
                    Email = "john@example.com", 
                    Phone = "123-456-7890" },
                new BusinessContact 
                { 
                    Id = 2, 
                    Name = "Jane Smith", 
                    Email = "jane@example.com", 
                    Phone = "987-654-3210" }
            );

            // Seed Feedback
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback 
                { 
                    Id = 1, 
                    Name = "Alice", 
                    Email = "alice@example.com", 
                    Message = "Great website!", 
                    SubmittedAt = new DateTime(2024, 02, 01, 12, 0, 0),
                    UserId = defaultUserId
                },
                new Feedback 
                { 
                    Id = 2, 
                    Name = "Bob", 
                    Email = "bob@example.com", 
                    Message = "Needs improvement.", 
                    SubmittedAt = new DateTime(2024, 02, 01, 12, 0, 0),
                    UserId = defaultUserId
                }
            );
        }
    }
}
