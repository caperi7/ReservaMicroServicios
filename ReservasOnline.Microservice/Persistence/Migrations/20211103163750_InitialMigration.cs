using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservasOnline.Microservice.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Reserva");

            migrationBuilder.CreateTable(
                name: "Aerolinea",
                schema: "Reserva",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aerolinea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aeropuerto",
                schema: "Reserva",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeropuerto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPasajero",
                schema: "Reserva",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPasajero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                schema: "Reserva",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AeropuertoSalidaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AeropuertoLLegadaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HoraLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AerolineaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumeroVuelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPasajeroId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Aerolinea_AerolineaId",
                        column: x => x.AerolineaId,
                        principalSchema: "Reserva",
                        principalTable: "Aerolinea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Aeropuerto_AeropuertoLLegadaId",
                        column: x => x.AeropuertoLLegadaId,
                        principalSchema: "Reserva",
                        principalTable: "Aeropuerto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Aeropuerto_AeropuertoSalidaId",
                        column: x => x.AeropuertoSalidaId,
                        principalSchema: "Reserva",
                        principalTable: "Aeropuerto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_TipoPasajero_TipoPasajeroId",
                        column: x => x.TipoPasajeroId,
                        principalSchema: "Reserva",
                        principalTable: "TipoPasajero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Reserva",
                table: "Aerolinea",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { "642c07a6-01cb-45a1-837a-ef05ae4f1842", "LAN" },
                    { "db195457-99f9-42b1-9346-d480c773214d", "AVIANCA" },
                    { "04798c66-e7d0-42ca-b6ce-cb10a2f1c333", "SATENA" }
                });

            migrationBuilder.InsertData(
                schema: "Reserva",
                table: "Aeropuerto",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { "b57f1a35-8300-42c4-8238-fe5e30e1e9dd", "El Dorado / Bogotá" },
                    { "2b18d0e5-190d-41b7-b581-70e7c4b22e00", "Rodríguez Ballón / Perú" },
                    { "9bf1ca7b-a848-404a-86f3-e3e5c629a047", " Adolfo Suárez Madrid / Barajas" },
                    { "4cc7cde3-98be-407b-80b9-3305c4d21347", "Albacete / Los Llanos" },
                    { "1e20368f-8994-48cf-b135-35210c452432", "Paris Internacional / París" }
                });

            migrationBuilder.InsertData(
                schema: "Reserva",
                table: "TipoPasajero",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { "c458918a-5b79-4e5a-b813-0e6232be7496", "Niño" },
                    { "03de8ee1-936c-4849-a580-53f0a429aa8b", "Adulto" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_AerolineaId",
                schema: "Reserva",
                table: "Reservas",
                column: "AerolineaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_AeropuertoLLegadaId",
                schema: "Reserva",
                table: "Reservas",
                column: "AeropuertoLLegadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_AeropuertoSalidaId",
                schema: "Reserva",
                table: "Reservas",
                column: "AeropuertoSalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_TipoPasajeroId",
                schema: "Reserva",
                table: "Reservas",
                column: "TipoPasajeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas",
                schema: "Reserva");

            migrationBuilder.DropTable(
                name: "Aerolinea",
                schema: "Reserva");

            migrationBuilder.DropTable(
                name: "Aeropuerto",
                schema: "Reserva");

            migrationBuilder.DropTable(
                name: "TipoPasajero",
                schema: "Reserva");
        }
    }
}
