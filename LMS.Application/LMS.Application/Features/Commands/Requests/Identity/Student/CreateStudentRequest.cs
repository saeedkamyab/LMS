using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Identity.Student
{
    public class CreateStudentRequest : IRequest<BaseCommandResponse>
    {
        public required StudentDto StudentDto { get; set; }
    }
}
