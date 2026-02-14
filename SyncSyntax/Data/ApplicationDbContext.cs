using Microsoft.EntityFrameworkCore;
using SyncSyntax.Models;

namespace SyncSyntax.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed initial data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Technology"},
                new Category { Id = 2, CategoryName = "Health" },
                new Category { Id = 3, CategoryName = "LifeStyle"}
            );
            // Seed initial data for Posts
            modelBuilder.Entity<Post>().HasData(
               new Post
               {
                   Id = 1,
                   Title = "Introduction to .NET",
                   Content = "This is a beginner guide to .NET development.",
                   Author = "Hamid Idrees",
                   FeaturedImageUrl = "https://example.com/images/dotnet.png",
                   PublishedDate = new DateTime(2025, 1, 1),
                   CategoryId = 1
               },
               new Post
               {
                   Id = 2,
                   Title = "Healthy Living Tips",
                   Content = "Simple habits for a healthier lifestyle.",
                   Author = "Fahad Ali",
                   FeaturedImageUrl = "https://example.com/images/health.png",
                   PublishedDate = new DateTime(2025, 1, 5),
                   CategoryId = 2
               },
               new Post
               {
                   Id = 3,
                   Title = "Work-Life Balance",
                   Content = "How to maintain productivity without burnout.",
                   Author = "Alex Carry",
                   FeaturedImageUrl = "https://example.com/images/lifestyle.png",
                   PublishedDate = new DateTime(2025, 1, 10),
                   CategoryId = 3
               }
            );
        }

    }
}
