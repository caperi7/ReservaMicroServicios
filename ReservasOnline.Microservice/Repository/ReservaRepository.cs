using Microsoft.EntityFrameworkCore;
using ReservasOnline.Microservice.Model;
using ReservasOnline.Microservice.Persistence.DbContexts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasOnline.Microservice.Repository
{
    public class ReservaRepository : IReservaRepository
    {
        private IApplicationDbContext _dbcontext;
        public ReservaRepository(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<string> Add(Reserva Reserva)
        {
            _dbcontext.Reservas.Add(Reserva);
            await _dbcontext.SaveChanges();
            return Reserva.Id;
        }

        public async Task<string> Delete(string id)
        {
            var Reservaupt = await _dbcontext.Reservas.Where(Reservadet => Reservadet.Id != id).ToListAsync();
            if (Reservaupt == null) return "Reserva does not exists";

            await _dbcontext.SaveChanges();
            return "Reserva Cancelled Successfully";
        }


        public async Task<Reserva> GetByTipoPasajeroId(string tipoPasajeroId)
        {
            var Reserva = await _dbcontext.Reservas.Where(Reservadet => Reservadet.TipoPasajero.Id == tipoPasajeroId).FirstOrDefaultAsync();
            return Reserva;
        }

        public async Task<Reserva> GetById(string id)
        {
            var Reserva = await _dbcontext.Reservas.Where(Reservadet => Reservadet.Id == id).FirstOrDefaultAsync();
            return Reserva;
        }


        public async Task<List<Reserva>> GetAll()
        {
            var Reserva = await _dbcontext.Reservas.ToListAsync();
            return Reserva;
        }
    }
}
