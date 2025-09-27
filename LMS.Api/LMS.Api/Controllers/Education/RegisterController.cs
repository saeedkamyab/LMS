using LMS.Application.Features.Queries.Requests_Handlers.Education.Register.Requests;
using LMS.Application.Dtos.Education;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Education.Register.Requests;
using Azure;
namespace LMS.Api.Controllers.Education
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetRegisterListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RegisterDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetRegisterByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] RegisterDto Register)
        {
            var command = new CreateRegisterRequest { RegisterDto = Register };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] RegisterDto Register)
        {
            var command = new UpdateRegisterRequest { RegisterDto = Register };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteRegisterRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
