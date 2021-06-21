using Microsoft.EntityFrameworkCore;
using Supervisory.Domain.Interfaces;
using Supervisory.Domain.Models;

namespace Supervisory.Infra.Data
{
    public class SupervisoryContext : DbContext, ISupervisoryContext
    {
        public SupervisoryContext(DbContextOptions<SupervisoryContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperature>();
            modelBuilder.Entity<Temperature>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Temperature>()
                .Property(t => t.Value).IsRequired();
            modelBuilder.Entity<Temperature>()
                .Property(t => t.Date).IsRequired();
        }

        public DbSet<Temperature> Temperatures { get; set; }
    }
}
