using LMS.Application.Features.Queries.Requests_Handlers.Education.Employee.Requests;
using LMS.Application.Dtos.Education;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Education.Employee.Requests;
using Azure;
namespace LMS.Api.Controllers.Education
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetEmployeeListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetEmployeeByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] EmployeeDto Employee)
        {
            var command = new CreateEmployeeRequest { EmployeeDto = Employee };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] EmployeeDto Employee)
        {
            var command = new UpdateEmployeeRequest { EmployeeDto = Employee };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteEmployeeRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
