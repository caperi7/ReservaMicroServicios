using Microsoft.EntityFrameworkCore;
using ReservasOnline.Microservice.Model;
using System.Threading.Tasks;

namespace ReservasOnline.Microservice.Persistence.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Reserva> Reservas { get; set; }
        Task<int> SaveChanges();
    }
}
