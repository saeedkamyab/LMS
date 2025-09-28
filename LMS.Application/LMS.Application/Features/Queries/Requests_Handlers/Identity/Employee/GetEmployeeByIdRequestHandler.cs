using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.Employee.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Employee
{
    public class GetEmployeeByIdRequestHandler : IRequestHandler<GetEmployeeByIdRequest, EmployeeDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetEmployeeByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<EmployeeDto> Handle(GetEmployeeByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var Employee = await _unitofwork.EmployeeRepository.GetByIdAsync(request.Id);
                return _mapper.Map<EmployeeDto>(Employee);
            }
            catch
            {
                throw;
            }
        }
    }
}
