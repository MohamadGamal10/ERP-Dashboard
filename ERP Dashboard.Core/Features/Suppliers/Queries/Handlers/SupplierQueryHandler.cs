using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Models;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Results;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Queries.Handlers
{
    public class SupplierQueryHandler : ResponseHandler,
                                         IRequestHandler<GetSupplierListQuery, Response<List<GetSupplierListResponse>>>
    {
        private readonly ISupplierService _supplierService;
        private readonly IMapper _mapper;

        public SupplierQueryHandler(ISupplierService supplierService, IMapper mapper)
        {
            _supplierService = supplierService;
            _mapper = mapper;
        }

        public async Task<Response<List<GetSupplierListResponse>>> Handle(GetSupplierListQuery request, CancellationToken cancellationToken)
        {
            var suppliers = await _supplierService.GetSuppliersAsync();
            var mapped = _mapper.Map<List<GetSupplierListResponse>>(suppliers);
            return Success(mapped);
        }
    }
}
