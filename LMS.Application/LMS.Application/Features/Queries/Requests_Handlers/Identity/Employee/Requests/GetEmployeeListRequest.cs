using LMS.Application.Dtos.Identity;
using MediatR;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Employee.Requests
{
    public class GetEmployeeListRequest:IRequest<List<EmployeeDto>>
    {

    }
}
