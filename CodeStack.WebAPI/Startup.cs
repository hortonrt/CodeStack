using System;
using CodeStack.WebAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeStack.WebAPI {
    public class Startup {
        public IConfiguration Configuration { get; }
        private IHostingEnvironment CurrentEnvironment { get; set; }
        private bool isProd { get; set; }

        public Startup(IConfiguration configuration, IHostingEnvironment env) {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional : true, reloadOnChange : true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional : true, reloadOnChange : true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment()) {
                builder.AddUserSecrets<Startup>();
            }
            CurrentEnvironment = env;
            Configuration = builder.Build();
            isProd = Convert.ToBoolean(Configuration["IsProduction"]);
        }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options => {
                options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "dist"; });
            services.AddDbContext<CodeStackContext>(options => options.UseSqlServer(Configuration["connectionStrings:CodeStack" + (isProd ? "_Prod" : "_Dev")]));
            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseHsts();
            }
            if (isProd) {
                var options = new RewriteOptions();
                options.AddRedirectToWww();
                options.AddRedirectToHttps();
                app.UseRewriter(options);
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa => {
                spa.Options.SourcePath = "dist";
                if (env.IsDevelopment()) {
                    spa.Options.SourcePath = "../CodeStack.UI/dist";
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}