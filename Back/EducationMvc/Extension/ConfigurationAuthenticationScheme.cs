using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;

namespace EducationMvc.Extension
{
    public static class ConfigurationAuthenticationScheme
    {
       
        public static void AddAuthenticationConfig(this IServiceCollection services)
        {
            services.AddAuthentication(Option=>{
                Option.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer();
        }
    }
}