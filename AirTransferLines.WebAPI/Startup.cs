using AirTransferLines.Business.Abstract;
using AirTransferLines.Business.Concrete;
using AirTransferLines.Core.Security.JWT;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.DataAccess.Concrete.EntityFramework;
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
using System.Threading.Tasks;

namespace AirTransferLines.WebAPI
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

            services.AddControllers();
            services.AddSingleton<IAcenteService, AcenteManager>();
            services.AddSingleton<IAuthService, AuthManager>();
            services.AddSingleton<ITransferService, TransferManager>();
            services.AddSingleton<IRezervasyonService, RezervasyonManager>();
            services.AddSingleton<ISurucuService, SurucuManager>();
            services.AddSingleton<ISurucuDestekService, SurucuDestekManager>();
            services.AddSingleton<IUyeService, UyeManager>();



            services.AddSingleton<ITokenHelper, JwtHelper>();


            services.AddSingleton<IAcenteDal, EfAcenteDal>();
            services.AddSingleton<ITransferDal, EfTransferDal>();
            services.AddSingleton<IRezervasyonDal, EfRezervasyonDal>();
            services.AddSingleton<ISurucuDal, EfSurucuDal>();
            services.AddSingleton<ISurucuDestekDal, EfSurucuDestekDal>();
            services.AddSingleton<IUyeDal, EfUyeDal>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AirTransferLines.WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AirTransferLines.WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
