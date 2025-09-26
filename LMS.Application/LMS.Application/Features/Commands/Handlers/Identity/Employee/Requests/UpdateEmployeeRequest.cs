using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.Employee.Requests
{
    public class UpdateEmployeeRequest : IRequest<BaseCommandResponse>
    {
        public required EmployeeDto EmployeeDto { get; set; }
    }
}
