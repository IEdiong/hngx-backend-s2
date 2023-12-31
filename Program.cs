﻿using hngXStageTwo.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

if (builder.Environment.IsDevelopment())
{
    var connectionString = builder.Configuration.GetConnectionString("PersonDb");

    builder.Services.AddDbContext<PersonContext>(options =>
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
}
else
{
    var connectionString = Environment.GetEnvironmentVariable("Smarterasp");

    builder.Services.AddDbContext<PersonContext>(options =>
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
}

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();

