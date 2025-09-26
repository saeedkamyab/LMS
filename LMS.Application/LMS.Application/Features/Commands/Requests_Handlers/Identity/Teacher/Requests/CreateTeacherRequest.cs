using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.Teacher.Requests
{
    public class CreateTeacherRequest : IRequest<BaseCommandResponse>
    {
        public required TeacherDto TeacherDto { get; set; }
    }
}
