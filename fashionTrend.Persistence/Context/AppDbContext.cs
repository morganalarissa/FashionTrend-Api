using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // DB set ele é a representação de uma tabela
        // que vem do Entities do nosso Domain ao banco de dados

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<DraftContract> DraftContracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .Property(e => e.Materials)
                .HasConversion(
                    v => string.Join(",", v.Select(s => s.ToString())),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => (EMaterial)Enum.Parse(typeof(EMaterial), s))
                        .ToList());

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SewingMachines)
                .HasConversion(
                    v => string.Join(",", v.Select(s => s.ToString())),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => (ESewingMachine)Enum.Parse(typeof(ESewingMachine), s))
                        .ToList());

            modelBuilder.Entity<Service>()
                .Property(e => e.Materials)
                .HasConversion(
                    v => string.Join(",", v.Select(s => s.ToString())),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => (EMaterial)Enum.Parse(typeof(EMaterial), s))
                        .ToList());

            modelBuilder.Entity<Service>()
                .Property(e => e.SewingMachines)
                .HasConversion(
                    v => string.Join(",", v.Select(s => s.ToString())),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => (ESewingMachine)Enum.Parse(typeof(ESewingMachine), s))
                        .ToList());

        }
    }
}
