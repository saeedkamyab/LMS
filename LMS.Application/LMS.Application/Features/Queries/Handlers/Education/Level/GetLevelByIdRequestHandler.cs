using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Handlers.Education.Level.Requests;

namespace LMS.Application.Features.Queries.Handlers.Education.Level
{
    public class GetLevelByIdRequestHandler : IRequestHandler<GetLevelByIdRequest, LevelDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetLevelByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<LevelDto> Handle(GetLevelByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var level = await _unitofwork.LevelRepository.GetByIdAsync(request.Id);
                return _mapper.Map<LevelDto>(level);
            }
            catch
            {
                throw;
            }
        }
    }
}
