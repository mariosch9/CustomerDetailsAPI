using CustomerDetails.Repositories;

namespace CustomerDetails.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICustomersRepository, CustomersRepository>();

            return services;
        }
    }
}
