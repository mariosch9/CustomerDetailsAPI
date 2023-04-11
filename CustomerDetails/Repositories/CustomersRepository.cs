using CustomerDetails.Data;
using CustomerDetails.Models;

namespace CustomerDetails.Repositories
{
    public class CustomersRepository : BaseRepository<Customers>, ICustomersRepository
    {
        public CustomersRepository(CustomerDetailsContext dbContext) : base(dbContext)
        {
        }
    }
}
