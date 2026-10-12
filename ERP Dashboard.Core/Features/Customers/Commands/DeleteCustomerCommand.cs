using ERP_Dashboard.Core.Bases;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Commands
{
    public class DeleteCustomerCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
