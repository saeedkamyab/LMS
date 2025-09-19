using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Requests.Education.Level
{
    public class DeleteLevelRequest : IRequest<LevelDto>
    {
        public bool IsDeleted { get; set; }
    }
}
