using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Repositories;
using LibraryApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API
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
            services.AddMvc();
            /* --- REPOSITORIES --- */
            services.AddTransient<ILibraryRepository, LibraryRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IRecommendationRepository, RecommendationRepository>();
            services.AddTransient<IReportRepository, ReportRepository>();
            services.AddTransient<IOutloanRepository, OutloanRepository>();
            /* --- SERVICES --- */
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<IRecommendationService, RecommendationService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<IOutloanService, OutloanService>();
            /* --- DATABASE CONNECTION --- */
            //services.AddDbContext<AppDataContext>(options => options.UseSqlite("Data source=../Repositories/Db/LibraryApp.db"));
            services.AddDbContext<AppDataContext>(options => 
                options.UseSqlite("Data source=../Repositories/Db/LibraryApp.db", b => b.MigrationsAssembly("API")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
