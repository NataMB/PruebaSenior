using Microsoft.EntityFrameworkCore;
using pruebasenior.Domain.Entities;

namespace pruebasenior.Infrastructure.Data
{
    public class PruebaseniorDbContext : DbContext
    {
        public PruebaseniorDbContext(DbContextOptions<PruebaseniorDbContext> options)
            : base(options)
        {
        }

        public DbSet<WalletTransaction> WalletTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WalletTransaction>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ProgramId).IsRequired();
                entity.Property(e => e.PointType).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            });
        }
    }
}