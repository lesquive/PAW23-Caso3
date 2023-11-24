using System;
using Microsoft.EntityFrameworkCore;

namespace LasPisadas.Models
{
    public class LasPisadasDbContext : DbContext
    {
        public LasPisadasDbContext(DbContextOptions<LasPisadasDbContext> options) : base(options)
        {
        }

        public DbSet<Zapato> Zapatos { get; set; }
        public DbSet<ZapatoCategoria> ZapatoCategorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("LasPisadasDbContext", new MySqlServerVersion(new Version(8, 0, 25)));
            }
        }
    }
}