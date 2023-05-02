﻿using AppPersistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using ModelDomainLibrary;
using ShopApplication.Interfaces;

namespace AppPersistence
{
    public class PizzaDbContext : DbContext, IPizzaDbContext
    {
        public DbSet<PizzaModel> Pizza { get; set; }

        public PizzaDbContext(DbContextOptions<PizzaDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ModelConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
