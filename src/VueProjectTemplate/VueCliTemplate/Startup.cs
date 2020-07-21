using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using VueCliMiddleware;

namespace $safeprojectname$
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // NOTE: PRODUCTION Ensure this is the same path that is specified in your webpack output
            services.AddSpaStaticFiles(opt => opt.RootPath = "ClientApp/dist");
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }      
            else
            {
                app.UseExceptionHandler(configure => configure.Run(async context =>
                {
                    var feature = context.Features.Get<IExceptionHandlerPathFeature>();
                    var exception = feature.Error;
                    var result = JsonConvert.SerializeObject(new
                    {
                        RequestId = System.Diagnostics.Activity.Current?.Id ?? context.TraceIdentifier,
                        ErrorMessage = exception.Message
                    });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(result);
                }));
            }

            // NOTE: this is optional, it adds HTTPS to Kestrel
            app.UseHttpsRedirection();

            // NOTE: PRODUCTION uses webpack static files
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                // NOTE: VueCliProxy is meant for developement and hot module reload
                // NOTE: SSR has not been tested
                // Production systems should only need the UseSpaStaticFiles() (above)
                // You could wrap this proxy in either
                // if (System.Diagnostics.Debugger.IsAttached)
                // or a preprocessor such as #if DEBUG

                endpoints.MapToVueCliProxy(
                    "{*path}",
                    new SpaOptions { SourcePath = "ClientApp" },
                    npmScript: (System.Diagnostics.Debugger.IsAttached) ? "serve" : null,
                    regex: "Compiled successfully",
                    forceKill: true
                    );
            });

            //app.UseSpa(spa =>
            //{
            //    if (env.IsDevelopment())
            //    {
            //        spa.Options.SourcePath = "ClientApp";
            //        spa.UseVueCli(npmScript: "serve");
            //    }
            //});
        }
    }
}
