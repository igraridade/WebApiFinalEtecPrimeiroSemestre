using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiFinalEtecPrimeiroSemestre.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebApiFinalEtecPrimeiroSemestreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiFinalEtecPrimeiroSemestreContext") ?? throw new InvalidOperationException("Connection string 'WebApiFinalEtecPrimeiroSemestreContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

//Políticas de Cors Origin

builder.Services.AddCors(etecPoliticas =>
{
    etecPoliticas.AddPolicy("EtecAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyMethod();
        });
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("EtecAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
