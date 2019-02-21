using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StrategyApp.Models;

namespace StrategyApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<CountryUnit> CountryUnit { get; set; }
        public DbSet<CountryProject> CountryProject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
    new Country { Id = 1, Name = "asda", PopulationNumber = 2, GoldAmount = 2, PotatoAmount = 50, Point = 1}
);
            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 1, AttackPower = 6, DefensePower = 2, Name = "Rider", Price = 50, Salary = 1, PotatoRequirement = 1 },
                new Unit { Id = 2, AttackPower = 6, DefensePower = 2, Name = "Rider", Price = 50, Salary = 1, PotatoRequirement = 1 },
                new Unit { Id = 3, AttackPower = 2, DefensePower = 6, Name = "Archer", Price = 50, Salary = 1, PotatoRequirement = 1 },
                new Unit { Id = 4, AttackPower = 5, DefensePower = 5, Name = "Elite", Price = 100, Salary = 3, PotatoRequirement = 2 }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Type = Helper.EnumProjectsType.TRACTOR, RoundsToFinish = 15 },
                new Project { Id = 2, Type = Helper.EnumProjectsType.COMBINE, RoundsToFinish = 15 },
                new Project { Id = 3, Type = Helper.EnumProjectsType.CITYWALL, RoundsToFinish = 15 },
                new Project { Id = 4, Type = Helper.EnumProjectsType.OP_REBIRTH, RoundsToFinish = 15 },
                new Project { Id = 5, Type = Helper.EnumProjectsType.TACTICS, RoundsToFinish = 15 },
                new Project { Id = 6, Type = Helper.EnumProjectsType.ALCHEMY, RoundsToFinish = 15 },
                new Project { Id = 7, Type = Helper.EnumProjectsType.FARM, RoundsToFinish = 5 },
                new Project { Id = 8, Type = Helper.EnumProjectsType.BARACK, RoundsToFinish = 5 }
            );
            modelBuilder.Entity<CountryUnit>().HasData(
new CountryUnit { Id = 1, CountryId = 1, UnitId = 2, UnitNumber = 2 }
);
        }
    }
}
