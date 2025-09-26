using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.PhoneNumber.Requests
{
    public class DeletePhoneNumberRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
