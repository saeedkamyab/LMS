using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Commands.Requests.Education.Level;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Education.Level
{
    public class UpdateLevelRequestHandler : IRequestHandler<UpdateLevelRequest, LevelDto>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public UpdateLevelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<LevelDto> Handle(UpdateLevelRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var level = _mapper.Map<LMS.ApplicationCore.Entities.Education.Level>(request.LevelDto);
                var res = _mapper.Map<LevelDto>(level);
                return res;
            }
            catch(Exception ex)
            {
                return new();
            }
        }
    }
}
