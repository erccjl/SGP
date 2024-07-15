using Microsoft.EntityFrameworkCore;
using SGP.Datos.Context;
using SGP.Datos.Repository;
using SGP.Dominio.Contratos;
using SGP.Aplicacion.Mapper;
using SGP.Aplicacion.Services;
using SGP.Aplicacion.Services.Interfaces;
using SGP.Aplicacion.Services.Implementaciones;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ClockSkew = TimeSpan.Zero  // Opcional: elimina el desfase de tiempo
    };
});
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
builder.Services.AddScoped<JwtService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
