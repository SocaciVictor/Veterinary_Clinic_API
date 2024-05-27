using Veterinary_Clinic.Core.Services;
using Veterinary_Clinic.Database.Context;
using Veterinary_Clinic.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Veterinary_Clinic
{
    public static class StartupConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<VetsSerivices>();
            services.AddScoped<IVetRepository, VetRepository>();
            services.AddScoped<UsersServices>();
            services.AddScoped<IUserRepository, UserRepository>();  
            services.AddScoped<AuthService>();
            services.AddScoped<AnimalsServices>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
        }


        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<VeterinaryClinicDbContext>();
            services.AddScoped<DbContext, VeterinaryClinicDbContext>();

            services.AddScoped<IVetRepository, VetRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }   

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Veterinary Clinic", Version = "v1" });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme.",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            In = ParameterLocation.Header,
                        }, new List<string>()
                    }
                });
            });
        }
    }
}
