using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Finance;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Finance.PaymentTuition
{
    public class UpdatePaymentTuitionRequest : IRequest<BaseCommandResponse>
    {
        public required PaymentTuitionDto PaymentTuitionDto { get; set; }
    }
}
