using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Customers.Queries.Models;
using ERP_Dashboard.Core.Features.Customers.Queries.Results;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Queries.Handlers
{
    public class GetCustomerByIdHandler : ResponseHandler,
                                          IRequestHandler<GetCustomerByIdQuery, Response<GetCustomerByIdResponse>>
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public GetCustomerByIdHandler(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<Response<GetCustomerByIdResponse>> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerService.GetByIDAsync(request.Id);
            if (customer == null)
                return NotFound<GetCustomerByIdResponse>("Customer not found");

            var mapped = _mapper.Map<GetCustomerByIdResponse>(customer);
            return Success(mapped);
        }
    }
}
