using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.Teacher.Requests
{
    public class DeleteTeacherRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
