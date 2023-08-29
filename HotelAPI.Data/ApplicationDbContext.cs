using HotelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            UpdateAuditingFields();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditingFields();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);
        }

        private void UpdateAuditingFields()
        {
            foreach (var entity in ChangeTracker.Entries<AuditBase>())
            {
                switch (entity.State)
                {
                    case EntityState.Modified:
                        entity.Entity.UpdatedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entity.Entity.InsertedDate = DateTime.Now;

                        break;
                }
            }
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }
    }
}