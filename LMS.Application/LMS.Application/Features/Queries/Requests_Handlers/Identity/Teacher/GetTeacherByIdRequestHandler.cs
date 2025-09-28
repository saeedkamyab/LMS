using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.Teacher.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Teacher{
    public class GetTeacherByIdRequestHandler : IRequestHandler<GetTeacherByIdRequest, TeacherDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetTeacherByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<TeacherDto> Handle(GetTeacherByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var Teacher = await _unitofwork.TeacherRepository.GetByIdAsync(request.Id);
                return _mapper.Map<TeacherDto>(Teacher);
            }
            catch
            {
                throw;
            }
        }
    }
}
