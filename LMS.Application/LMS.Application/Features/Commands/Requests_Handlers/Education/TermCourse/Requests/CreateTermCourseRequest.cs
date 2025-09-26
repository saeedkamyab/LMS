using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourse.Requests
{
    public class CreateTermCourseRequest : IRequest<BaseCommandResponse>
    {
        public required TermCourseDto TermCourseDto { get; set; }
    }
}
