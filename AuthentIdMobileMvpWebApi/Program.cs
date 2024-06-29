using AuthentIdMobileMvpWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//if (builder.Environment.IsDevelopment())
//{
//    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
//    connection = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
//}
//else
//{
//    connection = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTIONSTRING");
//}


var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AuthentIdDbContext>(options =>
    options.UseSqlServer(connection));
//var connection = builder.Configuration["ConnectionStrings:AuthentIdMvp:AZURE_SQL_CONNECTIONSTRING"];
//builder.Services.AddSqlServer<AuthentIdDbContext>(connection, options => options.EnableRetryOnFailure());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

