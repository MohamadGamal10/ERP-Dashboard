using ERP_Dashboard.Api.Base;
using ERP_Dashboard.Core.Features.Categories.Commands;
using ERP_Dashboard.Core.Features.Categories.Queries.Models;
using ERP_Dashboard.Data.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Dashboard.Api.Controllers
{
    [ApiController]
    public class CategoryController : AppControllerBase
    {
        [HttpGet(Router.CategoryRouting.getAll)]
        public async Task<IActionResult> GetAll()
        {
            var response = await Mediator.Send(new GetCategoryListQuery());
            return NewResult(response);
        }

        [HttpGet(Router.CategoryRouting.getById)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await Mediator.Send(new GetCategoryByIdQuery { Id = id });
            return NewResult(response);
        }

        [HttpPost(Router.CategoryRouting.create)]
        public async Task<IActionResult> Create([FromBody] CreateCategoryCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpPut(Router.CategoryRouting.edit)]
        public async Task<IActionResult> Edit([FromBody] EditCategoryCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpDelete(Router.CategoryRouting.delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await Mediator.Send(new DeleteCategoryCommand { Id = id });
            return NewResult(response);
        }
    }
}
