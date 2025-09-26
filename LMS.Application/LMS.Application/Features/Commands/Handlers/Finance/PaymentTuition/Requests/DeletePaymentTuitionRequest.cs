using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Finance;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Finance.PaymentTuition.Requests
{
    public class DeletePaymentTuitionRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
