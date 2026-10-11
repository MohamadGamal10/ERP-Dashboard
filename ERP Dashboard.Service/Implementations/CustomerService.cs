using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ERP_Dashboard.Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        #region Fields
        private readonly ICustomerRepository _customerRepository;
        #endregion

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<List<Customer>> GetCustomersListAsync()
        {
            var customers = await _customerRepository.GetTableNoTracking().ToListAsync();
            return customers;
        }
        public Task<Customer> GetByIDAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<string> AddAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
