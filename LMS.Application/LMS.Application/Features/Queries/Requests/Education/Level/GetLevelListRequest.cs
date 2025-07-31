using LMS.ApplicationCore.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Requests.Education.Level
{
    public class GetLevelListRequest:IRequest<List<LevelDto>>
    {

    }
}
