using LMS.Application.Features.Queries.Requests_Handlers.Education.Level.Requests;
using LMS.Application.Dtos.Education;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Education.Level.Requests;
using Azure;
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
        /// <summary>
        /// گرفتن لیست تمام کاربران
        /// </summary>
        /// <remarks>
        /// مثال:
        /// GET /api/users
        /// </remarks>
        /// <response code="200">لیست کاربران با موفقیت برگشت داده شد</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
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

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] LevelDto level)
        {
            var command = new CreateLevelRequest { LevelDto = level };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] LevelDto level)
        {
            var command = new UpdateLevelRequest { LevelDto = level };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteLevelRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
