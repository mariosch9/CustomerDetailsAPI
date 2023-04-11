using CustomerDetails.Models;
using Microsoft.EntityFrameworkCore;
namespace CustomerDetails.Data
{
    public class CustomerDetailsContext : DbContext
    {
        public CustomerDetailsContext(DbContextOptions<CustomerDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }
    }
}
