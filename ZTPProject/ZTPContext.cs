using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    public class ZTPContext : DbContext
    {
    public DbSet<StanGry> StanyGry { get; set; }
        

        public ZTPContext(DbContextOptions<ZTPContext> options) : base(options)
        {
            Database.EnsureCreated();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StanGry>();
            base.OnModelCreating(modelBuilder);
        }

    }
}

