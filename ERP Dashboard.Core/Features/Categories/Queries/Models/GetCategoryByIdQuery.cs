using ERP_Dashboard.Core.Bases;
using MediatR;
using ERP_Dashboard.Core.Features.Categories.Queries.Results;

namespace ERP_Dashboard.Core.Features.Categories.Queries.Models
{
    public class GetCategoryByIdQuery : IRequest<Response<GetCategoryByIdResponse>>
    {
        public int Id { get; set; }
    }
}
