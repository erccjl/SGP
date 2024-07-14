using Microsoft.EntityFrameworkCore;
using SGP.Datos.Context;
using SGP.Datos.Repository;
using SGP.Dominio.Contratos;
using SGP.Aplicacion.Mapper;
using SGP.Aplicacion.Services;
using SGP.Aplicacion.Services.Interfaces;
using SGP.Aplicacion.Services.Implementaciones;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conectionString = builder.Configuration.GetConnectionString("mysql");

var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
builder.Services.AddDbContext<PresupuestoContext>(dbConection => dbConection.UseMySql(conectionString, serverVersion));
builder.Services.AddAutoMapper(typeof(MovimientoProfile));
builder.Services.AddAutoMapper(typeof(ConsumerProfile));
builder.Services.AddAutoMapper(typeof(TarjetaProfile));

builder.Services.AddScoped<IMovimientoService, MovimientoService>();
builder.Services.AddScoped<IConsumidorService, ConsumidorService>();
builder.Services.AddScoped<ITarjetaService, TarjetaService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
