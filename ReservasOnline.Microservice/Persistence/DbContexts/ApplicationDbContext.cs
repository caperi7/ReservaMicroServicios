using Microsoft.EntityFrameworkCore;
using ReservasOnline.Microservice.Model;
using ReservasOnline.Microservice.Persistence.Configurations;
using System;
using System.Threading.Tasks;

namespace ReservasOnline.Microservice.Persistence.DbContexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Database schema
            builder.HasDefaultSchema("Reserva");

            // Model Contraints
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            new TipoPasajeroConfiguration(builder.Entity<TipoPasajero>());
            new AeropuertoConfiguration(builder.Entity<Aeropuerto>());
            new AerolineaConfiguration(builder.Entity<Aerolinea>());

        }

        public DbSet<Reserva> Reservas { get; set; }
        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
