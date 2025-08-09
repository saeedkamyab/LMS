using LMS.Application.Features.Queries.Requests.Education.Level;
using LMS.ApplicationCore.Dtos.Education;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace LMS.Api.Controllers.Education
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public LevelController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetLevelListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<LevelDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetLevelByIdRequest { Id = id });
            return result;
        }

        //[HttpPost]
        //public async Task<ActionResult> Create([FromBody] CreateStudent createStudent)
        //{
        //    var command = new CreateStudentCommandRequest { CreateStudentDto = createStudent };
        //    var response = await _mediator.Send(command);
        //    return Ok(response);
        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult> Put(Guid id, [FromBody] UpdateStudentDto updateStudentDto)
        //{
        //    var command = new UpdateStudentCommandRequest { Id = id, UpdateStudentDto = updateStudentDto };
        //    await _mediator.Send(command);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(Guid id)
        //{
        //    var command = new DeleteStudentRequestCommand { Id = id };
        //    await _mediator.Send(command);
        //    return NoContent();
        //}

    }
}
