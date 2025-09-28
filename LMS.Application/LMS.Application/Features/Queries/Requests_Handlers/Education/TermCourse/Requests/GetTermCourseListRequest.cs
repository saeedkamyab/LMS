using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourse.Requests
{
    public class GetTermCourseListRequest:IRequest<List<TermCourseDto>>
    {

    }
}
