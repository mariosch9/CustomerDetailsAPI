using CustomerDetails.Models;
using CustomerDetails.Repositories;
using System.Reflection;

namespace CustomerDetails.Services
{
    public class CustomersService : IService<Customers>
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        public async Task<List<Customers>> GetAsync()
        {
            return await _customersRepository.GetAsync();
        }

        public async Task<Customers> GetByIdAsync(int id, bool log = true)
        {
            var customer = await _customersRepository.GetByIdAsync(id);
            if (customer == null)
            {
                return null;
            }
            if (!log)
            {
                return customer;
            }
            return customer;
        }

        public async Task UpdateAsync(Customers customer, bool log = true)
        {
            await _customersRepository.UpdateAsync(customer);
            if (!log)
            {
                return;
            }
        }

        public async Task DeleteAsync(Customers customer, bool log = true)
        {
            await _customersRepository.DeleteAsync(customer);
            if (!log)
            {
                return;
            }
        }

        public async Task AddAsync(Customers customer, bool log = true)
        {
            await _customersRepository.AddAsync(customer);
            if (!log)
            {
                return;
            }
        }
    }
}
