using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservasOnline.Microservice.Model;
using System;
using System.Collections.Generic;

namespace ReservasOnline.Microservice.Persistence.Configurations
{
    public class AeropuertoConfiguration
    {
        public AeropuertoConfiguration(EntityTypeBuilder<Aeropuerto> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);

            var listado = new List<Aeropuerto>();

            listado.Add(new Aeropuerto
            {
                Id = Guid.NewGuid() + "",
                Nombre = "El Dorado / Bogotá"
            });

            listado.Add(new Aeropuerto
            {
                Id = Guid.NewGuid() + "",
                Nombre = "Rodríguez Ballón / Perú"
            });

            listado.Add(new Aeropuerto
            {
                Id = Guid.NewGuid() + "",
                Nombre = " Adolfo Suárez Madrid / Barajas"
            });

            listado.Add(new Aeropuerto
            {
                Id = Guid.NewGuid() + "",
                Nombre = "Albacete / Los Llanos"
            });

            listado.Add(new Aeropuerto
            {
                Id = Guid.NewGuid() + "",
                Nombre = "Paris Internacional / París"
            });

            entityBuilder.HasData(listado);
        }
    }
}
