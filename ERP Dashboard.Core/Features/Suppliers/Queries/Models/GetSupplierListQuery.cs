using ERP_Dashboard.Core.Bases;
using MediatR;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Results;

namespace ERP_Dashboard.Core.Features.Suppliers.Queries.Models
{
    public class GetSupplierListQuery : IRequest<Response<List<GetSupplierListResponse>>>
    {
    }
}
