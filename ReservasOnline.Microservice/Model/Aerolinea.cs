using System;
using System.ComponentModel.DataAnnotations;

namespace ReservasOnline.Microservice.Model
{
    public class Aerolinea
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "El campo Aerolinea es obligatorio")]
        [Display(Name = "Nombre Aerolinea")]
        public string Nombre { get; set; }
    }
}
