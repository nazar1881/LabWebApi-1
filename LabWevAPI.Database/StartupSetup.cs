using LabWebApi.contracts.Data;
using LabWebApi.contracts.Data.Entities;
using LabWebAPI.Database.Data;
using LabWevAPI.Database.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LabWevAPI.Database
{
    public static class StartupSetup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
        public static void AddDbContext(this IServiceCollection services, string
       connectionString)
        {
            services.AddDbContext<LabWebApiDbContext>(x =>
            x.UseSqlServer(connectionString));
        }

        public static void AddIdentityDbContext(this IServiceCollection services)
        {
            services.AddIdentity<User,
            IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<LabWebApiDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
