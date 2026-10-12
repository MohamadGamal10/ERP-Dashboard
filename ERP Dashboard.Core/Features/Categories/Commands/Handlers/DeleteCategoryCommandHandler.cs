using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Categories.Commands;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Commands.Handlers
{
    public class DeleteCategoryCommandHandler : ResponseHandler,
                                                 IRequestHandler<DeleteCategoryCommand, Response<string>>
    {
        private readonly ICategoryService _categoryService;

        public DeleteCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<Response<string>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var existing = await _categoryService.GetByIdAsync(request.Id);
            if (existing == null) return NotFound<string>("Category not found");
            var result = await _categoryService.DeleteAsync(existing);
            return Success(result);
        }
    }
}
