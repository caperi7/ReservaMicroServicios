using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservasOnline.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasOnline.Microservice.Persistence.Configurations
{
    public class AerolineaConfiguration
    {
        public AerolineaConfiguration(EntityTypeBuilder<Aerolinea> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);

            var listado = new List<Aerolinea>();

            listado.Add(new Aerolinea
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "LAN"
            });

            listado.Add(new Aerolinea
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "AVIANCA"
            });

            listado.Add(new Aerolinea
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "SATENA"
            });

            entityBuilder.HasData(listado);
        }
    }
}
