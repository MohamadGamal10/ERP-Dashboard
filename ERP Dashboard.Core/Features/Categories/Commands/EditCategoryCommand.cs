using ERP_Dashboard.Core.Bases;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Commands
{
    public class EditCategoryCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
