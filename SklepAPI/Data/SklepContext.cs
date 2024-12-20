using Microsoft.EntityFrameworkCore;
using SklepAPI.Models;

namespace SklepAPI.Data
{
    public class SklepContext : DbContext
    {
        public SklepContext(DbContextOptions<SklepContext> options) : base(options) { }

        public DbSet<Produkt> Produkty { get; set; }
    }
}