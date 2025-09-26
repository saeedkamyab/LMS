using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Finance;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Handlers.Finance.PaymentTuition.Requests
{
    public class CreatePaymentTuitionRequest : IRequest<BaseCommandResponse>
    {
        public required PaymentTuitionDto PaymentTuitionDto { get; set; }
    }
}
