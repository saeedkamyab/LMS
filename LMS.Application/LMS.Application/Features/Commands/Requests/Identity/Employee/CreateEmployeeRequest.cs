using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Features.Commands.Requests.Identity.Employee
{
    public class CreateEmployeeRequest : IRequest<BaseCommandResponse>
    {
        public required EmployeeDto EmployeeDto { get; set; }
    }
}
