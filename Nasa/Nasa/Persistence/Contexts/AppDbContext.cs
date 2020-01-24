using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

using Nasa.Domain.Models;

namespace Nasa.Persistence.Contexts
{
    public class AppDbContext : DbContext

    {
        public DbSet<Category> rovers { get; set; }

        public DbSet<Rovers> Rovers { get; set; }



        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder builder)

        {

            base.OnModelCreating(builder);



            builder.Entity<Category>().ToTable("Rovers");

            builder.Entity<Category>().HasKey(p => p.Id);

            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);

            builder.Entity<Category>().HasMany(p => p.Rovers).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);



            builder.Entity<Category>().HasData

            (

                new Category { Id = 100, Name = "Rover1", Antalhjul = 4, Hastighet = 40, Vikt = 1000}, // 

                new Category { Id = 101, Name = "Rover2", Antalhjul = 6, Hastighet = 50, Vikt = 1200 },

                new Category { Id = 102, Name = "Rover3", Antalhjul = 8, Hastighet = 60, Vikt = 1400 }


            );



            builder.Entity<Rovers>().ToTable("Rovers");

            builder.Entity<Rovers>().HasKey(p => p.Id);

            builder.Entity<Rovers>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<Rovers>().Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.Entity<Rovers>().Property(p => p.Antalhjul).IsRequired();

            builder.Entity<Rovers>().Property(p => p.Hastighet).IsRequired();

            builder.Entity<Rovers>().Property(p => p.Vikt).IsRequired();

            builder.Entity<Rovers>().Property(p => p.UnitOfMeasurement).IsRequired();

        }

    }
}
