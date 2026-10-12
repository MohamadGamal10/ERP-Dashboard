using ERP_Dashboard.Core.Features.Customers.Commands;
using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Core.Mapping.Customers
{
    public partial class CustomerProfile
    {
        public void CreateCustomerMapping()
        {
            CreateMap<CreateCustomerCommand, Customer>();
        }
    }
}
