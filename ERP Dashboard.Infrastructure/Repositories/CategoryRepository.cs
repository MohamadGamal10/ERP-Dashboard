using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Infrastructure.Context;
using ERP_Dashboard.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace ERP_Dashboard.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepositoryAsync<Category>, ICategoryRepository
    {
        private readonly DbSet<Category> _categories;

        public CategoryRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _categories = dbContext.Set<Category>();
        }
    }
}
