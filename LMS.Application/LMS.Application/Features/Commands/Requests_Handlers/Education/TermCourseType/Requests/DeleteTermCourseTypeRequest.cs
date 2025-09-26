using LMS.Application.Dtos.Common;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourseType.Requests
{
    public class DeleteTermCourseTypeRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
