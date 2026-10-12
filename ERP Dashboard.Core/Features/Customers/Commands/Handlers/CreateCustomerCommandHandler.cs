using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Customers.Commands;
using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Commands.Handlers
{
    public class CreateCustomerCommandHandler : ResponseHandler,
                                                IRequestHandler<CreateCustomerCommand, Response<string>>
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request);
            var result = await _customerService.AddAsync(customer);
            return Created(result);
        }
    }
}
