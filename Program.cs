
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace StartupPractise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //CreateHostBuilderWithoutStartup(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var assName = typeof(Startup).GetTypeInfo().Assembly.FullName;
                    webBuilder.UseStartup(assName);
                }).ConfigureServices(config => {
                    config.AddTransient<IStartupFilter, StartupFilter1>();
                    config.AddTransient<IStartupFilter, StartupFilter2>();
                });
           

        public static IHostBuilder CreateHostBuilderWithoutStartup(string[] args) =>
        Host.CreateDefaultBuilder(args)             
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureServices(services =>
                {                   
                    services.AddControllers();

                }).Configure(appbuilder=> {

                    var loggerFactory =  appbuilder.ApplicationServices.GetService<ILoggerFactory>();
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogInformation("Startup config begins : ");
                    var config = appbuilder.ApplicationServices.GetService<IConfiguration>();
                    var content = config.GetSection("Print").Value;

                    appbuilder.Run(async request =>
                    {  
                        await request.Response.WriteAsync("Hello :"+ content);
                    });          
                
                });                
             
    });


    }  
}
