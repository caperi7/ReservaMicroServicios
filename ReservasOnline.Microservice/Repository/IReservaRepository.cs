using ReservasOnline.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasOnline.Microservice.Repository
{
    public interface IReservaRepository
    {
        Task<string> Add(Reserva Reserva);
        Task<Reserva> GetById(string id);
        Task<List<Reserva>> GetAll();
        Task<string> Delete(string id);
        Task<Reserva> GetByTipoPasajeroId(string custid);
    }
}
