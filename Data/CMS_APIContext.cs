using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMS_API.Models;

namespace CMS_API.Data
{
    public class CMS_APIContext : DbContext
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

            // Seed Static Pages
            modelBuilder.Entity<StaticPage>().HasData(
                new StaticPage { Id = 1, Title = "Home", Content = "Welcome to our site!", CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0) },
                new StaticPage { Id = 2, Title = "About", Content = "About us page content.", CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0) }
            );

            // Seed Blog Posts
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost { Id = 1, Title = "First Blog Post", Content = "This is a sample blog post.", CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0) },
                new BlogPost { Id = 2, Title = "Second Blog Post", Content = "Another post for testing.", CreatedAt = new DateTime(2024, 02, 01, 12, 0, 0) }
            );

            // Seed Business Contacts
            modelBuilder.Entity<BusinessContact>().HasData(
                new BusinessContact { Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890" },
                new BusinessContact { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "987-654-3210" }
            );

            // Seed Feedback
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback { Id = 1, Name = "Alice", Email = "alice@example.com", Message = "Great website!", SubmittedAt = new DateTime(2024, 02, 01, 12, 0, 0) },
                new Feedback { Id = 2, Name = "Bob", Email = "bob@example.com", Message = "Needs improvement.", SubmittedAt = new DateTime(2024, 02, 01, 12, 0, 0) }
            );
        }
    }
}
