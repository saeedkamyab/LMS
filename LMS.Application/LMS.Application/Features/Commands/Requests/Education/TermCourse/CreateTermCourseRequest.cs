using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Education.TermCourse
{
    public class CreateTermCourseRequest : IRequest<BaseCommandResponse>
    {
        public required TermCourseDto TermCourseDto { get; set; }
    }
}
