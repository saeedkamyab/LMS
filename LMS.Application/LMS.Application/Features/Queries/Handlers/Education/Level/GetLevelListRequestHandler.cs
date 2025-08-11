using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Queries.Requests.Education.Level;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Queries.Handlers.Education.Level
{
    public class GetLevelListRequestHandler : IRequestHandler<GetLevelListRequest, List<LevelDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetLevelListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<LevelDto>> Handle(GetLevelListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var levelList = await _unitofwork.LevelRepository.GetAllAsync();
                return _mapper.Map<List<LevelDto>>(levelList);
            }
            catch
            {
                throw;
            }
        }
    }
}
