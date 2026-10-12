using AutoMapper;

namespace ERP_Dashboard.Core.Mapping.Customers
{
    public partial class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            GetCustomerListMapping();
            GetCustomerByIdMapping();
            CreateCustomerMapping();
            EditCustomerMapping();
        }
    }
}
