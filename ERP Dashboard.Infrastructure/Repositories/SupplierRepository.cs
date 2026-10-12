using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Infrastructure.Context;
using ERP_Dashboard.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace ERP_Dashboard.Infrastructure.Repositories
{
    public class SupplierRepository : GenericRepositoryAsync<Supplier>, ISupplierRepository
    {
        private readonly DbSet<Supplier> _suppliers;

        public SupplierRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _suppliers = dbContext.Set<Supplier>();
        }
    }
}
