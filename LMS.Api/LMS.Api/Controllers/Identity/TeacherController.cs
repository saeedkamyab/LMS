using LMS.Application.Features.Queries.Requests_Handlers.Education.Teacher.Requests;
using LMS.Application.Dtos.Education;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Education.Teacher.Requests;
using Azure;
namespace LMS.Api.Controllers.Education
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public TeacherController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetTeacherListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetTeacherByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TeacherDto Teacher)
        {
            var command = new CreateTeacherRequest { TeacherDto = Teacher };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] TeacherDto Teacher)
        {
            var command = new UpdateTeacherRequest { TeacherDto = Teacher };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteTeacherRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
