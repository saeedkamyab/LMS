using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.Level.Requests
{
    public class UpdateLevelRequest : IRequest<BaseCommandResponse>
    {
        public required LevelDto LevelDto { get; set; }
    }
}
