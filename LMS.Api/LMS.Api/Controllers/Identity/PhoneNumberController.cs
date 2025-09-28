using LMS.Application.Features.Queries.Requests_Handlers.Identity.PhoneNumber.Requests;
using LMS.Application.Dtos.Identity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Identity.PhoneNumber.Requests;
using Azure;
namespace LMS.Api.Controllers.Identity
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public PhoneNumberController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetPhoneNumberListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PhoneNumberDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetPhoneNumberByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PhoneNumberDto PhoneNumber)
        {
            var command = new CreatePhoneNumberRequest { PhoneNumberDto = PhoneNumber };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] PhoneNumberDto PhoneNumber)
        {
            var command = new UpdatePhoneNumberRequest { PhoneNumberDto = PhoneNumber };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeletePhoneNumberRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
