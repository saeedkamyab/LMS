using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Education.TermCourse.Requests
{
    public class DeleteTermCourseRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
