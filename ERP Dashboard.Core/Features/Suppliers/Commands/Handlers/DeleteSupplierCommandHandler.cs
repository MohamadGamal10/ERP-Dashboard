using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Suppliers.Commands;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Commands.Handlers
{
    public class DeleteSupplierCommandHandler : ResponseHandler,
                                                 IRequestHandler<DeleteSupplierCommand, Response<string>>
    {
        private readonly ISupplierService _supplierService;

        public DeleteSupplierCommandHandler(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public async Task<Response<string>> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var existing = await _supplierService.GetByIdAsync(request.Id);
            if (existing == null) return NotFound<string>("Supplier not found");
            var result = await _supplierService.DeleteAsync(existing);
            return Success(result);
        }
    }
}
