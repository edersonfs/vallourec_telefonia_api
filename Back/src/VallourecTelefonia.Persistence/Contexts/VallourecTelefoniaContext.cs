
using Microsoft.EntityFrameworkCore;
using VallourecTelefonia.Domain;

namespace VallourecTelefonia.Repository.Contexts
{
    public class VallourecTelefoniaContext : DbContext
    {
        public VallourecTelefoniaContext(DbContextOptions<VallourecTelefoniaContext> options)
            : base(options) { }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<NumeroTelefone> NumeroTelefone { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: show logic for delete on cascade
        }
    }
}