using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Education.Level
{
    public class CreateLevelRequest : IRequest<BaseCommandResponse>
    {
        public required LevelDto LevelDto { get; set; }
    }
}
