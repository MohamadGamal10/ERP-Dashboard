using ERP_Dashboard.Api.Base;
using ERP_Dashboard.Core.Features.Suppliers.Commands;
using ERP_Dashboard.Core.Features.Suppliers.Queries.Models;
using ERP_Dashboard.Data.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Dashboard.Api.Controllers
{
    [ApiController]
    public class SupplierController : AppControllerBase
    {
        [HttpGet(Router.SupplierRouting.getAll)]
        public async Task<IActionResult> GetAll()
        {
            var response = await Mediator.Send(new GetSupplierListQuery());
            return Ok(response);
        }

        [HttpGet(Router.SupplierRouting.getById)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await Mediator.Send(new GetSupplierByIdQuery { Id = id });
            return Ok(response);
        }

        [HttpPost(Router.SupplierRouting.create)]
        public async Task<IActionResult> Create([FromBody] CreateSupplierCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpPut(Router.SupplierRouting.edit)]
        public async Task<IActionResult> Edit([FromBody] EditSupplierCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpDelete(Router.SupplierRouting.delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await Mediator.Send(new DeleteSupplierCommand { Id = id });
            return NewResult(response);
        }
    }
}
