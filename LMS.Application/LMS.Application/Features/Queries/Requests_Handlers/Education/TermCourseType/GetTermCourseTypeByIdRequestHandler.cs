using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.TermCourseType
{
    public class GetTermCourseTypeByIdRequestHandler : IRequestHandler<GetTermCourseTypeByIdRequest, TermCourseTypeDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetTermCourseTypeByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<TermCourseTypeDto> Handle(GetTermCourseTypeByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TermCourseType = await _unitofwork.TermCourseTypeRepository.GetByIdAsync(request.Id);
                return _mapper.Map<TermCourseTypeDto>(TermCourseType);
            }
            catch
            {
                throw;
            }
        }
    }
}
