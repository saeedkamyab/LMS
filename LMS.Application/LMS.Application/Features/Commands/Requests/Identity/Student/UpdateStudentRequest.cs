using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Identity.Student
{
    public class UpdateStudentRequest : IRequest<BaseCommandResponse>
    {
        public required StudentDto StudentDto { get; set; }
    }
}
