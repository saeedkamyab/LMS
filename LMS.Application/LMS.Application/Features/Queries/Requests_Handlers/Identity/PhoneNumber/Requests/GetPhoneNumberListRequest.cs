using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.PhoneNumber.Requests
{
    public class GetPhoneNumberListRequest:IRequest<List<PhoneNumberDto>>
    {

    }
}
