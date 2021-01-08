using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaceitGraphs_backend.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;

namespace FaceitGraphs_backend
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddCors();
            //services.AddControllers().AddNewtonsoftJson(options =>options.SerializerSettings.ReferenceLoopHandling =ReferenceLoopHandling.Ignore);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //var appSettingsSection = _configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(appSettingsSection);
            
            //services.AddScoped<Service>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );
            // app.UseAuthentication();
            // app.UseAuthorization();
            app.UseEndpoints(endpoints => //endpoints.MapController());
            {
                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World"); });
            });
        }
    }
}