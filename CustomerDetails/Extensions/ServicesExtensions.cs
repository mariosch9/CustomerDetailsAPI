using CustomerDetails.Models;
using CustomerDetails.Services;

namespace CustomerDetails.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IService<Customers>, CustomersService>();
            
            return services;
        }
    }
}
