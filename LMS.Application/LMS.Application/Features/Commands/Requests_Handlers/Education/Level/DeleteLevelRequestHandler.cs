using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Features.Commands.Requests_Handlers.Education.Level.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.Level
{
    public class DeleteLevelRequestHandler : IRequestHandler<DeleteLevelRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeleteLevelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteLevelRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var level = await _unitOfWork.LevelRepository.GetByIdAsync(request.Id);
                if (level == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.LevelRepository.TrashAsync(level);
                await _unitOfWork.CommitAsync();
                return new BaseCommandResponse()
                {
                    Status = ResponseStatusCodes.Success,
                    Message = ResponseMessageText.SUCCESSFUL_DELETING,
                };

            }
            catch (Exception ex)
            {
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.Faild,
                    Message = ResponseMessageText.FAILD_SAVING,
                    Errors = new List<string> { ex.Message }
                };
            }
        }
    }
}
