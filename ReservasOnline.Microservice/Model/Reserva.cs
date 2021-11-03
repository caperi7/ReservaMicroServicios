using System;
using System.ComponentModel.DataAnnotations;

namespace ReservasOnline.Microservice.Model
{
    public class Reserva
    {
        public string Id { get; set; }
        
        [Required(ErrorMessage = "El campo Aeropuerto de Salida es obligatorio")]
        [Display(Name = "Aeropuerto de Salida")]
        public Aeropuerto AeropuertoSalida { get; set; }
        
        [Required(ErrorMessage = "El campo Hora de Salida es obligatorio")]
        [Display(Name = "Hora de Salida")]
        public DateTime HoraSalida { get; set; }
        
        [Required(ErrorMessage = "El campo Aeropuerto de Llegada es obligatorio")]
        [Display(Name = "Aeropuerto de Llegada")]
        public Aeropuerto AeropuertoLLegada { get; set; }

        [Required(ErrorMessage = "El campo Hora de Llegada es obligatorio")]
        [Display(Name = "Hora de Llegada")]
        public DateTime HoraLlegada { get; set; }

        [Required(ErrorMessage = "El campo Aerolinea es obligatorio")]
        [Display(Name = "Aerolinea")]
        public Aerolinea Aerolinea { get; set; }

        [Required(ErrorMessage = "El campo Numero Vuelo es obligatorio")]
        [Display(Name = "Numero Vuelo")]
        public string NumeroVuelo { get; set; }

        [Required(ErrorMessage = "El campo Tipo de Pasajero es obligatorio")]
        [Display(Name = "Tipo de Pasajero")]
        public TipoPasajero TipoPasajero { get; set; }

        [Required(ErrorMessage = "El campo precio es obligatorio")]
        [Display(Name = "precio")]
        public double Precio { get; set; }

    }
}
