using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.Employee.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Employee
{
    public class GetEmployeeListRequestHandler : IRequestHandler<GetEmployeeListRequest, List<EmployeeDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetEmployeeListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<EmployeeDto>> Handle(GetEmployeeListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var EmployeeList = await _unitofwork.EmployeeRepository.GetAllAsync();
                return _mapper.Map<List<EmployeeDto>>(EmployeeList);
            }
            catch
            {
                throw;
            }
        }
    }
}
