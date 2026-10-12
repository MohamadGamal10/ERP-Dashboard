using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Customers.Queries.Results;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Queries.Models
{
    public class GetCustomerByIdQuery : IRequest<Response<GetCustomerByIdResponse>>
    {
        public int Id { get; set; }
    }
}
