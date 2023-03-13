﻿using Iterates.Bwm.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterates.Bwm.Infrastructure.DbContexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Brewer> Brewers { get; set; }
    public DbSet<Beer> Beers { get; set; }
    public DbSet<Wholesaler> Wholesalers { get; set; }
    public DbSet<WholesalerStock> WholesalerStocks { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=sql-qa-stg-001.database.windows.net;Database=BWM;User Id=sqladmin;Password=P@ssw0rd;Trust Server Certificate=true ");
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BWM;User Id=sqladmin;Password=P@ssw0rd;Trust Server Certificate=true ");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brewer>()
            .HasMany(b => b.Beers);

        modelBuilder.Entity<Beer>()
            .HasMany(b => b.WholesalerStocks)
            .WithOne(wb => wb.Beer)
            .HasForeignKey(wb => wb.BeerId);

        modelBuilder.Entity<Wholesaler>()
            .HasMany(w => w.WholesalerStocks)
            .WithOne(wb => wb.Wholesaler)
            .HasForeignKey(wb => wb.WholesalerId);

        modelBuilder.Entity<WholesalerStock>()
            .HasKey(wb => new { wb.WholesalerId, wb.BeerId });

        ApplicationDbContextInitializer.SeedData(modelBuilder);
    }
}