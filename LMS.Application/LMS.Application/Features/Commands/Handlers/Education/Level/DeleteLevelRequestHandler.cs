using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Commands.Requests.Education.Level;
using LMS.Application.Dtos.Education;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Education.Level
{
    public class DeleteLevelRequestHandler : IRequestHandler<DeleteLevelRequest, LevelDto>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeleteLevelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<LevelDto> Handle(DeleteLevelRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var level = _mapper.Map<LMS.ApplicationCore.Entities.Education.Level>(request.IsDeleted);
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
