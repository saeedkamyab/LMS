using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Handlers.Education.Level.Requests
{
    public class CreateLevelRequest : IRequest<BaseCommandResponse>
    {
        public required LevelDto LevelDto { get; set; }
    }
}
