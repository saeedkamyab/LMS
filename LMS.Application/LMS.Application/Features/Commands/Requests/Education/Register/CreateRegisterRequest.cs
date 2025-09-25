using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Education.Register
{
    public class CreateRegisterRequest : IRequest<BaseCommandResponse>
    {
        public required RegisterDto RegisterDto { get; set; }
    }
}
