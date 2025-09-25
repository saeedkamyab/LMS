using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Commands.Requests.Finance.PaymentTuition;
using LMS.Application.Dtos.Finance;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;

namespace LMS.Application.Features.Commands.Handlers.Finance.PaymentTuition
{
    public class DeletePaymentTuitionRequestHandler : IRequestHandler<DeletePaymentTuitionRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeletePaymentTuitionRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeletePaymentTuitionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var PaymentTuition = await _unitOfWork.PaymentTuitionRepository.GetByIdAsync(request.Id);
                if (PaymentTuition == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.PaymentTuitionRepository.TrashAsync(PaymentTuition);
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
