using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Customers.Commands;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Customers.Commands.Handlers
{
    public class DeleteCustomerCommandHandler : ResponseHandler,
                                                IRequestHandler<DeleteCustomerCommand, Response<string>>
    {
        private readonly ICustomerService _customerService;

        public DeleteCustomerCommandHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<Response<string>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var existing = await _customerService.GetByIDAsync(request.Id);
            if (existing == null)
                return NotFound<string>("Customer not found");

            var result = await _customerService.DeleteAsync(existing);
            return Success(result);
        }
    }
}
