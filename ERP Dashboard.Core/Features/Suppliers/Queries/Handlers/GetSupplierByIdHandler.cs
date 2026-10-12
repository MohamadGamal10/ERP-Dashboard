using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Models;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Results;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Queries.Handlers
{
    public class GetSupplierByIdHandler : ResponseHandler,
                                          IRequestHandler<GetSupplierByIdQuery, Response<GetSupplierByIdResponse>>
    {
        private readonly ISupplierService _supplierService;
        private readonly IMapper _mapper;

        public GetSupplierByIdHandler(ISupplierService supplierService, IMapper mapper)
        {
            _supplierService = supplierService;
            _mapper = mapper;
        }

        public async Task<Response<GetSupplierByIdResponse>> Handle(GetSupplierByIdQuery request, CancellationToken cancellationToken)
        {
            var supplier = await _supplierService.GetByIdAsync(request.Id);
            if (supplier == null) return NotFound<GetSupplierByIdResponse>("Supplier not found");
            var mapped = _mapper.Map<GetSupplierByIdResponse>(supplier);
            return Success(mapped);
        }
    }
}
