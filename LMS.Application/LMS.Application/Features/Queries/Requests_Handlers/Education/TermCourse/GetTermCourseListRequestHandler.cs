using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourse.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourse
{
    public class GetTermCourseListRequestHandler : IRequestHandler<GetTermCourseListRequest, List<TermCourseDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetTermCourseListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<TermCourseDto>> Handle(GetTermCourseListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TermCourseList = await _unitofwork.TermCourseRepository.GetAllAsync();
                return _mapper.Map<List<TermCourseDto>>(TermCourseList);
            }
            catch
            {
                throw;
            }
        }
    }
}
