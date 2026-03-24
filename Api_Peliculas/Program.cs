using Microsoft.EntityFrameworkCore;
using Api_Peliculas.Data;
using Api_Peliculas.Repositorio.iRepositorio;
using Api_Peliculas.Repositorio;
using Api_Peliculas.PeliculasMapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Agregamos repositorios
builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();


//Agregamos auto Mapper
builder.Services.AddAutoMapper(typeof(PeliculasMapper));

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
