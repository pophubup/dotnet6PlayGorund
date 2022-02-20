using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zNpgsqlClient
{
    public  class _Test3Context: DbContext
    {
        public virtual DbSet<Product> Product => Set<Product>();
        public virtual DbSet<Category> Category => Set<Category>();
        public virtual DbSet<Event> Event => Set<Event>();
        public virtual DbSet<Stock> Stock => Set<Stock>();
        public  DbSet<Type> Type => Set<Type>();
        public _Test3Context(DbContextOptions<_Test3Context> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(g=>g.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().Property(g => g.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Event>().Property(g => g.Id).ValueGeneratedOnAdd(); 
            modelBuilder.Entity<Stock>().Property(g => g.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Type>().Property(g => g.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>().HasOne(g => g.Category)
                .WithMany(g=>g.Product)
                .HasForeignKey(x=>x.CategoryForeignKey);

            modelBuilder.Entity<Product>().HasMany(g => g.Stock);
            modelBuilder.Entity<Product>().HasMany(g => g.Event);

      
            modelBuilder.Entity<Event>().HasOne(g => g.Type);

            base.OnModelCreating(modelBuilder);
        }
      
    }
}
