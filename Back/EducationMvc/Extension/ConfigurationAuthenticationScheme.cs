using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EducationMvc.Extension
{
    public static class ConfigurationAuthenticationScheme
    {
       
        public static void AddAuthenticationConfig(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<Utilities.JwT>(configuration.GetSection("jwt"));
            services.AddAuthentication(Option=>{
                Option.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(option=>{
                    option.SaveToken=false;
                    option.RequireHttpsMetadata=false;
                    option.TokenValidationParameters=new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                            
                    };
                    });
        }
    }
}