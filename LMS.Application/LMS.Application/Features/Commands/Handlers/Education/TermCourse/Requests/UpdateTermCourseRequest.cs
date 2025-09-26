using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Education.TermCourse.Requests
{
    public class UpdateTermCourseRequest : IRequest<BaseCommandResponse>
    {
        public required TermCourseDto TermCourseDto { get; set; }
    }
}
