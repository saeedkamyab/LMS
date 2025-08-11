using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests.Education.Level
{
    public class GetLevelByIdRequest:IRequest<LevelDto>
    {
        public Guid Id { get; set; }
    }
}
