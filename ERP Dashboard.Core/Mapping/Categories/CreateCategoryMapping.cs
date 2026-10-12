using ERP_Dashboard.Core.Features.Categories.Commands;
using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Core.Mapping.Categories
{
    public partial class CategoryProfile
    {
        public void CreateCategoryMapping()
        {
            CreateMap<CreateCategoryCommand, Category>();
        }
    }
}
