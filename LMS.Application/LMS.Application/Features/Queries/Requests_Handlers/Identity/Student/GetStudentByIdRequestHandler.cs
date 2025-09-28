using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.Student.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Student{
    public class GetStudentByIdRequestHandler : IRequestHandler<GetStudentByIdRequest, StudentDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetStudentByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<StudentDto> Handle(GetStudentByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var Student = await _unitofwork.StudentRepository.GetByIdAsync(request.Id);
                return _mapper.Map<StudentDto>(Student);
            }
            catch
            {
                throw;
            }
        }
    }
}
