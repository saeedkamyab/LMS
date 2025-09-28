using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType.Requests
{
    public class GetTermCourseTypeByIdRequest:IRequest<TermCourseTypeDto>
    {
        public Guid Id { get; set; }
    }
}
