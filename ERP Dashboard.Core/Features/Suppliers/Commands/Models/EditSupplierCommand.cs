using ERP_Dashboard.Core.Bases;
using MediatR;

namespace ERP_Dashboard.Core.Features.Suppliers.Commands
{
    public class EditSupplierCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PaymentTerms { get; set; }
    }
}
