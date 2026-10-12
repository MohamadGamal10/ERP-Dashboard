using AutoMapper;

namespace ERP_Dashboard.Core.Mapping.Categories
{
    public partial class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            // Category mappings
            GetCategoryListMapping();
            GetCategoryByIdMapping();
            CreateCategoryMapping();
            EditCategoryMapping();

            // Supplier mappings
            GetSupplierListMapping();
            GetSupplierByIdMapping();
            CreateSupplierMapping();
            EditSupplierMapping();
        }
    }
}
