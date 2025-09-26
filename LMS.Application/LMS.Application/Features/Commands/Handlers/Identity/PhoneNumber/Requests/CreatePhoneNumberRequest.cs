using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Handlers.Identity.PhoneNumber.Requests
{
    public class CreatePhoneNumberRequest : IRequest<BaseCommandResponse>
    {
        public required PhoneNumberDto PhoneNumberDto { get; set; }
    }
}
