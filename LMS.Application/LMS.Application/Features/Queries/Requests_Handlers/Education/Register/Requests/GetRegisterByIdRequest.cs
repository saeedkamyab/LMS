using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.Register.Requests
{
    public class GetRegisterByIdRequest:IRequest<RegisterDto>
    {
        public Guid Id { get; set; }
    }
}
