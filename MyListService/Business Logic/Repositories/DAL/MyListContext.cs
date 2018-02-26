using Microsoft.EntityFrameworkCore;
using MyListService.Business_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyListService.Business_Logic.Repositories.DAL
{
    public class MyListContext : DbContext
    {
        public MyListContext(DbContextOptions<MyListContext> options)
            : base(options)
        { }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MyList");

            modelBuilder.Entity<Car>(x =>
            {
                x.Property(z => z.Id).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
