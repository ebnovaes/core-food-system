using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdeToFoodCore.Services;

namespace OdeToFoodCore
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                                               .SetBasePath(env.ContentRootPath)
                                               .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(provider => Configuration)
                    .AddSingleton<IGreeter, Greeter>();
                    
        }

        IConfiguration Configuration { get; set; }

        public void Configure(IApplicationBuilder app, IGreeter greeter)
        {
            app.Run(async (context) =>
            {
                var greeting = greeter.GetGreeting();
                await context.Response.WriteAsync(greeting);
            });
        }
    }
}
