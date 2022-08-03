using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Entity.Context;
namespace TestApplication.Extension
{
    public static class ConnectedSqlExtension
    {
        public static void ConnectedSql(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<AppEducationDbContext>(opt=>opt.UseSqlServer(configuration.
                                                                GetConnectionString("Education"),
                                                                    d=>d.MigrationsAssembly("EducationMvc")));
        }
    }
}
