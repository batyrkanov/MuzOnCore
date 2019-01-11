using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MuzOnCore.Common.Interfaces;
using MuzOnCore.Data;
using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services;
using MuzOnCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuzOnCore.Common
{
    public class PlatformInitializer : IPlatformInitializer
    {
        protected IConfiguration _configuration;

        public PlatformInitializer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // configure database
            ConfigureDatabase(services);

            // add singletone instances
            services.AddSingleton(Mapping.Configuration.CreateDefaultMapper());

            // add scoped registrations
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArtistService, ArtistService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<ISongService, SongService>();
            services.AddScoped<IBandService, BandService>();
        }

        protected virtual void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<DbContext, MuzOnCoreContext>(options =>
               options.UseSqlServer(
                   _configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
