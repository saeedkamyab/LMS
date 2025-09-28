using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Teacher.Requests
{
    public class GetTeacherListRequest:IRequest<List<TeacherDto>>
    {

    }
}
