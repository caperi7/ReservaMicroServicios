using System;
using System.ComponentModel.DataAnnotations;

namespace ReservasOnline.Microservice.Model
{
    public class Aeropuerto
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "El campo Aeropuerto es obligatorio")]
        [Display(Name = "Nombre Aeropuerto")]
        public string Nombre { get; set; }
    }
}
