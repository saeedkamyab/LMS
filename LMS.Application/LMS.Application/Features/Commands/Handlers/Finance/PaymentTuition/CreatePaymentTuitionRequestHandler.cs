using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Finance.Validations;
using LMS.Application.Features.Commands.Requests.Finance.PaymentTuition;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Education.PaymentTuition
{
    public class CreatePaymentTuitionRequestHandler : IRequestHandler<CreatePaymentTuitionRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        PaymentTuitionValidator _validator;
        public CreatePaymentTuitionRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, PaymentTuitionValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(CreatePaymentTuitionRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.PaymentTuitionDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.ValidationError,
                    Message = ResponseMessageText.FAILD_SAVING,
                    Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                };
            }
            try
            {
                var PaymentTuition = _mapper.Map<LMS.ApplicationCore.Entities.Finance.PaymentTuition>(request.PaymentTuitionDto);
                await _unitOfWork.PaymentTuitionRepository.AddAsync(PaymentTuition);
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.Success,
                    Message = ResponseMessageText.SUCCESSFUL_SAVING,
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
