using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace EducationMvc.Extension
{
    public static class ConfigurationAuthenticationScheme
    {
       
<<<<<<< HEAD
        public static void AddAuthenticationConfig(this IServiceCollection services,IConfiguration configuration )
=======
        public static void AddAuthenticationConfig(this IServiceCollection services,IConfiguration configuration)
>>>>>>> ca769fb27606aa36dbaac9c6d301a410f1699e80
        {
            services.Configure<Utilities.JwT>(configuration.GetSection("jwt"));
            services.AddAuthentication(Option=>{
                Option.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
<<<<<<< HEAD
                }).AddJwtBearer(
                  Jwt=>{
                    var  key=Encoding.ASCII.GetBytes(configuration["jwt.Key"]);
                    Jwt.RequireHttpsMetadata=false;
                    Jwt.SaveToken=false;
                    Jwt.TokenValidationParameters=new Microsoft.IdentityModel.Tokens.TokenValidationParameters{
                        ValidateAudience=true,
                        ValidAudience=configuration["jwt.aud"],
                        ValidateIssuer=true,
                        ValidIssuer=configuration["jwt.iss"],
                        IssuerSigningKey=new SymmetricSecurityKey(key)
                    };
                  }
                );
=======
                }).AddJwtBearer(option=>{
                    option.SaveToken=false;
                    option.RequireHttpsMetadata=false;
                    option.TokenValidationParameters=new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                            
                    };
                    });
>>>>>>> ca769fb27606aa36dbaac9c6d301a410f1699e80
        }
    }
}