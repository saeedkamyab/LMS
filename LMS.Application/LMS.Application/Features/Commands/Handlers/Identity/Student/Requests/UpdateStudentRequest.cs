using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.Student.Requests
{
    public class UpdateStudentRequest : IRequest<BaseCommandResponse>
    {
        public required StudentDto StudentDto { get; set; }
    }
}
