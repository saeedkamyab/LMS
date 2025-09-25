using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Identity.PhoneNumber
{
    public class CreatePhoneNumberRequest : IRequest<BaseCommandResponse>
    {
        public required PhoneNumberDto PhoneNumberDto { get; set; }
    }
}
