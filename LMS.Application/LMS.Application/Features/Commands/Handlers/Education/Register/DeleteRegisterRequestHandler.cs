using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Commands.Requests.Education.Register;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;

namespace LMS.Application.Features.Commands.Handlers.Education.Register
{
    public class DeleteRegisterRequestHandler : IRequestHandler<DeleteRegisterRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeleteRegisterRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteRegisterRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var Register = await _unitOfWork.RegisterRepository.GetByIdAsync(request.Id);
                if (Register == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.RegisterRepository.TrashAsync(Register);
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
