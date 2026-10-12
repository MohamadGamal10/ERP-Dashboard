using ERP_Dashboard.Core.Features.Suppliers.Commands;
using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Core.Mapping.Categories
{
    public partial class CategoryProfile
    {
        public void CreateSupplierMapping()
        {
            CreateMap<CreateSupplierCommand, Supplier>();
        }
    }
}
