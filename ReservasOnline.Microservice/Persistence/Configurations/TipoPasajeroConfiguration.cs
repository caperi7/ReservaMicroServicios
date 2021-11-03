using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservasOnline.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasOnline.Microservice.Persistence.Configurations
{
    public class TipoPasajeroConfiguration
    {
        public TipoPasajeroConfiguration(EntityTypeBuilder<TipoPasajero> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);

            var listado = new List<TipoPasajero>();

            listado.Add(new TipoPasajero
            {
                Id = Guid.NewGuid() + "",
                Nombre = "Niño"
            });

            listado.Add(new TipoPasajero
            {
                Id = Guid.NewGuid() + "",
                Nombre = "Adulto"
            });

            entityBuilder.HasData(listado);
        }
    }
}
