using Bookstore.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.Data
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Book>().HasOne(x => x.Category).WithMany(x => x.Books).HasForeignKey(x => x.CategoryID);
            // model.Entity<Category>().HasMany(x => x.Books).WithOne(x => x.Category).HasForeignKey(x => x.BookID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
