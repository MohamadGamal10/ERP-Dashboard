using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Customers.Commands;
using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Commands.Handlers
{
    public class EditCustomerCommandHandler : ResponseHandler,
                                              IRequestHandler<EditCustomerCommand, Response<string>>
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public EditCustomerCommandHandler(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
        {
            var existing = await _customerService.GetByIDAsync(request.Id);
            if (existing == null)
                return NotFound<string>("Customer not found");

            var updated = _mapper.Map(request, existing);
            var result = await _customerService.EditAsync(updated);
            return Success(result);
        }
    }
}
