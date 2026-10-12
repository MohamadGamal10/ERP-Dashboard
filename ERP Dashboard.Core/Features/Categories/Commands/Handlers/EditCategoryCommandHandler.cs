using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Categories.Commands;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Commands.Handlers
{
    public class EditCategoryCommandHandler : ResponseHandler,
                                               IRequestHandler<EditCategoryCommand, Response<string>>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public EditCategoryCommandHandler(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(EditCategoryCommand request, CancellationToken cancellationToken)
        {
            var existing = await _categoryService.GetByIdAsync(request.Id);
            if (existing == null) return NotFound<string>("Category not found");
            var updated = _mapper.Map(request, existing);
            var result = await _categoryService.EditAsync(updated);
            return Success(result);
        }
    }
}
