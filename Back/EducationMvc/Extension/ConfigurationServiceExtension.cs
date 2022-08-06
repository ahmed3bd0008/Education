using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation;
using Repository.Interface;
using Services.Implemetation;
using Services.Interface;

namespace TestApplication.Extension
{
    public static class ConfigurationServiceExtension
    {
         public static void configurationRepositoryMethod(this IServiceCollection services)
        {
             services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IUntityOfWork),typeof(UntityOfWork));
        }
        public static void configurationServicesMethod(this IServiceCollection services)
        {
            services.AddScoped(typeof(IExamModalService),typeof(ExamModalService));

        }
    }
}