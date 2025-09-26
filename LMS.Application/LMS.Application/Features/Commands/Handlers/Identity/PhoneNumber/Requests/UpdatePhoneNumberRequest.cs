using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.PhoneNumber.Requests
{
    public class UpdatePhoneNumberRequest : IRequest<BaseCommandResponse>
    {
        public required PhoneNumberDto PhoneNumberDto { get; set; }
    }
}
