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
        public async Task<Customer> GetByIDAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }
        public async Task<string> AddAsync(Customer customer)
        {
            var added = await _customerRepository.AddAsync(customer);
            return added != null ? "Customer created successfully" : "Failed to create customer";
        }

        public Task<string> EditAsync(Customer customer)
        {
            return EditInternalAsync(customer);
        }
        private async Task<string> EditInternalAsync(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer);
            return "Customer updated successfully";
        }

        public Task<string> DeleteAsync(Customer customer)
        {
            return DeleteInternalAsync(customer);
        }

        private async Task<string> DeleteInternalAsync(Customer customer)
        {
            await _customerRepository.DeleteAsync(customer);
            return "Customer deleted successfully";
        }
    }
}
