using AutoMapper;
using HW3.DAL.Entities;
using HW3.DAL.Repository;
using HW3.DAL.Repository.DataBase;
using HW3.DAL.Repository.Interfaces;
using HW3.Mapper;
using HW3.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace HW3
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
            string con = "Server=localhost;Port=5254;Database=HW3;Username=postgres;Password=3299;";
            services.AddDbContext<UserDbContext>(options =>
                options.UseNpgsql(con));

            services.AddControllers();

            var mapper = new MapperConfiguration(mapper =>
                mapper.AddProfile(new MapperProfile()))
                .CreateMapper();
            services.AddSingleton(mapper);
                        
            services.TryAddTransient<IPersonsRepository, PersonsRepository>();            
            services.TryAddTransient<IService<Persons>, PersonsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();      
                
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