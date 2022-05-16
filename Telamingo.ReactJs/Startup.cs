using BusinessLogic.AdminService;
using BusinessLogic.CountryService;
using BusinessLogic.FormAnswer;
using BusinessLogic.Identity.GenerateToken;
using BusinessLogic.Identity.VerifyToken;
using BusinessLogic.JobService;
using BusinessLogic.Login;
using Domain.AggregateModels.AdminAggregate;
using Domain.AggregateModels.CountryAggregate;
using Domain.AggregateModels.SharedAggregate;
using Domain.AggregateModels.UserAggregate;
using Infrastructure;
using Infrastructure.Repositories.AdminRepository;
using Infrastructure.Repositories.CountryRepository;
using Infrastructure.Repositories.SharedRepository;
using Infrastructure.Repositories.UserRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Telamingo.ReactJs
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

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            services.AddDbContext<TelamingoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));
            services.AddScoped<TelamingoDbContext>();

            //For Identity
            services.AddIdentity<Admin, AdminRole>()
                .AddEntityFrameworkStores<TelamingoDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IAnswerService, AnswerService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddTransient<ILoginService, LoginService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddTransient<IVerifyTokenService, VerifyTokenService>();
            services.AddTransient<IGenerateTokenService, GenerateTokenService>();
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminService>();

            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICountryService, CountryService>();

            services.AddScoped<IJobService, JobService>();
            services.AddScoped<ISharedRepository, SharedRepository>();



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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
