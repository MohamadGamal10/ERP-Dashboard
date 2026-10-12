using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Categories.Queries.Models;
using ERP_Dashboard.Core.Features.Categories.Queries.Results;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Queries.Handlers
{
    public class GetCategoryByIdHandler : ResponseHandler,
                                         IRequestHandler<GetCategoryByIdQuery, Response<GetCategoryByIdResponse>>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public GetCategoryByIdHandler(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<Response<GetCategoryByIdResponse>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryService.GetByIdAsync(request.Id);
            if (category == null) return NotFound<GetCategoryByIdResponse>("Category not found");
            var mapped = _mapper.Map<GetCategoryByIdResponse>(category);
            return Success(mapped);
        }
    }
}
