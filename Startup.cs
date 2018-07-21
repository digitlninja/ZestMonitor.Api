using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ZestMonitor.Api.Data.Contexts;
using ZestMonitor.Api.Data.Models;
using ZestMonitor.Api.Data.Seed;
using ZestMonitor.Api.Validation;

namespace ZestMonitor.Api
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

            services.AddDbContext<DataContext>(x => x.UseMySql(Configuration["ConnectionStrings:Default"]));
            services.AddTransient<Seed>();
            services.AddMvc().AddFluentValidation();
            services.AddSingleton<IValidator<ProposalPaymentsModel>, ProposalPaymentsValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Seed seed, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // TODO:: Check PP table for any records first, if none -> run seed
            seed.ProposalPayments();
            // Console.WriteLine(connectionStringSecret);
            app.UseMvc();
        }
    }
}