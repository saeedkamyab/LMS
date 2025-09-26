using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.Teacher.Requests
{
    public class UpdateTeacherRequest : IRequest<BaseCommandResponse>
    {
        public required TeacherDto TeacherDto { get; set; }
    }
}
