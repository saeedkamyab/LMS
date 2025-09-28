using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.Student.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Student{
    public class GetStudentListRequestHandler : IRequestHandler<GetStudentListRequest, List<StudentDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetStudentListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<StudentDto>> Handle(GetStudentListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var StudentList = await _unitofwork.StudentRepository.GetAllAsync();
                return _mapper.Map<List<StudentDto>>(StudentList);
            }
            catch
            {
                throw;
            }
        }
    }
}
