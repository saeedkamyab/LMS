using LMS.Application.Dtos.Common;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Finance.PaymentTuition.Requests
{
    public class DeletePaymentTuitionRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
