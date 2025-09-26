using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Features.Commands.Requests_Handlers.Identity.PhoneNumber.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.PhoneNumber
{
    public class DeletePhoneNumberRequestHandler : IRequestHandler<DeletePhoneNumberRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeletePhoneNumberRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeletePhoneNumberRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var PhoneNumber = await _unitOfWork.PhoneNumberRepository.GetByIdAsync(request.Id);
                if (PhoneNumber == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.PhoneNumberRepository.TrashAsync(PhoneNumber);
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
