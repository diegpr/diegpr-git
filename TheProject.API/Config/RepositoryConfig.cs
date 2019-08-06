using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheProject.API.Model.Infra;

namespace TheProject.API.Config
{
    public static class RepositoryConfig
    {

        public static void Configure(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("BecaConnString");
            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connString));
        }
    }
}