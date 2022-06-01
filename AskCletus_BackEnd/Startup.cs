using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.DALModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AskCletus_BackEnd
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
            services.AddDbContext<IDrinkContext, DrinkContext>();

            services.Configure<CocktailClientConfig>(Configuration.GetSection("CocktailClientConfig"));
          //  services.Configure<DBConfig>(Configuration.GetSection("ConnectionString"));

            services.AddHttpClient<ICocktailClient, CocktailClient>(httpClient =>
            {
                var config = new CocktailClientConfig();
                Configuration.GetSection("CocktailClientConfig").Bind(config);
                httpClient.BaseAddress = new Uri(config.BaseUrl);
            });

            services.AddCors(corsOptions =>
            {
                corsOptions.AddDefaultPolicy(corsPolicyBuilder =>
                {
                    corsPolicyBuilder.AllowAnyHeader();
                    corsPolicyBuilder.AllowAnyMethod();
                    corsPolicyBuilder.AllowAnyOrigin();
                });
            });

            services
               .AddControllers()
               .AddJsonOptions(jsonOptions =>
               {
                   jsonOptions.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
               });

            services.Configure<GithubOAuthSettings>(Configuration.GetSection("GithubOAuth"));
            services.AddSwaggerGen(swaggerGenOptions =>
            {
                swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "AskCletus_BackEnd", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AskCletus_BackEnd v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
