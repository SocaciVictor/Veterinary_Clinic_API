using Microsoft.EntityFrameworkCore;
using Veterinary_Clinic;
using Veterinary_Clinic.Core.Services;
using Veterinary_Clinic.Database.Context;
using Veterinary_Clinic.Database.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<VetsSerivices>();
        builder.Services.AddScoped<IVetRepository, VetRepository>();
        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();
        //builder.Services.AddServices();
        //xbuilder.Services.AddRepositories();
       
        

        var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        builder.Services.AddDbContext<VeterinaryClinicDbContext>(
            options => options.UseSqlServer(config.GetConnectionString("DatabaseConnection")));


        var app = builder.Build();




        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}