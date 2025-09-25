using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Finance;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Finance.PaymentTuition
{
    public class DeletePaymentTuitionRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
