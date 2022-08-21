using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace EducationMvc.Extension
{
    public static class ConfigurationAuthenticationScheme
    {
       
        public static void AddAuthenticationConfig(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddAuthentication(Option=>{
                Option.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultScheme=JwtBearerDefaults.AuthenticationScheme;
                Option.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
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
        }
    }
}