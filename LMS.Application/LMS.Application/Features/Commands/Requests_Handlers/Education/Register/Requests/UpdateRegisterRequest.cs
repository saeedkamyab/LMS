using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.Register.Requests
{
    public class UpdateRegisterRequest : IRequest<BaseCommandResponse>
    {
        public required RegisterDto RegisterDto { get; set; }
    }
}
