using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Finance;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Finance.PaymentTuition
{
    public class CreatePaymentTuitionRequest : IRequest<BaseCommandResponse>
    {
        public required PaymentTuitionDto PaymentTuitionDto { get; set; }
    }
}
