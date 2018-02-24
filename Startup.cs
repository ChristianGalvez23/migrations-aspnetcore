using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using migrations_example.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace migrations_example {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddDbContext<MigrationsDbContext> (o =>
                o.UseSqlServer (Configuration["ConnectionStrings:Default"])
            );
            services.AddMvc ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env, MigrationsDbContext context) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            context.Database.Migrate ();

            app.UseMvc ();
        }
    }
}