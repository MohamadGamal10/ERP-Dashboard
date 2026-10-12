using ERP_Dashboard.Core.Bases;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Commands
{
    public class DeleteSupplierCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
