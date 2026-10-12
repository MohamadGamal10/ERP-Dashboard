using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Suppliers.Commands;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Commands.Handlers
{
    public class EditSupplierCommandHandler : ResponseHandler,
                                               IRequestHandler<EditSupplierCommand, Response<string>>
    {
        private readonly ISupplierService _supplierService;
        private readonly IMapper _mapper;

        public EditSupplierCommandHandler(ISupplierService supplierService, IMapper mapper)
        {
            _supplierService = supplierService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(EditSupplierCommand request, CancellationToken cancellationToken)
        {
            var existing = await _supplierService.GetByIdAsync(request.Id);
            if (existing == null) return NotFound<string>("Supplier not found");
            var updated = _mapper.Map(request, existing);
            var result = await _supplierService.EditAsync(updated);
            return Success(result);
        }
    }
}
