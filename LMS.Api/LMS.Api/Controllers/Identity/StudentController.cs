using LMS.Application.Features.Queries.Requests_Handlers.Identity.Student.Requests;
using LMS.Application.Dtos.Identity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Identity.Student.Requests;
using Azure;
namespace LMS.Api.Controllers.Identity
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetStudentListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetStudentByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] StudentDto Student)
        {
            var command = new CreateStudentRequest { StudentDto = Student };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StudentDto Student)
        {
            var command = new UpdateStudentRequest { StudentDto = Student };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteStudentRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
