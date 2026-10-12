using ERP_Dashboard.Core.Features.Customers.Queries.Results;
using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Core.Mapping.Customers
{
    public partial class CustomerProfile
    {
        public void GetCustomerListMapping()
        {
            CreateMap<Customer, GetCustomerListResponse>();
        }
    }
}
