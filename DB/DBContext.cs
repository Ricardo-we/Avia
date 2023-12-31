﻿using DB;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;

namespace Avia.DB
{
    public class DBContext : DbContext
    {
        public String DbPath { get; set; }

        public DBContext() : base(new DbContextOptions<DBContext> {  })
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "aviadb.db");

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Vuelo> Vuelos { get; set; }
        //public DbSet<TarjetaVuelo> TarjetasVuelo { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Equipaje> Equipajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("user").HasIndex(u => u.dpi).IsUnique(true);
            modelBuilder.Entity<Asiento>().ToTable("asiento");
            //modelBuilder.Entity<TarjetaVuelo>().ToTable("tarjeta_vuelo");
            modelBuilder.Entity<Ciudad>().ToTable("ciudad");
            modelBuilder.Entity<Vuelo>().ToTable("vuelo");
            modelBuilder.Entity<Equipaje>().ToTable("equipaje");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite(@$"Data Source={DbPath}");

    }
}         