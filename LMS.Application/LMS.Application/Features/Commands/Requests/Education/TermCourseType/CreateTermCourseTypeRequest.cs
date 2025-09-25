using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Education.TermCourseType
{
    public class CreateTermCourseTypeRequest : IRequest<BaseCommandResponse>
    {
        public required TermCourseTypeDto TermCourseTypeDto { get; set; }
    }
}
