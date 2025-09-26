using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Handlers.Education.Level.Requests
{
    public class GetLevelByIdRequest:IRequest<LevelDto>
    {
        public Guid Id { get; set; }
    }
}
