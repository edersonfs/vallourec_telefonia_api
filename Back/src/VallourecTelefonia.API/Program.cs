using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using VallourecTelefonia.Repository.Contexts;
using VallourecTelefonia.Application.Contracts;
using VallourecTelefonia.Application;
using VallourecTelefonia.Repository.Contracts;
using VallourecTelefonia.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<VallourecTelefoniaContext>(
    context => {
        var connectionString = builder.Configuration.GetConnectionString("default");
        var serverVersion = ServerVersion.AutoDetect(connectionString);

        context.UseMySql(connectionString, serverVersion);
    }
);
builder.Services.AddControllers();

builder.Services.AddScoped<IResponsavelService, ResponsavelService>();
builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<IResponsavelRepository, ResponsavelRepository>();

builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(cors => cors.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.MapControllers();

app.Run();
