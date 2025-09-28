using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Student.Requests
{
    public class GetStudentByIdRequest:IRequest<StudentDto>
    {
        public Guid Id { get; set; }
    }
}
