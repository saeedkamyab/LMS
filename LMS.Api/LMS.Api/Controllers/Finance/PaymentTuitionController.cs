using LMS.Application.Features.Queries.Requests_Handlers.Finance.PaymentTuition.Requests;
using LMS.Application.Dtos.Finance;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LMS.Application.Features.Commands.Requests_Handlers.Finance.PaymentTuition.Requests;
using Azure;
namespace LMS.Api.Controllers.Finance
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTuitionController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public PaymentTuitionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetPaymentTuitionListRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentTuitionDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetPaymentTuitionByIdRequest { Id = id });
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PaymentTuitionDto PaymentTuition)
        {
            var command = new CreatePaymentTuitionRequest { PaymentTuitionDto = PaymentTuition };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] PaymentTuitionDto PaymentTuition)
        {
            var command = new UpdatePaymentTuitionRequest { PaymentTuitionDto = PaymentTuition };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeletePaymentTuitionRequest { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
