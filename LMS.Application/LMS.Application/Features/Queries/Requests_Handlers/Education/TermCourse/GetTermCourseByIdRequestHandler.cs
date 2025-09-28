using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourse.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourse
{
    public class GetTermCourseByIdRequestHandler : IRequestHandler<GetTermCourseByIdRequest, TermCourseDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetTermCourseByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<TermCourseDto> Handle(GetTermCourseByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TermCourse = await _unitofwork.TermCourseRepository.GetByIdAsync(request.Id);
                return _mapper.Map<TermCourseDto>(TermCourse);
            }
            catch
            {
                throw;
            }
        }
    }
}
