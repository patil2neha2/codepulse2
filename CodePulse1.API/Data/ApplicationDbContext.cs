using CodePulse1.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CodePulse1.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<BlogImage> BlogImages { get; set; }
    }
}

