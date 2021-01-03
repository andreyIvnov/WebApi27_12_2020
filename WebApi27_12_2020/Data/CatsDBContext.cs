using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi27_12_2020.Model;

namespace WebApi27_12_2020.Data
{
    public class CatsDBContext : DbContext
    {
        public CatsDBContext(DbContextOptions<CatsDBContext> options) : base(options)
        {

        }


        public DbSet<Cat> Cats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>().HasData(new Cat { 
                ID=1,
                Name = "Tom",
                Age=5,
                Color = Color.Black
            }, 
            new Cat
            {
                ID = 2,
                Name = "Barsik",
                Age = 24,
                Color = Color.Brown
            });
        }
    }
}
