﻿using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using VasuthalozatAdminApplication.Entities;

namespace VasuthalozatAdminApplication.Database
{
    public class VasutContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Railway> Railways { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Foglalas> Foglalasok { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlConnectionStringBuilder builder = new()
            {
                UserID = "root",
                Password = "",
                Server = "localhost",
                Port = 3306,
                Database = "railway_project"
            };

            optionsBuilder.UseMySql(
                builder.ConnectionString,
                new MySqlServerVersion(new Version(10, 4, 14)));
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
