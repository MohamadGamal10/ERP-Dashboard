using ERP_Dashboard.Core.Bases;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Commands
{
    public class CreateCategoryCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }
    }
}
