using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.Employee.Requests
{
    public class DeleteEmployeeRequest : IRequest<BaseCommandResponse>
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
