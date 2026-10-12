using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Suppliers.Commands;
using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Commands.Handlers
{
    public class CreateSupplierCommandHandler : ResponseHandler,
                                                 IRequestHandler<CreateSupplierCommand, Response<string>>
    {
        private readonly ISupplierService _supplierService;
        private readonly IMapper _mapper;

        public CreateSupplierCommandHandler(ISupplierService supplierService, IMapper mapper)
        {
            _supplierService = supplierService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Supplier>(request);
            var result = await _supplierService.AddAsync(entity);
            return Created(result);
        }
    }
}
