using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Service.Abstracts
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetCustomersListAsync();
        public Task<Customer> GetByIDAsync(int id);
        public Task<string> AddAsync(Customer customer);
        public Task<string> EditAsync(Customer customer);
        public Task<string> DeleteAsync(Customer customer);
    }
}
