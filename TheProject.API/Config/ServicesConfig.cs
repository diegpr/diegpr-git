using Microsoft.Extensions.DependencyInjection;
using TheProject.API.Model.AppServices;
using TheProject.API.Model.DomainServices;
using TheProject.API.Model.Entities;

namespace TheProject.API.Config
{
    public static class ServicesConfig
    {

        public static void Configure(this IServiceCollection services)
        {
            services.AddTransient<IGenericService<Cargo>, CargoService>();
        }
    }
}
