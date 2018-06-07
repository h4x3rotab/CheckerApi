﻿using AutoMapper;
using CheckerApi.Context;
using CheckerApi.Extensions;
using CheckerApi.Services;
using CheckerApi.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using WebApiContrib.Core.Formatter.Csv;

namespace CheckerApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            
            services.AddDbContext<ApiContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("Connection")));
            services.AddTransient<ISyncService, SyncService>();
            services.AddTransient<INotificationManager, NotificationManager>();
            services.AddTransient<IConditionComplier, ConditionComplier>();
            services.AddTransient<IRestClient, RestClient>();
            services.AddTransient<IAuditManager, AuditManager>();

            services.AddMvc()
                .AddCsvSerializerFormatters();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // TODO Check if exists
            app.SetupHttpsRedirect(Configuration, env);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
