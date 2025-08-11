using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Education.Level
{
    public class CreateLevelRequest : IRequest<LevelDto>
    {
        public LevelDto LevelDto { get; set; }
    }
}
