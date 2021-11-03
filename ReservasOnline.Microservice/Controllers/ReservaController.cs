using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservasOnline.Microservice.Model;
using ReservasOnline.Microservice.Repository;
using Serilog;

namespace ReservasOnline.Microservice.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private IReservaRepository _ReservaRepository;
        public ReservaController(IReservaRepository ReservaRepository)
        {
            _ReservaRepository = ReservaRepository;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] Reserva reserva)
        {
            try
            {
                Log.Debug("Reserva Addition Started");
                string Reservaid = await _ReservaRepository.Add(reserva);
                return Ok(Reservaid);
            }
            catch (Exception ex)
            {
                Log.Error("Reserva Addition Failed");
                throw new Exception("Reserva Addition Failed", innerException: ex);
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var Reservas = await _ReservaRepository.GetAll();
            return Ok(Reservas);
        }

        [HttpGet]
        [Route("GetByCustomerId/{id}")]
        public async Task<ActionResult> GetByTipoPasajeroId(string id)
        {
            var Reservas = await _ReservaRepository.GetByTipoPasajeroId(id);
            return Ok(Reservas);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult> GetById(string id)
        {
            var Reservadet = await _ReservaRepository.GetById(id);
            return Ok(Reservadet);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            string resp = await _ReservaRepository.Delete(id);
            return Ok(resp);
        }
    }
}
