using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Infrastructure.Context;
using ERP_Dashboard.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace ERP_Dashboard.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepositoryAsync<Customer>, ICustomerRepository
    {
        #region Fields
        private readonly DbSet<Customer> _customers;
        #endregion

        #region Constructors
        public CustomerRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _customers = dBContext.Set<Customer>();
        }
        #endregion
    }
}
