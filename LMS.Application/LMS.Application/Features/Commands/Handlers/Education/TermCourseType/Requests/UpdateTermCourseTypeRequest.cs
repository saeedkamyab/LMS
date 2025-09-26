using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Education.TermCourseType.Requests
{
    public class UpdateTermCourseTypeRequest : IRequest<BaseCommandResponse>
    {
        public required TermCourseTypeDto TermCourseTypeDto { get; set; }
    }
}
