using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Identity.Teacher
{
    public class CreateTeacherRequest : IRequest<BaseCommandResponse>
    {
        public required TeacherDto TeacherDto { get; set; }
    }
}
