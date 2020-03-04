using System;
using MyProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyProject.Data.Context
{
    public partial class MyProjectDbContext : DbContext
    {
        public MyProjectDbContext()
        {
        }

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
