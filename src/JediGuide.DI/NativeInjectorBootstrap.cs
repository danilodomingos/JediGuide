using JediGuide.Application.IServices;
using JediGuide.Application.Services;
using JediGuide.Data.Context;
using JediGuide.Data.Repository;
using JediGuide.Data.Repository.Interfaces;
using JediGuide.Data.UOW;
using JediGuide.Service;
using JediGuide.Service.Base;
using JediGuide.Service.Interfaces;
using JediGuide.SWAPI.Client.Service;
using Microsoft.Extensions.DependencyInjection;

namespace JediGuide.DI
{
    public class NativeInjectorBootstrap
    {
        public static void RegisterServices(IServiceCollection services)
        {   
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<SWAPIClient>();
            services.AddScoped<JediGuideContext>();

            services.AddScoped<IPlanetAppService, PlanetAppService>();
            services.AddScoped<IPlanetService, PlanetService>();
            services.AddScoped<IPlanetRepository, PlanetRepository>();
        }
    }
}