using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastuctura.UnityOfWork;

namespace API.Extension;
    public static class ApplicationServiceExtensions
    {
        public static void ConfigureCore(this IServiceCollection services)=>
        services.AddCors(options=>
        {
            options.AddPolicy("CorsPolicy",builder=>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfwork>();
        }
    }
