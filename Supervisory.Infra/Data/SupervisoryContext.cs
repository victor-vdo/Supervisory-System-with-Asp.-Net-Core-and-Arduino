using Microsoft.EntityFrameworkCore;
using Supervisory.Domain.Interfaces;
using Supervisory.Domain.Models;

namespace Supervisory.Infra.Data
{
    public class SupervisoryContext : DbContext,ISupervisoryContext
    {
        public SupervisoryContext(DbContextOptions<SupervisoryContext> options) 
            : base(options) { }

        public DbSet<Temperature> Temperatures { get; set; }
    }
}
