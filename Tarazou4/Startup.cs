using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Services;
using Tarazou4.Data;
using Data.Contracts;
using Microsoft.AspNetCore.Http;
using WebFramework;

namespace Tarazou4
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
           

            services.AddDbContext<tarazouContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
            });

            services.AddMvc(options =>
            {
                // options.Filters.Add(new AuthorizeFilter());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IJwtService, JwtService>();

            services.AddScoped<IQuestionCategoryRepository, QuestionCategoryRepository>();
            services.AddJwtAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            else
            {
               // app.UseExceptionHandler();
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseAuthentication();

        }
    }
}