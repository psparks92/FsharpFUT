using System;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace FSharpFUT.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
	    //var config = new ConfigurationBuilder()
		//.SetBasePath(Directory.GetCurrentDirectory())
		//.AddJsonFile("hosting.json", optional: true)
		//.Build();
            var host = new WebHostBuilder()
                .UseKestrel()
		.UseUrls("http://*:5000")
                .UseStartup<Program>()
                .Build();
            host.Run();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddTransient<PlayerDAL>();
            services.AddMvc();
            services.AddRouting();
	    services.AddCors();
            var corsBuilder = new CorsPolicyBuilder();
            corsBuilder.AllowAnyHeader();
            corsBuilder.AllowAnyMethod();
            corsBuilder.AllowAnyOrigin(); // For anyone access.
            corsBuilder.AllowCredentials();
	    services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", corsBuilder.Build());
    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
            // ********************
            // Setup CORS
            // ********************
            //corsBuilder.WithOrigins("http://localhost:56573"); // for a specific url. Don't add a forward slash on the end!
        }
    }
}
