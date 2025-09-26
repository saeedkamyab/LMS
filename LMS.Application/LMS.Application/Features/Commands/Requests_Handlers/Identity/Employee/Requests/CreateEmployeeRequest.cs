using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.Employee.Requests
{
    public class CreateEmployeeRequest : IRequest<BaseCommandResponse>
    {
        public required EmployeeDto EmployeeDto { get; set; }
    }
}
