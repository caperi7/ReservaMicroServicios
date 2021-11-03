using System;
using System.ComponentModel.DataAnnotations;

namespace ReservasOnline.Microservice.Model
{
    public class TipoPasajero
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Tipo de Pasajero es obligatorio")]
        [Display(Name = "Nombre de Tipo de Pasajero")]
        public string Nombre { get; set; }
    }
}
