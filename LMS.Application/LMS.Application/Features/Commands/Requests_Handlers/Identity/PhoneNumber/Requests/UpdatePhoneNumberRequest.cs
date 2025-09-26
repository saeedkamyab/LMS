using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.PhoneNumber.Requests
{
    public class UpdatePhoneNumberRequest : IRequest<BaseCommandResponse>
    {
        public required PhoneNumberDto PhoneNumberDto { get; set; }
    }
}
