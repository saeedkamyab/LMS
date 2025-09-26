using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Handlers.Identity.Teacher.Requests
{
    public class CreateTeacherRequest : IRequest<BaseCommandResponse>
    {
        public required TeacherDto TeacherDto { get; set; }
    }
}
