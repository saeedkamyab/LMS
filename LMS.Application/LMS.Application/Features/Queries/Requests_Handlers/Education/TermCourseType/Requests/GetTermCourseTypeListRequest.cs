using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType.Requests
{
    public class GetTermCourseTypeListRequest:IRequest<List<TermCourseTypeDto>>
    {

    }
}
