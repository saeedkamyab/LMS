using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType
{
    public class GetTermCourseTypeListRequestHandler : IRequestHandler<GetTermCourseTypeListRequest, List<TermCourseTypeDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetTermCourseTypeListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<TermCourseTypeDto>> Handle(GetTermCourseTypeListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TermCourseTypeList = await _unitofwork.TermCourseTypeRepository.GetAllAsync();
                return _mapper.Map<List<TermCourseTypeDto>>(TermCourseTypeList);
            }
            catch
            {
                throw;
            }
        }
    }
}
