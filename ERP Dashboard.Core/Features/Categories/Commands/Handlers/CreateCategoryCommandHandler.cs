using AutoMapper;
using ERP_Dashboard.Core.Bases;
using ERP_Dashboard.Core.Features.Categories.Commands;
using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Service.Abstracts;
using MediatR;

namespace ERP_Dashboard.Core.Features.Categories.Commands.Handlers
{
    public class CreateCategoryCommandHandler : ResponseHandler,
                                                 IRequestHandler<CreateCategoryCommand, Response<string>>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Category>(request);
            var result = await _categoryService.AddAsync(entity);
            return Created(result);
        }
    }
}
