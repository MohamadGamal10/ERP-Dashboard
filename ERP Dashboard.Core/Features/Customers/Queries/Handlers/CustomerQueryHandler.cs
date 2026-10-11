using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Customers.Queries.Models;
using ERP_Dashboard.Core.Features.Customers.Queries.Results;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Queries.Handlers
{
    public class CustomerQueryHandler : ResponseHandler,
                                       IRequestHandler<GetCustomerListQuery, Response<List<GetCustomerListResponse>>>
    {
        private readonly ICustomerService _customerService;

        public CustomerQueryHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public Task<Response<List<GetCustomerListResponse>>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
