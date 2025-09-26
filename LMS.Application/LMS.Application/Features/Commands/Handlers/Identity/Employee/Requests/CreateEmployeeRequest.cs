using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Handlers.Identity.Employee.Requests
{
    public class CreateEmployeeRequest : IRequest<BaseCommandResponse>
    {
        public required EmployeeDto EmployeeDto { get; set; }
    }
}
