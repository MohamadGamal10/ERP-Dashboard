using ERP_Dashboard.Api.Base;
using ERP_Dashboard.Core.Features.Customers.Queries.Models;
using ERP_Dashboard.Core.Features.Customers.Commands;
using ERP_Dashboard.Data.AppMetaData;
using Microsoft.AspNetCore.Mvc;


namespace ERP_Dashboard.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : AppControllerBase
    {
        [HttpGet(Router.CustomerRouting.getAll)]
        public async Task<IActionResult> GetAll()
        {
            var response = await Mediator.Send(new GetCustomerListQuery());
            return Ok(response);
        }

        [HttpGet(Router.CustomerRouting.getById)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await Mediator.Send(new GetCustomerByIdQuery { Id = id });
            return Ok(response);
        }

        [HttpPost(Router.CustomerRouting.create)]
        public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpPut(Router.CustomerRouting.edit)]
        public async Task<IActionResult> Edit([FromBody] EditCustomerCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpDelete(Router.CustomerRouting.delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await Mediator.Send(new DeleteCustomerCommand { Id = id });
            return NewResult(response);
        }
    }
}
