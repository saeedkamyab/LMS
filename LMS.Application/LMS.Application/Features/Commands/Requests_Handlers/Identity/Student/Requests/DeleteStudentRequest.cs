using LMS.Application.Dtos.Common;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.Student.Requests
{
    public class DeleteStudentRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
