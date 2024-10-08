﻿using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using VasuthalozatPublicApplication.Entities;

namespace VasuthalozatPublicApplication.Database
{
    public class VasutContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Railway> Railways { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Foglalas> Foglalasok { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Railway>().HasOne(x => x.From);
            modelBuilder.Entity<Railway>().HasOne(x => x.To);
            modelBuilder.Entity<Foglalas>().HasOne(x => x.User);
            modelBuilder.Entity<Foglalas>().HasOne(x => x.Railway);

            List<City> cities = ReadFiles.ReadCities();
            foreach (City city in cities)
            {
                modelBuilder.Entity<City>().HasData(city);
            }

            List<Railway> railways = ReadFiles.ReadRailways(cities);
            foreach (Railway railway in railways)
            {
                modelBuilder.Entity<Railway>().HasData(railway);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.UserID = "root";
            builder.Password = "";
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.Database = "railway_project";

            optionsBuilder.UseMySql(
                builder.ConnectionString,
                new MySqlServerVersion(new Version(10, 4, 14)));
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
