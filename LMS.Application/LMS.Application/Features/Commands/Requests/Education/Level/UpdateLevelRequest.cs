using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Education.Level
{
    public class UpdateLevelRequest : IRequest<LevelDto>
    {
        public LevelDto LevelDto { get; set; }
    }
}
