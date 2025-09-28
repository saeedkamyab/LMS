using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.Register.Requests
{
    public class GetRegisterListRequest:IRequest<List<RegisterDto>>
    {

    }
}
