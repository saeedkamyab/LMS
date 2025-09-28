using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Employee.Requests
{
    public class GetEmployeeByIdRequest:IRequest<EmployeeDto>
    {
        public Guid Id { get; set; }
    }
}
