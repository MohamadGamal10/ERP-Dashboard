using AutoMapper;
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
        private readonly IMapper _mapper;

        public CustomerQueryHandler(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        public async Task<Response<List<GetCustomerListResponse>>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customerService.GetCustomersListAsync();
            var customersMapping = _mapper.Map<List<GetCustomerListResponse>>(customers);
            var result = Success(customersMapping);
            return result;
        }
    }
}
