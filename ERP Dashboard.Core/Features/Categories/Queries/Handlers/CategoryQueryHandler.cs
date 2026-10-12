using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Categories.Queries.Models;
using ERP_Dashboard.Core.Features.Categories.Queries.Results;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Queries.Handlers
{
    public class CategoryQueryHandler : ResponseHandler,
                                        IRequestHandler<GetCategoryListQuery, Response<List<GetCategoryListResponse>>>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryQueryHandler(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<Response<List<GetCategoryListResponse>>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var mapped = _mapper.Map<List<GetCategoryListResponse>>(categories);
            return Success(mapped);
        }
    }
}
