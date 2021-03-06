﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceStore.Data;
using ECommerceStore.Models;
using ECommerceStore.Models.Handler;
using ECommerceStore.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<WarehouseDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("WarehouseLocalDB")));
            //options.UseSqlServer(Configuration["ConnectionStrings:WarehouseDeployedDB"]));

            services.AddDbContext<UserDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("UserLocalDB")));
            //options.UseSqlServer(Configuration["ConnectionStrings:UserDeployedDB"]));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();


            // Claims
            services.AddAuthorization(option =>
            {
                option.AddPolicy("AdminOnly", policy => policy.RequireRole(ApplicationRoles.Admin));
                option.AddPolicy("SubscribersOnly", policy => policy.RequireClaim("Subscription"));
            });


            // OAuth
            services.AddAuthentication().AddGoogle(google =>
            {
                google.ClientId = Configuration["OAuth:Authentication:Google:ClientId"];
                google.ClientSecret = Configuration["OAuth:Authentication:Google:ClientSecret"];
            }).AddMicrosoftAccount(microsoftOptions =>
            {
                microsoftOptions.ClientId = Configuration["OAuth:Authentication:Microsoft:ApplicationId"];
                microsoftOptions.ClientSecret = Configuration["OAuth:Authentication:Microsoft:Password"];
            });

            // Policy
            services.AddTransient<IAuthorizationHandler, SubscriberFeatureHandler>();   

            // Connecting with database through interfaces
            services.AddScoped<IInventory, DevInventory>();
            services.AddTransient<IBasket, DevBasket>();
            services.AddTransient<IOrder, DevOrder>();

            // Connection with Email Sender
            services.AddScoped<IEmailSender, EmailSender>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("un-break me");
            });
        }
    }
}
