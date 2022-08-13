using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using UserTask;
using UserTask.Module;
using UserTask.Repo;



  var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UsersContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr"));

});


// Add services to the container.

builder.Services.AddControllers();
builder.Services.InitServices();


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
