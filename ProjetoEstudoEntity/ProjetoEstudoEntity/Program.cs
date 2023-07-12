using Microsoft.EntityFrameworkCore;
using ProjetoEstudoEntity.Infraestrutura.Contexto;
using ProjetoEstudoEntity.Infraestrutura.Repositorio;
using ProjetoEstudoEntity.Infraestrutura.Repositorio.Interface;
using ProjetoEstudoEntity.Servico.Servico;
using ProjetoEstudoEntity.Servico.Servico.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProjetoEstudoEntityContexto>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conexaoBase")));

//Repositorio
builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

//Serviço
builder.Services.AddScoped<ITarefaServico, TarefaServico>();

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
