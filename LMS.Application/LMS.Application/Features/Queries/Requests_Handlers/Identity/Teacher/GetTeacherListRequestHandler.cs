using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.Teacher.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.Teacher{
    public class GetTeacherListRequestHandler : IRequestHandler<GetTeacherListRequest, List<TeacherDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetTeacherListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<TeacherDto>> Handle(GetTeacherListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TeacherList = await _unitofwork.TeacherRepository.GetAllAsync();
                return _mapper.Map<List<TeacherDto>>(TeacherList);
            }
            catch
            {
                throw;
            }
        }
    }
}
