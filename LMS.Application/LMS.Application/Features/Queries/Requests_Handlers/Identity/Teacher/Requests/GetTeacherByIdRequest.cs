using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Teacher.Requests
{
    public class GetTeacherByIdRequest:IRequest<TeacherDto>
    {
        public Guid Id { get; set; }
    }
}
