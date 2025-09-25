using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Education.TermCourse
{
    public class UpdateTermCourseRequest : IRequest<BaseCommandResponse>
    {
        public required TermCourseDto TermCourseDto { get; set; }
    }
}
