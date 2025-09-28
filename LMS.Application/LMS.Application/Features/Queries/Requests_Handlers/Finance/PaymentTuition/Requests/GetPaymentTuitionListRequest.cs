using LMS.Application.Dtos.Finance;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Finance.PaymentTuition.Requests
{
    public class GetPaymentTuitionListRequest:IRequest<List<PaymentTuitionDto>>
    {

    }
}
