using ContaBancaria.Entidade.Interfaces;
using ContaBancaria.Repository;
using ContaBancaria.Repository.Data;
using ContaBancaria.Service;
using ContaBancaria.Service.Interfces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InicializadorBD.Inicializar();

builder.Services.AddScoped<IContaCorrente, ContaCorrenteRepository>();
builder.Services.AddScoped<IContaPoupança, ContaPoupançaRepository>();

builder.Services.AddScoped<IContaCorrenteService, ContaCorrenteService>();
builder.Services.AddScoped<IContaPoupançaService, ContaPoupançaService>();

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
