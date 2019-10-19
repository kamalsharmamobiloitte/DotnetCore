using Microsoft.AspNetCore.Builder;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StartupPractise
{ 
    // Fallback Startup class
    // Selected if the environment doesn't match a Startup{EnvironmentName} class
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void ConfigureProductionServices(IServiceCollection services)
        {

        }




        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {

           

        }
    }

    public class StartupProduction
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
       
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseMiddleware<MiddleWare4>();
        }
    }


    //public class Startup
    //{
    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //    }

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //    {
    //        if (env.IsDevelopment())
    //        {
    //            app.UseDeveloperExceptionPage();
    //        }

    //        app.UseRouting();

    //        app.UseEndpoints(endpoints =>
    //        {
    //            endpoints.MapGet("/", async context =>
    //            {
    //                await context.Response.WriteAsync("Hello World!");
    //            });
    //        });
    //    }
    //}
}
