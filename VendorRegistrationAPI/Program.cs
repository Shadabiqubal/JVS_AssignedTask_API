using DataAccessLibrary.DataAccessLayer.DBContext;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using DataAccessLibrary.DataAccessLayer.Repository.Repositories;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using DataAccessLibrary.DataAccessLayer.Service.Services;
using Microsoft.EntityFrameworkCore;
using VendorRegistrationAPI.ConfigureService.ServiceCollection;
using VendorRegistrationAPI.Middlewares;


var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());



app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GlobalErrorHandlingMiddleware>();

app.MapControllers();

app.Run();
