using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.InfrastructureBases;

namespace ERP_Dashboard.Infrastructure.Abstracts
{
    public interface ICustomerRepository : IGenericRepositoryAsync<Customer>
    {
    }
}
