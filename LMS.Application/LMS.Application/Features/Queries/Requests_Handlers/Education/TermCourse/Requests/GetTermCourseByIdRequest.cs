using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourse.Requests
{
    public class GetTermCourseByIdRequest:IRequest<TermCourseDto>
    {
        public Guid Id { get; set; }
    }
}
