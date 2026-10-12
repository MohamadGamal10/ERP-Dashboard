using ERP_Dashboard.Core.Features.Categories.Queries.Results;
using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Core.Mapping.Categories
{
    public partial class CategoryProfile
    {
        public void GetCategoryByIdMapping()
        {
            CreateMap<Category, GetCategoryByIdResponse>();
        }
    }
}
