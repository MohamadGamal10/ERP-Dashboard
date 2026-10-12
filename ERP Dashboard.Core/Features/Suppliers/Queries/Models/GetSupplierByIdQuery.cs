using ERP_Dashboard.Core.Bases;
using MediatR;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Results;

namespace ERP_Dashboard.Core.Features.Suppliers.Queries.Models
{
    public class GetSupplierByIdQuery : IRequest<Response<GetSupplierByIdResponse>>
    {
        public int Id { get; set; }
    }
}
