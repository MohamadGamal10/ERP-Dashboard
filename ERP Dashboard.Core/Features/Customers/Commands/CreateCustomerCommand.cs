using ERP_Dashboard.Core.Bases;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Commands
{
    public class CreateCustomerCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TaxId { get; set; }
    }
}
