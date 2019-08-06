using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using TheProject.API.Model.Infra;

namespace TheProject.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private IServiceCollection _services;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                 .AddJsonOptions(
                     op =>
                     {
                         op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                         op.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                     }
                 );
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = Configuration["ApiConfigs:Title"], Version = "v1" });
            });

            _services = services;

            Config.RepositoryConfig.Configure(_services, Configuration);
            Config.ServicesConfig.Configure(_services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            ConfigureSwagger(app);

            app.UseCors(c =>
            {
                c.AllowAnyOrigin();
                c.AllowAnyMethod();
                c.AllowAnyHeader();
            });
            app.UseHttpsRedirection();
            app.UseMvc();
            EnsureMigrationApplied(app);

        }
        private static void EnsureMigrationApplied(IApplicationBuilder app)
        {

            using (var ss = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (!ss.ServiceProvider.GetService<AppDbContext>().AllMigrationsApplied())
                {
                    ss.ServiceProvider.GetService<AppDbContext>().Database.Migrate();
                }
                ss.ServiceProvider.GetService<AppDbContext>().InitialSeed();
            }
        }

        private static void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
