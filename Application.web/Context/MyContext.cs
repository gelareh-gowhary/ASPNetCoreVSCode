using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.web.Context
{
    public class MyContext(DbContextOptions<MyContext> options):DbContext(options)
    {
    // public MyContext(DbContextOptions<MyContext> options):base(options)
    // {
        
    // }
        // public DbSet<Category> Categories{get;set;}
        public DbSet<Category> Categories=>Set<Category>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .Property(x=>x.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}