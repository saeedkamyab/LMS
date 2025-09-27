using LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType.Requests;
using LMS.Application.Dtos.Education;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourseType.Requests;
using Azure;
namespace LMS.Api.Controllers.Education
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermCourseTypeController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public TermCourseTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetTermCourseTypeListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TermCourseTypeDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetTermCourseTypeByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TermCourseTypeDto TermCourseType)
        {
            var command = new CreateTermCourseTypeRequest { TermCourseTypeDto = TermCourseType };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] TermCourseTypeDto TermCourseType)
        {
            var command = new UpdateTermCourseTypeRequest { TermCourseTypeDto = TermCourseType };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteTermCourseTypeRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
